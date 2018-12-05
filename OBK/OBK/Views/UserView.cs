using OBK.Forms;
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
    class UserView
    {
        private Panel head, menu, bottom;
        private Form parentForm, tagetForm;
        private Hashtable hashtable;
        private Draw draw;
        private Button btn1, btn2, btn3, btn4,btn11,btn12,btn13;
        private ListView lv;
        private Label label;
        public UserView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            //=====panel 선언부분========head,menus,bottom
            hashtable = new Hashtable();
            hashtable.Add("type", "");
            hashtable.Add("size", new Size(900, 100));
            hashtable.Add("point", new Point(0, 0));
            hashtable.Add("color", Color.LightYellow);
            hashtable.Add("name", "head");
            head = draw.getPanel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(900, 500));
            hashtable.Add("point", new Point(0, 100));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "menus");
            menu = draw.getPanel(hashtable, parentForm);
            
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(900, 300));
            hashtable.Add("point", new Point(0, 600));
            hashtable.Add("color", Color.LightYellow);
            hashtable.Add("name", "bottom");
            bottom = draw.getPanel(hashtable, parentForm);

            //=========head패널에 버튼부분==============
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(160, 100));
            hashtable.Add("point", new Point(30, 10));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn1");
            hashtable.Add("text", "커피");
            hashtable.Add("click", (EventHandler)btn1_click);
            btn1 = draw.getButton(hashtable, head);
            
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(160, 100));
            hashtable.Add("point", new Point(220, 10));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn2");
            hashtable.Add("text", "음료");
            hashtable.Add("click", (EventHandler)btn2_click);
            btn2 = draw.getButton(hashtable, head);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(160, 100));
            hashtable.Add("point", new Point(410, 10));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn3");
            hashtable.Add("text", "티");
            hashtable.Add("click", (EventHandler)btn3_click);
            btn3 = draw.getButton(hashtable, head);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(160, 100));
            hashtable.Add("point", new Point(600, 10));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn4");
            hashtable.Add("text", "디저트");
            hashtable.Add("click", (EventHandler)btn4_click);
            btn4 = draw.getButton(hashtable, head);
            //============== bottom패널에 리스트뷰와 버튼================
            hashtable = new Hashtable();
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "listView");
            hashtable.Add("point", new Point(5, 5));
            hashtable.Add("size", new Size(600, 220));
            hashtable.Add("click", (MouseEventHandler)listView_click);
            lv = draw.getListView(hashtable, bottom);
            lv.Columns.Add("", 0, HorizontalAlignment.Center);
            lv.Columns.Add("메뉴이름",200,HorizontalAlignment.Center);
            lv.Columns.Add("가격", 200, HorizontalAlignment.Center);
            lv.Columns.Add("수량", 200, HorizontalAlignment.Center);

            hashtable = new Hashtable();
            hashtable.Add("text", "총 가격 : 30,000원");
            hashtable.Add("width",610);
            hashtable.Add("point", new Point(0, 230));
            hashtable.Add("name", "totalprice");
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            label = draw.getLabel1(hashtable, bottom);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 60));
            hashtable.Add("point", new Point(620, 20));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn11");
            hashtable.Add("text", "선택삭제");
            hashtable.Add("click", (EventHandler)btn11_click);
            btn11 = draw.getButton(hashtable, bottom);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 60));
            hashtable.Add("point", new Point(620, 100));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn12");
            hashtable.Add("text", "전체삭제");
            hashtable.Add("click", (EventHandler)btn12_click);
            btn12 = draw.getButton(hashtable, bottom);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 60));
            hashtable.Add("point", new Point(620, 180));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btn13");
            hashtable.Add("text", "주문결제");
            hashtable.Add("click", (EventHandler)btn13_click);
            btn13 = draw.getButton(hashtable, bottom);

            btn1.BackColor = Color.White;

            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = draw.getMdiForm(parentForm, new MenuForm(1), menu);
            tagetForm.Show();
            ;
        }


        
        private void btn11_click(object sender, EventArgs e)
        {
            
        }

        private void btn12_click(object sender, EventArgs e)
        {
            
        }

        private void btn13_click(object sender, EventArgs e)
        {
            BillForm bf = new BillForm();
            Point p = new Point((parentForm.Width - bf.Width) / 2, (parentForm.Height - bf.Height) / 2);
            bf.StartPosition = parentForm.StartPosition;
            bf.ShowDialog();
        }

        private void listView_click(object sender, MouseEventArgs e)
        {

        }

        //=====커피 버튼을 눌렀을때 menu패널에 커피에 대한 메뉴들 출력=====
        private void btn1_click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.White;
            btn2.BackColor = Color.LightGray;
            btn3.BackColor = Color.LightGray;
            btn4.BackColor = Color.LightGray;

            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = draw.getMdiForm(parentForm, new MenuForm(1), menu);
            tagetForm.Show();
        }
        //=====음료 버튼을 눌렀을때 menu패널에 음료에 대한 메뉴들 출력=====
        private void btn2_click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.LightGray;
            btn2.BackColor = Color.White; 
            btn3.BackColor = Color.LightGray;
            btn4.BackColor = Color.LightGray;
            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = draw.getMdiForm(parentForm, new MenuForm(2), menu);
            tagetForm.Show();
        }
        //=====티 버튼을 눌렀을때 menu패널에 티에 대한 메뉴들 출력=====
        private void btn3_click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.LightGray;
            btn2.BackColor = Color.LightGray;
            btn3.BackColor = Color.White; 
            btn4.BackColor = Color.LightGray;
            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = draw.getMdiForm(parentForm, new MenuForm(3), menu);
            tagetForm.Show();
        }
        //=====디저트 버튼을 눌렀을때 menu패널에 디저트에 대한 메뉴들 출력=====
        private void btn4_click(object sender, EventArgs e)
        {
            btn1.BackColor = Color.LightGray;
            btn2.BackColor = Color.LightGray;
            btn3.BackColor = Color.LightGray;
            btn4.BackColor = Color.White; 
            // form 초기화
            if (tagetForm != null) tagetForm.Dispose();
            // form 호출
            tagetForm = draw.getMdiForm(parentForm, new MenuForm(4), menu);
            tagetForm.Show();
        }
    }
}
