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
    class IncomeView
    {

        private Draw draw;
        private Form parentForm, tagetForm;
        private Panel panel;
        private Button btn_month, btn_menu,btn_mainwindow;
        private Hashtable hashtable;

        public IncomeView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("type", "");
            hashtable.Add("size", new Size(900, 100));
            hashtable.Add("point", new Point(100, 0));
            hashtable.Add("color", Color.LightYellow);
            hashtable.Add("name", "Panel");
            panel = draw.getPanel(hashtable, parentForm);
            panel.BorderStyle = BorderStyle.FixedSingle;

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 350));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_month");
            hashtable.Add("text", "월별\n매출");
            hashtable.Add("click", (EventHandler)btn_month_click);
            btn_month = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 470));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_menu");
            hashtable.Add("text", "메뉴 관리");
            hashtable.Add("click", (EventHandler)btn_menu_click);
            btn_menu = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 590));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_mainwindow");
            hashtable.Add("text", "메인 화면");
            hashtable.Add("click", (EventHandler)btn_mainwindow_click);
            btn_mainwindow = draw.getButton(hashtable, parentForm);
        }

        private void btn_month_click(object sender, EventArgs e)
        {
            
        }

        private void btn_menu_click(object sender, EventArgs e)
        {
            
        }

        private void btn_mainwindow_click(object sender, EventArgs e)
        {
            parentForm.Close();

        }
    }
}
