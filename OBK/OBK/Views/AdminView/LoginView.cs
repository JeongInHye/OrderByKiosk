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
    class LoginView
    {
        private Draw draw;
        private Form parentForm, tagetForm;
        private Label label_title, label_pw;
        private Button btn1,btn2,btn3, btn4, btn5, btn6, btn7, btn8, btn9, btn0, btn_login,btn_clear,btn_erase;
        private TextBox textBox;
        private Hashtable hashtable;
        private string passwd = "",emp = "";

        public LoginView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("width", 200);
            hashtable.Add("point", new Point(100, 50));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "label_title");
            hashtable.Add("text", "관리자 모드");
            hashtable.Add("font", new Font("굴림", 15, FontStyle.Bold));
            label_title = draw.getLabel1(hashtable, parentForm);
            label_title.TextAlign = ContentAlignment.MiddleCenter;

            hashtable = new Hashtable();
            hashtable.Add("width", 180);
            hashtable.Add("point", new Point(130,150));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "textBox");
            hashtable.Add("enabled", true);
            textBox = draw.getTextBox(hashtable, parentForm);
            textBox.ReadOnly = true;

            hashtable = new Hashtable();
            hashtable.Add("width", 50);
            hashtable.Add("point", new Point(80, 150));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "label_pw");
            hashtable.Add("text", "PW :");
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Bold));
            label_pw = draw.getLabel1(hashtable, parentForm);
            label_pw.TextAlign = ContentAlignment.MiddleCenter;

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(90, 220));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn1");
            hashtable.Add("text", "1");
            hashtable.Add("click", (EventHandler)btn1_click);
            btn1 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(90, 280));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn4");
            hashtable.Add("text", "4");
            hashtable.Add("click", (EventHandler)btn4_click);
            btn4 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(90, 340));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn7");
            hashtable.Add("text", "7");
            hashtable.Add("click", (EventHandler)btn7_click);
            btn7 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(90, 400));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_clear");
            hashtable.Add("text", "C");
            hashtable.Add("click", (EventHandler)btn_clear_click);
            btn_clear = draw.getButton(hashtable, parentForm);
            //첫줄
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(150, 220));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn2");
            hashtable.Add("text", "2");
            hashtable.Add("click", (EventHandler)btn2_click);
            btn2 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(150, 280));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn5");
            hashtable.Add("text", "5");
            hashtable.Add("click", (EventHandler)btn5_click);
            btn5 = draw.getButton(hashtable, parentForm);
           
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(150, 340));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn8");
            hashtable.Add("text", "8");
            hashtable.Add("click", (EventHandler)btn8_click);
            btn8 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(150, 400));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn0");
            hashtable.Add("text", "0");
            hashtable.Add("click", (EventHandler)btn0_click);
            btn0 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(210, 220));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn3");
            hashtable.Add("text", "3");
            hashtable.Add("click", (EventHandler)btn3_click);
            btn3 = draw.getButton(hashtable, parentForm);

        
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(210, 280));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn6");
            hashtable.Add("text", "6");
            hashtable.Add("click", (EventHandler)btn6_click);
            btn6 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(210, 340));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn9");
            hashtable.Add("text", "9");
            hashtable.Add("click", (EventHandler)btn9_click);
            btn9 = draw.getButton(hashtable, parentForm);


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 40));
            hashtable.Add("point", new Point(210, 400));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_erase");
            hashtable.Add("text", "←");
            hashtable.Add("click", (EventHandler)btn_erase_click);
            btn_erase = draw.getButton(hashtable, parentForm);
            //세번째줄
            //============숫자버튼 생성 완료====================
            
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(40, 220));
            hashtable.Add("point", new Point(270, 220));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn_login");
            hashtable.Add("text", "L\n\no\n\ng\n\ni\n\nn");
            hashtable.Add("click", (EventHandler)btn_login_click);
            btn_login = draw.getButton(hashtable, parentForm);

        }

        private void btn_login_click(object sender, EventArgs e)
        {
            WebAPI api = new WebAPI();
            string Correctpw = api.getPasswd("http://192.168.3.31:5000/admin/passwd");


            if (passwd == Correctpw)
            {
                parentForm.Visible = false;

                tagetForm = new AdminMenuForm();
                tagetForm.StartPosition = FormStartPosition.CenterParent;
                tagetForm.FormClosed += new FormClosedEventHandler(Exit_click);
                tagetForm.Show();
            }
            else
            {
                MessageBox.Show("비밀번호를 다시 입력해 주세요.");
                textBox.Text = "";
                passwd = "";
            }
        }

        private void Exit_click(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }

        private void btn_erase_click(object sender, EventArgs e)//입력비밀번호 뒤에 1개 삭제
        {
            if (passwd!="")
            {
                passwd = passwd.Substring(0, passwd.Length - 1);
                emp = emp.Substring(0, emp.Length - 1);
            }
            ShowPasswd();
        }

        private void btn_clear_click(object sender, EventArgs e)//입력비밀번호 전체삭제
        {
            passwd = "";
            emp = "";
            ShowPasswd();
        }

        private void ShowPasswd()
        {
            emp = "";
            for(int i = 0; i < passwd.Length; i++)
            {
                emp = emp + "●";
            }
            textBox.Text = emp;
        }

        private void btn0_click(object sender, EventArgs e)
        {
            passwd = passwd + "0";
            ShowPasswd();
        }

        private void btn1_click(object sender, EventArgs e)
        {
            passwd = passwd + "1";
            ShowPasswd();
        }

        private void btn2_click(object sender, EventArgs e)
        {
            passwd = passwd + "2";
            ShowPasswd();
        }

        private void btn3_click(object sender, EventArgs e)
        {
            passwd = passwd + "3";
            ShowPasswd();
        }

        private void btn4_click(object sender, EventArgs e)
        {
            passwd = passwd + "4";
            ShowPasswd();
        }

        private void btn5_click(object sender, EventArgs e)
        {
            passwd = passwd + "5";
            ShowPasswd();
        }

        private void btn6_click(object sender, EventArgs e)
        {
            passwd = passwd + "6";
            ShowPasswd();
        }

        private void btn7_click(object sender, EventArgs e)
        {
            passwd = passwd + "7";
            ShowPasswd();
        }

        private void btn8_click(object sender, EventArgs e)
        {
            passwd = passwd + "8";
            ShowPasswd();
        }

        private void btn9_click(object sender, EventArgs e)
        {
            passwd = passwd + "9";
            ShowPasswd();
        }
    }
}
