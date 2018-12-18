using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Modules
{
    class MYsql
    {
        private MySqlConnection conn;
        public bool status;

        public MYsql()
        {
            status = Connection();
        }

        private bool Connection()
        {
            string host = "192.168.3.8";
            string user = "root";
            string password = "1234";
            string db = "obk";

            string connStr = string.Format(@"server={0};user={1};password={2};database={3}", host, user, password, db);
            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                conn.Open();
                this.conn = conn;
                //MessageBox.Show("MS-SQL 연결 성공!");
                return true;
            }
            catch
            {
                conn.Close();
                this.conn = null;
                //MessageBox.Show("MS-SQL 연결 실패!");
                return false;
            }
        }

        public bool ConnectionClose()
        {
            try
            {
                conn.Close();
                //MessageBox.Show("MS-SQL 연결끊기 성공!");
                return true;
            }
            catch
            {
                //MessageBox.Show("MS-SQL 연결끊기 실패!");
                return false;
            }
        }

        public bool NonQuery(string sql)
        {
            try
            {
                if (status)
                {
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    comm.ExecuteNonQuery();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public MySqlDataReader Reader(string sql)
        {
            try
            {
                if (status)
                {
                    MySqlCommand comm = new MySqlCommand(sql, conn);
                    return comm.ExecuteReader();
                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }

        public void ReaderClose(MySqlDataReader reader)
        {
            reader.Close();
        }
    }


    class WebAPI
    {
        public bool ListView(string url, ListView listView)
        {
            try
            {
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(url);
                StreamReader sr = new StreamReader(stream);
                string result = sr.ReadToEnd();
                ArrayList list = JsonConvert.DeserializeObject<ArrayList>(result);
                listView.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    JArray jArray = (JArray)list[i];
                    string[] arr = new string[jArray.Count];
                    for (int j = 0; j < jArray.Count; j++)
                    {
                        //MessageBox.Show(jArray[j].ToString());
                        arr[j] = jArray[j].ToString();
                    }
                    listView.Items.Add(new ListViewItem(arr));
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Post(string url, Hashtable ht)
        {
            try
            {
                WebClient wc = new WebClient();
                NameValueCollection nameValue = new NameValueCollection();

                foreach (DictionaryEntry data in ht)
                {
                    nameValue.Add(data.Key.ToString(), data.Value.ToString());
                }

                byte[] result = wc.UploadValues(url, "POST", nameValue);
                string resultStr = Encoding.UTF8.GetString(result);
                if ("1" == resultStr)
                {
                    MessageBox.Show("성공");
                }
                else
                {
                    MessageBox.Show("실패");
                }
                //MessageBox.Show(resultStr);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
