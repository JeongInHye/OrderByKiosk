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
    class ChoiceView
    {
        private Form parentForm;
        private Draw draw;
        private Hashtable hashtable;
        private Button countbtn1, countbtn2,hotbtn,icebtn, shotbtn1, shotbtn2, yesbtn, nobtn;
        private PictureBox Picture;
        private Label lb_name, lb_price, lb_count1, lb_count2, lb_size, lb_shot1, lb_shot2, lb_cream, lb_allprice, lb_select, lb_must;
        private ComboBox cb_size, cb_cream;

        public ChoiceView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 150));
            hashtable.Add("point", new Point(10, 20));
            hashtable.Add("color", Color.AliceBlue);
            Picture = draw.getPictureBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "아메리카노");
            hashtable.Add("point", new Point(180, 20));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_name");
            lb_name = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "W 1,500");
            hashtable.Add("point", new Point(180, 50));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Regular));
            hashtable.Add("name", "lb_price");
            lb_price = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(30, 30));
            hashtable.Add("point", new Point(280, 100));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "countbtn1");
            hashtable.Add("text", "-");
            hashtable.Add("click", (EventHandler)countbtn1_click);
            countbtn1 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(30, 30));
            hashtable.Add("point", new Point(355, 100));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "countbtn2");
            hashtable.Add("text", "+");
            hashtable.Add("click", (EventHandler)countbtn2_click);
            countbtn2 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "수량 : ");
            hashtable.Add("point", new Point(180, 105));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Regular));
            hashtable.Add("name", "lb_count1");
            lb_count1 = draw.getLabel(hashtable, parentForm);


            hashtable = new Hashtable();
            hashtable.Add("width", 35);
            hashtable.Add("text", "1");
            hashtable.Add("point", new Point(315, 105));
            hashtable.Add("font", new Font("굴림", 15, FontStyle.Bold));
            hashtable.Add("name", "lb_count2");
            lb_count2 = draw.getLabel1(hashtable, parentForm);
            lb_count2.TextAlign = ContentAlignment.MiddleCenter;

            hashtable = new Hashtable();
            hashtable.Add("text", "---------------------- 필수사항 ----------------------");
            hashtable.Add("point", new Point(5, 180));
            hashtable.Add("font", new Font("바탕", 10, FontStyle.Regular));
            hashtable.Add("name", "lb_must");
            lb_must = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 40));
            hashtable.Add("point", new Point(10, 210));
            hashtable.Add("color", Color.IndianRed);
            hashtable.Add("name", "countbtn1");
            hashtable.Add("text", "HOT");
            hashtable.Add("click", (EventHandler)hotbtn_click);
            hotbtn = draw.getButton(hashtable, parentForm);
            hotbtn.Font = new Font("맑은고딕", 12, FontStyle.Bold);
            hotbtn.ForeColor = Color.White;


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 40));
            hashtable.Add("point", new Point(220, 210));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "countbtn2");
            hashtable.Add("text", "ICED");
            hashtable.Add("click", (EventHandler)icebtn_click);
            icebtn = draw.getButton(hashtable, parentForm);
            icebtn.Font = new Font("맑은고딕", 12, FontStyle.Bold);
            icebtn.ForeColor = Color.LightSkyBlue;

            hashtable = new Hashtable();
            hashtable.Add("text", "사이즈 : ");
            hashtable.Add("point", new Point(145, 270));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_size");
            lb_size = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 200);
            hashtable.Add("point", new Point(220, 270));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "cb_size");
            cb_size = draw.getComboBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "---------------------- 선택사항 ----------------------");
            hashtable.Add("point", new Point(5, 320));
            hashtable.Add("font", new Font("바탕", 10, FontStyle.Regular));
            hashtable.Add("name", "lb_select");
            lb_select = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(30, 30));
            hashtable.Add("point", new Point(110, 350));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "shotbtn1");
            hashtable.Add("text", "-");
            hashtable.Add("click", (EventHandler)shotbtn1_click);
            shotbtn1 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(30, 30));
            hashtable.Add("point", new Point(185, 350));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "shotbtn2");
            hashtable.Add("text", "+");
            hashtable.Add("click", (EventHandler)shotbtn2_click);
            shotbtn2 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", " 샷추가 : \n(500원)");
            hashtable.Add("point", new Point(10, 353));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Regular));
            hashtable.Add("name", "lb_shot1");
            lb_shot1 = draw.getLabel(hashtable, parentForm);
            lb_shot1.TextAlign = ContentAlignment.MiddleCenter;

            hashtable = new Hashtable();
            hashtable.Add("width", 35);
            hashtable.Add("text", "0");
            hashtable.Add("point", new Point(145, 353));
            hashtable.Add("font", new Font("굴림", 15, FontStyle.Bold));
            hashtable.Add("name", "lb_shot2");
            lb_shot2 = draw.getLabel1(hashtable, parentForm);
            lb_shot2.TextAlign = ContentAlignment.MiddleCenter;

            hashtable = new Hashtable();
            hashtable.Add("text", "휘핑 : ");
            hashtable.Add("point", new Point(240, 353));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "lb_cream");
            lb_cream = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 120);
            hashtable.Add("point", new Point(300, 350));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "cb_cream");
            cb_cream = draw.getComboBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "전체금액 : 1,500원");
            hashtable.Add("point", new Point(20, 450));
            hashtable.Add("font", new Font("맑은고딕", 16, FontStyle.Bold));
            hashtable.Add("name", "lb_allprice");
            lb_allprice = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(90, 50));
            hashtable.Add("point", new Point(330, 450));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "yesbtn");
            hashtable.Add("text", "확인");
            hashtable.Add("click", (EventHandler)yesbtn_click);
            yesbtn = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(90, 50));
            hashtable.Add("point", new Point(220, 450));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "nobtn");
            hashtable.Add("text", "취소");
            hashtable.Add("click", (EventHandler)nobtn_click);
            nobtn = draw.getButton(hashtable, parentForm);
        }

        private void yesbtn_click(object sender, EventArgs e)
        {
            MessageBox.Show(lb_name.Text+" "+lb_count2.Text+"개 추가!!");
            parentForm.Close();
        }

        private void nobtn_click(object sender, EventArgs e)
        {
            parentForm.Close();
        }

        private void countbtn1_click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_count2.Text) > 1)
            {
                int minus = Convert.ToInt32(lb_count2.Text) - 1;
                lb_count2.Text = minus.ToString();
            }
        }

        private void countbtn2_click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_count2.Text) < 10)
            {
                int plus = Convert.ToInt32(lb_count2.Text) + 1;
                lb_count2.Text = plus.ToString();
            }
        }

        private void hotbtn_click(object sender, EventArgs e)
        {
            hotbtn.ForeColor = Color.White;
            hotbtn.BackColor = Color.IndianRed;
            icebtn.ForeColor = Color.LightSkyBlue;
            icebtn.BackColor = Color.White;
        }

        private void icebtn_click(object sender, EventArgs e)
        {
            hotbtn.ForeColor = Color.IndianRed;
            hotbtn.BackColor = Color.White;
            icebtn.ForeColor = Color.White;
            icebtn.BackColor = Color.LightSkyBlue;
        }

        private void shotbtn1_click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_shot2.Text) > 0)
            {
                int minus = Convert.ToInt32(lb_shot2.Text) - 1;
                lb_shot2.Text = minus.ToString();
            }
        }

        private void shotbtn2_click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lb_shot2.Text) < 10)
            {
                int plus = Convert.ToInt32(lb_shot2.Text) + 1;
                lb_shot2.Text = plus.ToString();
            }
        }

    }
}
