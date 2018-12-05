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
        private Label label1, label2, label3, label4, label5, label6, label7,label8, label9, label10;
        private ListView list;
        private Hashtable hashtable;

        public BillView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
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
            hashtable.Add("size", new Size(400, 100));
            hashtable.Add("point", new Point(25, 165));
            hashtable.Add("name", "주문리스트");
            list = draw.getListView(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "----------------------------------------------------------------------");
            hashtable.Add("point", new Point(18, 300));
            hashtable.Add("name", "선");
            label7 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "합계");
            hashtable.Add("point", new Point(25, 320));
            hashtable.Add("font", new Font("굴림", 12,FontStyle.Bold));
            hashtable.Add("name", "합계");
            label8 = draw.getLabel(hashtable, parentForm);
        }
    }
}
