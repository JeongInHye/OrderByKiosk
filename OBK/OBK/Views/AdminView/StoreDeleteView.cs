using OBK.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Views.AdminView
{
    class StoreDeleteView
    {
        private WebAPI api;
        private Draw draw;
        private Form parentForm;
        private ListView liststore;
        private Button button_storedelete;
        private Hashtable hashtable;

        public StoreDeleteView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            api = new WebAPI();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(620, 400));
            hashtable.Add("point", new Point(30, 30));
            hashtable.Add("name", "liststore");
            liststore = draw.getListView(hashtable, parentForm);
            liststore.Columns.Add("", 30, HorizontalAlignment.Center);
            liststore.Columns.Add("매장명", 240, HorizontalAlignment.Center);
            liststore.Columns.Add("위치", 345, HorizontalAlignment.Center);
            //liststore.Items.Add(new ListViewItem(new string[] { " ", "가산디지털점","서울특별시 금천구" }));

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 50));
            hashtable.Add("point", new Point(490, 440));
            hashtable.Add("color", Color.FromArgb(246, 246, 246));
            hashtable.Add("name", "button_storedelete");
            hashtable.Add("text", "매장 삭제");
            hashtable.Add("font", new Font("맑은 고딕", 15, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)button_storedelete_click);
            button_storedelete = draw.getButton1(hashtable, parentForm);

            getData();
        }

        private void button_storedelete_click(object sender, EventArgs e)
        {
            foreach (ListViewItem listitem in liststore.Items)
            {
                if (liststore.Items.Count > 0)
                {
                    for (int i = liststore.Items.Count - 1; i >= 0; i--)
                    {
                        if (liststore.Items[i].Checked == true)
                        {
                            MessageBox.Show(liststore.Items[i].SubItems[1].Text);
                            liststore.Items[i].Remove();
                        }
                    }
                }
            }
        }

        private void getData()
        {
            api.ListView("http://localhost:5000/Store/select", liststore);
        }
    }
}
