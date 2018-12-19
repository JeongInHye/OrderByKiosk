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
    class StoreListView
    {
        private WebAPI api;
        private Draw draw;
        private Form parentForm;
        private ListView listStore;
        private Hashtable hashtable;

        public StoreListView(Form parentForm)
        {
            this.parentForm = parentForm;
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
            listStore = draw.getListView1(hashtable, parentForm);
            listStore.Columns.Add("", 0, HorizontalAlignment.Center);
            listStore.Columns.Add("매장명", 250, HorizontalAlignment.Center);
            listStore.Columns.Add("위치", 350, HorizontalAlignment.Center);
            //listStore.Items.Add(new ListViewItem(new string[] {"","가산디지털점", "서울특별시 금천구" }));

            getData();
        }

        private void getData()
        {
            api.ListView("http://localhost:5000/Store/select", listStore);
        }
    }
}