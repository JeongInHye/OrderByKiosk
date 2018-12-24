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
    class PayView
    {
        private WebAPI api;
        private Hashtable hashtable;
        private Form parentForm;
        private Draw draw;
        private ListView listOrderList;
        private Label lblMessage;
        private Button btnMoney, btnCard, btnCancel;

        public PayView(Form parentForm)
        {
            this.parentForm = parentForm;
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("color", Color.White);
            hashtable.Add("size", new Size(800, 300));
            hashtable.Add("point", new Point(0, 20));
            hashtable.Add("name", "주문리스트");
            listOrderList = draw.getListView(hashtable, parentForm);
            listOrderList.Columns.Add("", 0);
            listOrderList.Columns.Add("메뉴", 156, HorizontalAlignment.Center);
            listOrderList.Columns.Add("샷추가", 156, HorizontalAlignment.Center);
            listOrderList.Columns.Add("휘핑", 156, HorizontalAlignment.Center);
            listOrderList.Columns.Add("수량", 156, HorizontalAlignment.Center);
            listOrderList.Columns.Add("가격", 156, HorizontalAlignment.Center);
            listOrderList.ColumnWidthChanging += ListOrderList_ColumnWidthChanging;

            hashtable = new Hashtable();
            hashtable.Add("text", "결제 수단을 선택해 주세요.");
            hashtable.Add("point", new Point(180, 380));
            hashtable.Add("font", new Font("맑은 고딕", 25, FontStyle.Bold));
            hashtable.Add("name", "lblMessage");
            lblMessage = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(190, 100));
            hashtable.Add("point", new Point(130, 470));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("name", "btnCard");
            hashtable.Add("text", "카드결제");
            hashtable.Add("click", (EventHandler)btnCard_click);
            btnCard = draw.getButton1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(190, 100));
            hashtable.Add("point", new Point(450, 470));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("name", "btnMoney");
            hashtable.Add("text", "현금 결제");
            hashtable.Add("click", (EventHandler)btnMoney_click);
            btnMoney = draw.getButton1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 50));
            hashtable.Add("point", new Point(600, 770));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnCancel");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("text", "취소");
            hashtable.Add("click", (EventHandler)btnCancel_click);
            btnCancel = draw.getButton1(hashtable, parentForm);
        }

        private void ListOrderList_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)   // listView 칼럼사이즈 고정
        {
            e.NewWidth = listOrderList.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        private void btnCard_click(object o, EventArgs a)
        {
            MessageBox.Show("orderYn -> Y 로 바꿈");

            //api = new WebAPI();
            //hashtable.Add("oNum", oNum);
            //api.Post(Program.serverUrl + "orderlist/orderYn", hashtable);

            BillForm billForm = new BillForm();
            Point p = new Point((parentForm.Width - billForm.Width) / 2, (parentForm.Height - billForm.Height) / 2);
            billForm.StartPosition = parentForm.StartPosition;
            billForm.ShowDialog();
        }

        private void btnMoney_click(object o, EventArgs a)
        {
            MessageBox.Show("orderYn -> Y 로 바꿈");

            //api = new WebAPI();
            //hashtable.Add("oNum",oNum);
            //api.Post(Program.serverUrl + "orderlist/orderYn", hashtable);

            BillForm billForm = new BillForm();
            Point p = new Point((parentForm.Width - billForm.Width) / 2, (parentForm.Height - billForm.Height) / 2);
            billForm.StartPosition = parentForm.StartPosition;
            billForm.ShowDialog();
        }

        private void btnCancel_click(object o, EventArgs a)
        {
            parentForm.Visible = false;
            UserForm userForm = new UserForm();
            userForm.StartPosition = FormStartPosition.CenterParent;
            userForm.FormClosed += new FormClosedEventHandler(exit_click);
            userForm.Show();
        }

        private void exit_click(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }
    }
}
