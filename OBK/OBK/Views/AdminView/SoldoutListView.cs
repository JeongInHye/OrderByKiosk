using OBK.Forms.AdminForm;
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
    class SoldoutListView
    {
        private Draw draw;
        private Form parentForm, tagetForm;
        private ListView soldoutlist;
        private Label lb_main;
        private Button btn_mainwindow;
        private Hashtable hashtable;

        public SoldoutListView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("text", "품절목록");
            hashtable.Add("point", new Point(20, 20));
            hashtable.Add("font", new Font("맑은고딕", 30, FontStyle.Regular));
            hashtable.Add("name", "lb_main");
            lb_main = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(660, 520));
            hashtable.Add("point", new Point(200, 20));
            hashtable.Add("name", "list");
            hashtable.Add("color", Color.White);
            hashtable.Add("click", (MouseEventHandler)lv_click);
            soldoutlist = draw.getListView1(hashtable, parentForm);

            soldoutlist.Columns.Add("카테고리", 200, HorizontalAlignment.Center);
            soldoutlist.Columns.Add("메뉴명", 200, HorizontalAlignment.Center);
            soldoutlist.Columns.Add("지점명", 255, HorizontalAlignment.Center);

            soldoutlist.Items.Add(new ListViewItem(new string[] { "커피", "아메리카노", "강남점" }));
            soldoutlist.Items.Add(new ListViewItem(new string[] { "커피", "카푸치노", "가산점" }));
            soldoutlist.Items.Add(new ListViewItem(new string[] { "티", "얼그레이", "강남점" }));
            soldoutlist.Items.Add(new ListViewItem(new string[] { "디저트", "베이글", "강남점" }));

            //----------------------------------------
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 60));
            hashtable.Add("point", new Point(20, 480));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_mainwindow");
            hashtable.Add("text", "메인화면");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btn_mainwindow_click);
            btn_mainwindow = draw.getButton1(hashtable, parentForm);
        }

        private void lv_click(object sender, MouseEventArgs e)
        {

        }

        private void btn_mainwindow_click(object sender, EventArgs e)
        {
            parentForm.Visible = false;
            tagetForm = new AdminMenuForm();
            tagetForm.StartPosition = parentForm.StartPosition;
            tagetForm.FormClosed += new FormClosedEventHandler(Exit_click);

            tagetForm.Show();
        }

        private void Exit_click(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }
    }
}
