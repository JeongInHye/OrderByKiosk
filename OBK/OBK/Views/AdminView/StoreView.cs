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
    class StoreView
    {
        private Draw draw;
        private Form parentForm,tagetForm;
        private Button btnStoreAdd, btnStoreDelete, btnMain,btnStoreList;
        private Panel all, contents;
        private Hashtable hashtable;

        public StoreView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("type", "");
            hashtable.Add("size", new Size(900, 600));
            hashtable.Add("point", new Point(0, 0));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "head");
            all = draw.getPanel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 100));
            hashtable.Add("point", new Point(20, 20));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnStoreAdd");
            hashtable.Add("text", "매장\n목록");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnStoreList_Click);
            btnStoreList = draw.getButton1(hashtable, all);
            btnStoreList.BackColor = Color.FromArgb(46, 204, 113);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 100));
            hashtable.Add("point", new Point(20, 140));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnStoreDelete");
            hashtable.Add("text", "메장\n추가");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnStoreAdd_Click);
            btnStoreAdd = draw.getButton1(hashtable, all);


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 100));
            hashtable.Add("point", new Point(20, 260));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnDelete");
            hashtable.Add("text", "매장\n삭제");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnStoreDelete_Click);
            btnStoreDelete = draw.getButton1(hashtable, all);


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 60));
            hashtable.Add("point", new Point(20, 480));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnMain");
            hashtable.Add("text", "메인화면");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnMain_Click);
            btnMain = draw.getButton1(hashtable, all);

            hashtable = new Hashtable();
            hashtable.Add("type", "");
            hashtable.Add("size", new Size(680, 520));
            hashtable.Add("point", new Point(180, 20));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "head");
            contents = draw.getPanel(hashtable, all);
            contents.BorderStyle = BorderStyle.FixedSingle;

            if (tagetForm != null) tagetForm.Dispose();
            tagetForm = draw.getMdiForm(parentForm, new StoreListForm(), contents);
            tagetForm.Show();
        }

        private void btnStoreList_Click(object sender, EventArgs e)
        {
            btnStoreList.BackColor = Color.FromArgb(46, 204, 113);
            btnStoreAdd.BackColor = Color.LightGray;
            btnStoreDelete.BackColor = Color.LightGray;

            if (tagetForm != null) tagetForm.Dispose();

            tagetForm = draw.getMdiForm(parentForm, new StoreListForm(), contents);
            tagetForm.Show();
        }

        private void btnStoreAdd_Click(object sender, EventArgs e)
        {
            btnStoreList.BackColor = Color.LightGray;
            btnStoreAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnStoreDelete.BackColor = Color.LightGray;

            if (tagetForm != null) tagetForm.Dispose();

            tagetForm = draw.getMdiForm(parentForm, new StoreAddForm(), contents);
            tagetForm.Show();
        }

        private void btnStoreDelete_Click(object sender, EventArgs e)
        {
            btnStoreList.BackColor = Color.LightGray;
            btnStoreAdd.BackColor = Color.LightGray;
            btnStoreDelete.BackColor = Color.FromArgb(46, 204, 113);

            if (tagetForm != null) tagetForm.Dispose();

            tagetForm = draw.getMdiForm(parentForm, new StoreDeleteForm(), contents);
            tagetForm.Show();
        }


        private void btnMain_Click(object sender, EventArgs e)
        {
            parentForm.Visible = false;
            tagetForm = new AdminMenuForm();
            tagetForm.StartPosition = parentForm.StartPosition;
            tagetForm.FormClosed += new FormClosedEventHandler(Exit_click);

            tagetForm.Show();
        }

        private void Exit_click(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }
    }
}
