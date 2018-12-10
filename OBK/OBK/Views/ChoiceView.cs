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
        private Label lb_name, lb_price, lb_count1, lb_count2, lb_size, lb_shot1, lb_shot2, lb_allprice, lb_select, lb_must;
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
            hashtable.Add("size", new Size(30, 30));
            hashtable.Add("point", new Point(285, 100));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "countbtn1");
            hashtable.Add("text", "-");
            hashtable.Add("click", (EventHandler)countbtn1_click);
            countbtn1 = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(30, 30));
            hashtable.Add("point", new Point(350, 100));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "countbtn2");
            hashtable.Add("text", "+");
            hashtable.Add("click", (EventHandler)countbtn2_click);
            countbtn2 = draw.getButton(hashtable, parentForm);
            

            hashtable = new Hashtable();
            hashtable.Add("width", 80);
            hashtable.Add("text", "아메리카노");
            hashtable.Add("point", new Point(170, 20));
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Regular));
            hashtable.Add("name", "lb_name");
            lb_name = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 80);
            hashtable.Add("text", "W 1,500");
            hashtable.Add("point", new Point(170, 50));
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Regular));
            hashtable.Add("name", "lb_price");
            lb_price = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 80);
            hashtable.Add("text", "수량 : ");
            hashtable.Add("point", new Point(180, 100));
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Regular));
            hashtable.Add("name", "lb_count1");
            lb_count1 = draw.getLabel1(hashtable, parentForm);


            hashtable = new Hashtable();
            hashtable.Add("width", 40);
            hashtable.Add("text", "1");
            hashtable.Add("point", new Point(300, 105));
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Regular));
            hashtable.Add("name", "lb_count2");
            lb_count2 = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 400);
            hashtable.Add("text", "------------------------- 필수사항 -----------------------------");
            hashtable.Add("point", new Point(10, 180));
            hashtable.Add("font", new Font("바탕", 10, FontStyle.Regular));
            hashtable.Add("name", "lb_must");
            lb_must = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 40));
            hashtable.Add("point", new Point(20, 200));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "countbtn1");
            hashtable.Add("text", "-");
            hashtable.Add("click", (EventHandler)countbtn1_click);
            hotbtn = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 40));
            hashtable.Add("point", new Point(230, 200));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "countbtn2");
            hashtable.Add("text", "+");
            hashtable.Add("click", (EventHandler)countbtn2_click);
            icebtn = draw.getButton(hashtable, parentForm);

        }

        private void countbtn1_click(object sender, EventArgs e)
        {

        }

        private void countbtn2_click(object sender, EventArgs e)
        {

        }
    }
}
