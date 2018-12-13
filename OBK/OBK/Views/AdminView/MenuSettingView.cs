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
    class MenuSettingView
    {
        private Hashtable hashtable;
        private Draw draw;
        private Form parentForm, tagetForm;
        private Button btnAdd, btnEdit, btnDelete,btnMain;
        private Panel contents;

        public MenuSettingView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 100));
            hashtable.Add("point", new Point(20, 20));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnAdd");
            hashtable.Add("text", "메뉴추가");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnAdd_Click);
            btnAdd = draw.getButton1(hashtable, parentForm);
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 100));
            hashtable.Add("point", new Point(20, 140));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnEdit");
            hashtable.Add("text", "메뉴수정");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnAdd_Click);
            btnEdit = draw.getButton1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 100));
            hashtable.Add("point", new Point(20, 260));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnDelete");
            hashtable.Add("text", "메뉴삭제");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnAdd_Click);
            btnDelete = draw.getButton1(hashtable, parentForm);


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(140, 60));
            hashtable.Add("point", new Point(20, 480));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "btnMain");
            hashtable.Add("text", "메인화면");
            hashtable.Add("font", new Font("맑은 고딕", 14, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnMain_Click);
            btnMain = draw.getButton1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("type", "");
            hashtable.Add("size", new Size(680, 520));
            hashtable.Add("point", new Point(180, 20));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "head");
            contents = draw.getPanel(hashtable, parentForm);
            contents.BorderStyle = BorderStyle.FixedSingle;


        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            btnAdd.BackColor = Color.LightGray;
            btnAdd.BackColor = Color.LightGray;

            if (tagetForm != null) tagetForm.Dispose();

            tagetForm = draw.getMdiForm(parentForm, new MenuAddForm(), contents);
            tagetForm.Show();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {

        }
    }
}
