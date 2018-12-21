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
using static System.Windows.Forms.ListView;

namespace OBK.Views
{
    class UserView
    {
        private WebAPI api;
        private Panel head, menu, bottom;
        private Form parentForm, tagetForm;
        private Hashtable hashtable;
        private Draw draw;
        private Button btn1, btn2, btn3, btn4, btn11, btn12, btn13;
        private ListView lv;
        private Label label;
        private int menuclick = 1;

        public UserView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            api = new WebAPI();
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
            hashtable.Add("size", new Size(785, 500));
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
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("click", (EventHandler)btn_click);
            ArrayList buttonlist = api.CategoryButton(Program.serverUrl+"category/select", hashtable);
            for (int i = 0; i < buttonlist.Count; i++)
            {
                Hashtable ht = (Hashtable)buttonlist[i];
                switch (i)
                {
                    case 0:
                        btn1 = draw.getButton(ht, head);
                        break;
                    case 1:
                        btn2 = draw.getButton(ht, head);
                        break;
                    case 2:
                        btn3 = draw.getButton(ht, head);
                        break;
                    case 3:
                        btn4 = draw.getButton(ht, head);
                        break;
                    default: break;
                }
                
            }
            //============== bottom패널에 리스트뷰와 버튼================
            hashtable = new Hashtable();
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "listView");
            hashtable.Add("point", new Point(5, 5));
            hashtable.Add("size", new Size(600, 220));
            hashtable.Add("click", (MouseEventHandler)listView_click);
            lv = draw.getListView1(hashtable, bottom);
            lv.Columns.Add("", 0, HorizontalAlignment.Center);
            lv.Columns.Add("메뉴이름", 200, HorizontalAlignment.Center);
            lv.Columns.Add("샷추가", 80, HorizontalAlignment.Center);
            lv.Columns.Add("휘핑", 90, HorizontalAlignment.Center);
            lv.Columns.Add("수량", 80, HorizontalAlignment.Center);
            lv.Columns.Add("가격", 145, HorizontalAlignment.Center);
            lv.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lv.Font = new Font("맑은고딕", 14, FontStyle.Bold);
            lv.ColumnWidthChanging += ListView_ColumnWidthChanging;
            api.ListView(Program.serverUrl+"orderlist/select",lv);

            hashtable = new Hashtable();
            hashtable.Add("text", "");
            hashtable.Add("width", 610);
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
            tagetForm = draw.getMdiForm(parentForm, new MenuForm(parentForm,menuclick), menu);
            tagetForm.Show();
            OrderlistLoad();
        }

        private void OrderlistLoad()
        {
            int allprice = 0;
            ListViewItemCollection col = lv.Items;
            for(int j = 0; j < col.Count; j++)
            {
                for (int k = 0; k < col[j].SubItems.Count; k++)
                {
                    col[j].SubItems[k].Font = new Font("맑은고딕", 12, FontStyle.Regular);
                }
            }
            for (int i = 0; i < lv.Items.Count; i++)
            {
                allprice += Convert.ToInt32(lv.Items[i].SubItems[5].Text)* Convert.ToInt32(lv.Items[i].SubItems[4].Text);
            }
            label.Text = "총 가격 : " + allprice + "원";
        }

        private void btn11_click(object sender, EventArgs e)
        {

        }

        private void btn12_click(object sender, EventArgs e)
        {

        }

        private void btn13_click(object sender, EventArgs e)
        {
            parentForm.Visible = false;
            PayForm pf = new PayForm();
            pf.StartPosition = FormStartPosition.CenterParent;
            pf.FormClosed += new FormClosedEventHandler(exit_click);
            pf.Show();
        }

        private void exit_click(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }

        private void listView_click(object sender, MouseEventArgs e)
        {

        }

        private void ListView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)    // 카테고리 리트스 칼럼크기 막음
        {
            e.NewWidth = lv.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btn_click(object sender, EventArgs e) //카테고리 버튼 클릭 이벤트
        {
            Button b = (Button)sender;
            switch (b.Name)
            {
                case "btn1":
                    menuclick = 1;
                    btn1.BackColor = Color.White;
                    btn2.BackColor = Color.LightGray;
                    btn3.BackColor = Color.LightGray;
                    btn4.BackColor = Color.LightGray;

                    // form 초기화
                    if (tagetForm != null) tagetForm.Dispose();
                    // form 호출
                    tagetForm = draw.getMdiForm(parentForm, new MenuForm(parentForm,menuclick), menu);
                    tagetForm.Show();
                    break;
                case "btn2":
                    menuclick = 2;
                    btn1.BackColor = Color.LightGray;
                    btn2.BackColor = Color.White;
                    btn3.BackColor = Color.LightGray;
                    btn4.BackColor = Color.LightGray;

                    // form 초기화
                    if (tagetForm != null) tagetForm.Dispose();
                    // form 호출
                    tagetForm = draw.getMdiForm(parentForm, new MenuForm(parentForm,menuclick), menu);
                    tagetForm.Show();
                    break;
                case "btn3":
                    menuclick = 3;
                    btn1.BackColor = Color.LightGray;
                    btn2.BackColor = Color.LightGray;
                    btn3.BackColor = Color.White;
                    btn4.BackColor = Color.LightGray;

                    // form 초기화
                    if (tagetForm != null) tagetForm.Dispose();
                    // form 호출
                    tagetForm = draw.getMdiForm(parentForm, new MenuForm(parentForm,menuclick), menu);
                    tagetForm.Show();
                    break;
                case "btn4":
                    menuclick = 4;
                    btn1.BackColor = Color.LightGray;
                    btn2.BackColor = Color.LightGray;
                    btn3.BackColor = Color.LightGray;
                    btn4.BackColor = Color.White;

                    // form 초기화
                    if (tagetForm != null) tagetForm.Dispose();
                    // form 호출
                    tagetForm = draw.getMdiForm(parentForm, new MenuForm(parentForm,menuclick), menu);
                    tagetForm.Show();
                    break;
                default:
                    break;
            }

        }
        
    }
}
