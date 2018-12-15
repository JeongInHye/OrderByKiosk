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
    class MenuIncomView
    {
        private Draw draw;
        private Form parentForm;
        private Label lb_day1, lb_day2,lb_info;
        private ListView list;
        private Button btn_search;
        private ComboBox cb_start, cb_end;
        private DateTimePicker dtp_start, dtp_end;
        private Hashtable hashtable;

        public MenuIncomView(Form parentForm)
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
            hashtable.Add("point", new Point(40, 30));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_day1");
            lb_day1 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", " ~ ");
            hashtable.Add("point", new Point(300, 30));
            hashtable.Add("font", new Font("굴림", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_day2");
            lb_day2 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "* 매출액기준 내림차순");
            hashtable.Add("point", new Point(20, 75));
            hashtable.Add("font", new Font("굴림", 8, FontStyle.Regular));
            hashtable.Add("name", "lb_info");
            lb_info = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(180, 40));
            hashtable.Add("point", new Point(110, 25));
            hashtable.Add("name", "dtp_start");
            dtp_start = draw.GetDateTimePicker(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(180,40));
            hashtable.Add("point", new Point(340, 25));
            hashtable.Add("name", "dtp_end");
            dtp_end = draw.GetDateTimePicker(hashtable, parentForm);


            //hashtable = new Hashtable();
            //hashtable.Add("width", 180);
            //hashtable.Add("point", new Point(110, 25));
            //hashtable.Add("color", Color.White);
            //hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            //hashtable.Add("name", "cb_start");
            //cb_start = draw.getComboBox(hashtable, parentForm);

            //hashtable = new Hashtable();
            //hashtable.Add("width", 180);
            //hashtable.Add("point", new Point(340, 25));
            //hashtable.Add("color", Color.White);
            //hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            //hashtable.Add("name", "cb_end");
            //cb_end = draw.getComboBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(660, 420));
            hashtable.Add("point", new Point(10, 90));
            hashtable.Add("name", "list");
            hashtable.Add("color", Color.White);
            hashtable.Add("click", (MouseEventHandler)lv_click);
            list = draw.getListView(hashtable, parentForm);

            list.Columns.Add("해당 년/월", 200, HorizontalAlignment.Center);
            list.Columns.Add("수량", 100, HorizontalAlignment.Center);
            list.Columns.Add("매출액", 360, HorizontalAlignment.Center);
        }

        private void lv_click(object sender, MouseEventArgs e)
        {

        }

        private void btn_search_click(object sender, EventArgs e)
        {

        }
    }
}
