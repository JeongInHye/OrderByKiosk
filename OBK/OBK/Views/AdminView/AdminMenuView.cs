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
        private Label label1, label2, label3, label4, label5, label6;
        private ListView list;
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
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 350));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn1");
            hashtable.Add("text", "매출 현황");
            hashtable.Add("click", (EventHandler)btn1_click);
            btn1 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 470));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn2");
            hashtable.Add("text", "메뉴 관리");
            hashtable.Add("click", (EventHandler)btn2_click);
            btn2 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 590));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn3");
            hashtable.Add("text", "품절 목록");
            hashtable.Add("click", (EventHandler)btn3_click);
            btn3 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(600, 80));
            hashtable.Add("point", new Point(100, 710));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "btn4");
            hashtable.Add("text", "매장 관리");
            hashtable.Add("click", (EventHandler)btn4_click);
            btn4 = draw.getButton(hashtable, parentForm);
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

        private void btn4_click(object sender, EventArgs e)
        {
            parentForm.Visible = false;

            tagetForm = new StoreForm();
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
