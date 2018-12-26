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
        private Label lb_day1, lb_day2, lb_info;
        private ListView list;
        private Button btn_search;
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
            hashtable.Add("point", new Point(40, 27));
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
            hashtable.Add("point", new Point(110, 26));
            hashtable.Add("name", "dtp_start");
            dtp_start = draw.GetDateTimePicker(hashtable, parentForm);
            dtp_start.Value = DateTime.Today.AddMonths(-1);
            dtp_start.Format = DateTimePickerFormat.Custom;
            dtp_start.CustomFormat = "yyyy년 MMMM";

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(180, 40));
            hashtable.Add("point", new Point(340, 26));
            hashtable.Add("name", "dtp_end");
            dtp_end = draw.GetDateTimePicker(hashtable, parentForm);
            dtp_end.Format = DateTimePickerFormat.Custom;
            dtp_end.CustomFormat = "yyyy년 MMMM";

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(660, 420));
            hashtable.Add("point", new Point(10, 90));
            hashtable.Add("name", "list");
            hashtable.Add("color", Color.White);
            //hashtable.Add("click", (MouseEventHandler)lv_click);
            list = draw.getListView1(hashtable, parentForm);
            list.ColumnWidthChanging += List_ColumnWidthChanging;

            list.Columns.Add("해당 년/월", 130, HorizontalAlignment.Center);
            list.Columns.Add("메뉴명", 180, HorizontalAlignment.Center);
            list.Columns.Add("수량", 70, HorizontalAlignment.Center);
            list.Columns.Add("매출액", 270, HorizontalAlignment.Center);
        }
        
        private void btn_search_click(object sender, EventArgs e)
        {
            string startDate = dtp_start.Value.ToString("yyyy-MM");
            string endDate = dtp_end.Value.ToString("yyyy-MM");
            //MessageBox.Show("시작년월-->"+startDate+"\n종료년월-->"+ endDate);
            WebAPI api = new WebAPI();
            Hashtable ht = new Hashtable();
            ht.Add("startdate", startDate);
            ht.Add("enddate", endDate);
            api.PostListview(Program.serverUrl + "admin/selectMenuIncome", ht, list);
        }

        private void List_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = list.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
    }
}
