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
    class MonthlyView
    {
        private Draw draw;
        private Form parentForm;
        private Label lb_day1, lb_day2;
        private ListView list;
        private Button btn_search;
        private ComboBox cb_start, cb_end;
        private Hashtable hashtable;

        public MonthlyView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(80, 40));
            hashtable.Add("point", new Point(560, 20));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_month");
            hashtable.Add("text", "조회");
            hashtable.Add("font", new Font("맑은 고딕", 12, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btn_search_click);
            btn_search = draw.getButton1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "기간 :");
            hashtable.Add("point", new Point(100, 30));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_day1");
            lb_day1 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", " ~ ");
            hashtable.Add("point", new Point(330, 30));
            hashtable.Add("font", new Font("굴림", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_day2");
            lb_day2 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 150);
            hashtable.Add("point", new Point(170, 25));
            hashtable.Add("color", Color.White);
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "cb_start");
            cb_start = draw.getComboBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 150);
            hashtable.Add("point", new Point(370, 25));
            hashtable.Add("color", Color.White);
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "cb_end");
            cb_end = draw.getComboBox(hashtable, parentForm);

            //hashtable = new Hashtable();
            //hashtable.Add("",);
            //list = draw.getListView(hashtable, parentForm);

        }

        private void btn_search_click(object sender, EventArgs e)
        {
            
        }
    }
}
