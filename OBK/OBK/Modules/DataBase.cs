using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace OBK.Modules
{
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
                        arr[j] = jArray[j].ToString();
                    }
                    listView.Items.Add(new ListViewItem(arr));
                    listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
                    listView.Font = new Font("맑은 고딕", 14, FontStyle.Bold);
                }

                ListViewItemCollection col = listView.Items;
                for (int j = 0; j < col.Count; j++)
                {
                    for (int k = 0; k < col[j].SubItems.Count; k++)
                    {
                        col[j].SubItems[k].Font = new Font("맑은 고딕", 12, FontStyle.Regular);
                    }
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool SelectCategory(string url, ComboBox cb)
        {
            try
            {
                WebClient wc = new WebClient();
                Stream stream = wc.OpenRead(url);
                StreamReader sr = new StreamReader(stream);
                string result = sr.ReadToEnd();
                ArrayList list = JsonConvert.DeserializeObject<ArrayList>(result);

                string[] arr = new string[list.Count];
                for (int i = 0; i < list.Count; i++)
                {
                    JArray j = (JArray)list[i];
                    arr[i] = j.Value<string>(1).ToString();
                }
                cb.Items.AddRange(arr);
                cb.Font = new Font("맑은 고딕", 13, FontStyle.Bold);
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
                    MessageBox.Show("DB 성공");
                }
                else
                {
                    MessageBox.Show("DB 실패");
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool PostListview(string url, Hashtable hashtable, ListView listView)
        {
            try
            {
                WebClient wc = new WebClient();
                NameValueCollection nameValue = new NameValueCollection();

                foreach (DictionaryEntry data in hashtable)
                {
                    nameValue.Add(data.Key.ToString(), data.Value.ToString());
                }

                byte[] result = wc.UploadValues(url, "POST", nameValue);
                string resultStr = Encoding.UTF8.GetString(result);

                ArrayList list = JsonConvert.DeserializeObject<ArrayList>(resultStr);
                listView.Items.Clear();

                for (int i = 0; i < list.Count; i++)
                {
                    JArray jArray = (JArray)list[i];
                    string[] arr = new string[jArray.Count];
                    for (int j = 0; j < jArray.Count; j++)
                    {
                        arr[j] = jArray[j].ToString();

                    }
                    listView.Items.Add(new ListViewItem(arr));
                    listView.HeaderStyle = ColumnHeaderStyle.Nonclickable;

                    listView.Font = new Font("맑은 고딕", 14, FontStyle.Bold);
                }

                ListViewItemCollection col = listView.Items;
                for (int j = 0; j < col.Count; j++)
                {
                    for (int k = 0; k < col[j].SubItems.Count; k++)
                    {
                        col[j].SubItems[k].Font = new Font("맑은 고딕", 12, FontStyle.Regular);
                    }
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool MenuEdeitSelect(string url, Hashtable hashtable, TextBox txtMenu, TextBox txtPrice, TextBox txtImg, CheckBox cboxHot, CheckBox cboxSize, CheckBox cboxShot, CheckBox cboxWhip)  // 선택한 메뉴 select 해서 값 넣어주기
        {
            try
            {
                WebClient wc = new WebClient();
                NameValueCollection nameValue = new NameValueCollection();

                foreach (DictionaryEntry data in hashtable)
                {
                    nameValue.Add(data.Key.ToString(), data.Value.ToString());
                }

                byte[] result = wc.UploadValues(url, "POST", nameValue);
                string resultStr = Encoding.UTF8.GetString(result);

                ArrayList list = JsonConvert.DeserializeObject<ArrayList>(resultStr);
                for (int i = 0; i < list.Count; i++)
                {
                    JArray jArray = (JArray)list[i];

                    txtMenu.Text = jArray[0].ToString();
                    txtMenu.Font = new Font("맑은 고딕", 12, FontStyle.Regular);
                    txtPrice.Text = jArray[1].ToString();
                    txtPrice.Font = new Font("맑은 고딕", 12, FontStyle.Regular);
                    txtImg.Text = jArray[2].ToString();
                    txtImg.Font = new Font("맑은 고딕", 12, FontStyle.Regular);

                    if (jArray[3].ToString() == "1")
                    {
                        cboxHot.CheckState = CheckState.Checked;
                    }
                    if (jArray[4].ToString() == "1")
                    {
                        cboxSize.CheckState = CheckState.Checked;
                    }
                    if (jArray[5].ToString() == "1")
                    {
                        cboxShot.CheckState = CheckState.Checked;
                    }
                    if (jArray[6].ToString() == "1")
                    {
                        cboxWhip.CheckState = CheckState.Checked;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
