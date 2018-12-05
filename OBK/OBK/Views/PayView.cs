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
        private ListView list;
        private Label label1, label2, label3, label4;
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
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("size", new Size(800, 200));
            hashtable.Add("point", new Point(0, 0));
            hashtable.Add("name", "주문리스트");
            list = draw.getListView(hashtable, parentForm);
            list.Columns.Add("", 0);
            list.Columns.Add("메뉴", 156, HorizontalAlignment.Center);
            list.Columns.Add("샷추가", 156, HorizontalAlignment.Center);
            list.Columns.Add("휘핑", 156, HorizontalAlignment.Center);
            list.Columns.Add("수량", 156, HorizontalAlignment.Center);
            list.Columns.Add("가격", 156, HorizontalAlignment.Center);

            hashtable = new Hashtable();
            hashtable.Add("text", "---------------------------------------------");
            hashtable.Add("point", new Point(50, 400));
            hashtable.Add("name", "선");
            label2 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "결제 수단");
            hashtable.Add("point", new Point(360, 400));
            hashtable.Add("name", "선");
            label3 = draw.getLabel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "---------------------------------------------");
            hashtable.Add("point", new Point(400, 400));
            hashtable.Add("name", "선");
            label4 = draw.getLabel(hashtable, parentForm);


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 100));
            hashtable.Add("point", new Point(120, 450));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnCard");
            hashtable.Add("text", "카드결제");
            hashtable.Add("click", (EventHandler)btnCard_click);
            btnCard = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 100));
            hashtable.Add("point", new Point(420, 450));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnMoney");
            hashtable.Add("text", "현금결제");
            hashtable.Add("click", (EventHandler)btnMoney_click);
            btnMoney = draw.getButton(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(200, 100));
            hashtable.Add("point", new Point(500, 600));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnCancel");
            hashtable.Add("text", "취소");
            hashtable.Add("click", (EventHandler)btnCancel_click);
            btnCancel = draw.getButton(hashtable, parentForm);
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
