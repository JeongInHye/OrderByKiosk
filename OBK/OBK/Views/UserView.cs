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
        private Form parentForm;
        private Hashtable hashtable;
        private Draw draw;
        private Button btn1, btn2, btn3, btn4;
        private ListView lv;

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
            hashtable.Add("color", Color.AliceBlue);
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
            //==============menu패널에 메뉴리스트===========================




            //==============bottom패널에 리스트뷰와 버튼=====================
            hashtable = new Hashtable();
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "listView");
            hashtable.Add("point", new Point(5, 5));
            hashtable.Add("size", new Size(600, 200));
            //hashtable.Add("click", (MouseEventHandler)listView_click);
            lv = draw.getListView(hashtable, bottom);

        }


        private void btn1_click(object sender, EventArgs e)
        {
            
        }
        
        private void btn2_click(object sender, EventArgs e)
        {

        }

        private void btn3_click(object sender, EventArgs e)
        {

        }

        private void btn4_click(object sender, EventArgs e)
        {

        }

    }
}
