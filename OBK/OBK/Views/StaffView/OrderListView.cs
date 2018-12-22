using OBK.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Views.StaffView
{
    class OrderListView
    {
        private Draw draw;
        private Form parentForm;
        private Hashtable hashtable;
        private ListView list;
        private Button btnOk;


        public OrderListView(Form parentForm)
        {
            this.parentForm = parentForm;
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(665, 250));
            hashtable.Add("point", new Point(10, 10));
            hashtable.Add("name", "주문리스트");
            list = draw.getListView(hashtable, parentForm);
            list.Columns.Add("", 25, HorizontalAlignment.Center);
            list.Columns.Add("주문번호", 120, HorizontalAlignment.Center);
            list.Columns.Add("메뉴", 200, HorizontalAlignment.Center);
            list.Columns.Add("샷추가", 108, HorizontalAlignment.Center);
            list.Columns.Add("휘핑", 108, HorizontalAlignment.Center);
            list.Columns.Add("수량", 100, HorizontalAlignment.Center);
            list.Font = new Font("맑은 고딕", 14, FontStyle.Bold);
            list.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            list.ColumnWidthChanging += List_ColumnWidthChanging;

            //_____________________________________________________________________

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(160, 60));
            hashtable.Add("point", new Point(510, 270));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "ok");
            hashtable.Add("text", "확인");
            hashtable.Add("click", (EventHandler)btn_click);
            btnOk = draw.getButton(hashtable, parentForm);

        }

        private void List_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btn_click(object o, EventArgs a)
        {
            foreach (ListViewItem listitem in list.Items)
            {
                if (list.Items.Count > 0)
                {
                    for (int i = list.Items.Count - 1; i >= 0; i--)
                    {
                        if (list.Items[i].Checked == true)
                        {
                            list.Items[i].Remove();
                        }
                    }
                }
            }
        }
    }
}
