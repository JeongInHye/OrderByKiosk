using OBK.Forms;
using OBK.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Views
{
    class BillView
    {
        //private MYsql db;
        private Draw draw;
        private Form parentForm;
        private Label label1, label2, label3, label4, label5, label6;
        private ListView list;
        private Button button;
        private Hashtable hashtable;

        public BillView(Form parentForm)
        {
            this.parentForm = parentForm;
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("text", "----------------------------------------------------------------------");
            hashtable.Add("point", new Point(18, 100));
            hashtable.Add("name", "선");
            label1 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "주문번호 : {0}");
            hashtable.Add("point", new Point(150, 111));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            label2 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "----------------------------------------------------------------------");
            hashtable.Add("point", new Point(18, 150));
            hashtable.Add("name", "선");
            label3 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(400, 110));
            hashtable.Add("point", new Point(25, 165));
            hashtable.Add("name", "주문리스트");
            list = draw.getListView(hashtable, parentForm);
            list.Columns.Add("", 0);
            list.Columns.Add("메뉴", 250, HorizontalAlignment.Center);
            list.Columns.Add("가격", 79, HorizontalAlignment.Center);
            list.Columns.Add("수량", 70, HorizontalAlignment.Center);
            list.ColumnWidthChanging += List_ColumnWidthChanging;

            hashtable = new Hashtable();
            hashtable.Add("text", "----------------------------------------------------------------------");
            hashtable.Add("point", new Point(18, 300));
            hashtable.Add("name", "선");
            label4 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "합계");
            hashtable.Add("point", new Point(25, 320));
            hashtable.Add("font", new Font("굴림", 12,FontStyle.Bold));
            hashtable.Add("name", "합계");
            label5 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "3,000"); // db에서 갖구오기이
            hashtable.Add("point", new Point(290, 320));
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Bold));
            hashtable.Add("name", "합계");
            label6 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(100, 50));
            hashtable.Add("point", new Point(350, 390));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "ok");
            hashtable.Add("text", "확인");
            hashtable.Add("click", (EventHandler)btn_click);
            button = draw.getButton(hashtable, parentForm);
        }

        private void List_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btn_click(object o, EventArgs a)
        {
            parentForm.Close();
        }

        
    }
}
