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
    class AdminMenuView
    {
        private Draw draw;
        private Form parentForm, tagetForm;
        private Label lb_main;
        private Button btn1,btn2,btn3,btn4;
        private Hashtable hashtable;

        public AdminMenuView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("text", "관리자 메인 화면");
            hashtable.Add("point", new Point(170, 50));
            hashtable.Add("font", new Font("맑은고딕", 40, FontStyle.Bold));
            hashtable.Add("name", "lb_main");
            lb_main = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(500, 80));
            hashtable.Add("point", new Point(100, 300));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn1");
            hashtable.Add("text", "매출 현황");
            hashtable.Add("click", (EventHandler)btn1_click);
            btn1 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(500, 80));
            hashtable.Add("point", new Point(100, 420));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn2");
            hashtable.Add("text", "메뉴 관리");
            hashtable.Add("click", (EventHandler)btn2_click);
            btn2 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(500, 80));
            hashtable.Add("point", new Point(100, 540));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn3");
            hashtable.Add("text", "품절 목록");
            hashtable.Add("click", (EventHandler)btn3_click);
            btn3 = draw.getButton(hashtable, parentForm);
        }

        private void btn1_click(object sender, EventArgs e)
        {
            parentForm.Visible = false;

            tagetForm = new IncomeForm();
            tagetForm.StartPosition = FormStartPosition.CenterParent;
            tagetForm.FormClosed += new FormClosedEventHandler(Exit_click);
            tagetForm.Show();
        }

    private void btn2_click(object sender, EventArgs e)
        {
            parentForm.Visible = false;

            tagetForm = new MenuSettingForm();
            tagetForm.StartPosition = FormStartPosition.CenterParent;
            tagetForm.FormClosed += new FormClosedEventHandler(Exit_click);
            tagetForm.Show();
        }

        private void btn3_click(object sender, EventArgs e)
        {
            parentForm.Visible = false;

            tagetForm = new SoldoutListForm();
            tagetForm.StartPosition = FormStartPosition.CenterParent;
            tagetForm.FormClosed += new FormClosedEventHandler(Exit_click);
            tagetForm.Show();
        }

        private void Exit_click(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }
    }
}
