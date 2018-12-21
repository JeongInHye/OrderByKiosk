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
            ListViewItem listViewItem = new ListViewItem();
            listViewItem.UseItemStyleForSubItems = false;
            listViewItem.Text = "Test";
            listViewItem.SubItems.Add("아메리카노");
            listViewItem.SubItems[1].Font = new Font("새굴림", 13, FontStyle.Regular);
            listOrderList.Items.Add(listViewItem);
            listOrderList.ColumnWidthChanging += ListOrderList_ColumnWidthChanging;
            SetHeight(listOrderList, 30);

            hashtable = new Hashtable();
            hashtable.Add("text", "결제 수단을 선택해 주세요.");
            hashtable.Add("point", new Point(240, 450));
            hashtable.Add("font", new Font("맑은 고딕", 20, FontStyle.Bold));
            hashtable.Add("name", "lblMessage");
            lblMessage = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 100));
            hashtable.Add("point", new Point(120, 700));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("font", new Font("새굴림", 14, FontStyle.Bold));
            hashtable.Add("name", "btnCard");
            hashtable.Add("text", "카드결제");
            hashtable.Add("click", (EventHandler)btnCard_click);
            btnCard = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 100));
            hashtable.Add("point", new Point(420, 500));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("font", new Font("새굴림", 14, FontStyle.Bold));
            hashtable.Add("name", "btnMoney");
            hashtable.Add("text", "현금결제");
            hashtable.Add("click", (EventHandler)btnMoney_click);
            btnMoney = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 50));
            hashtable.Add("point", new Point(500, 600));
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

        private void SetHeight(ListView listName, int height) // listView 높이 지정
        {
            ImageList imgList = new ImageList();
            imgList.ImageSize = new Size(1, height);
            listName.SmallImageList = imgList;
        }

        private void btnCard_click(object o, EventArgs a)
        {
            BillForm bf = new BillForm();
            Point p = new Point((parentForm.Width - bf.Width) / 2, (parentForm.Height - bf.Height) / 2);
            bf.StartPosition = parentForm.StartPosition;
            bf.ShowDialog();
        }

        private void btnMoney_click(object o, EventArgs a)
        {
            BillForm bf = new BillForm();
            Point p = new Point((parentForm.Width - bf.Width) / 2, (parentForm.Height - bf.Height) / 2);
            bf.StartPosition = parentForm.StartPosition;
            bf.ShowDialog();
        }

        private void btnCancel_click(object o, EventArgs a)
        {
            parentForm.Close();
        }
    }
}
