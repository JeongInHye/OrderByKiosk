using OBKLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Forms
{
    public partial class MenuForm : Form
    {
        private Form parentForm, targetForm;
        private UserForm uv;
        private Draw draw;
        private Hashtable hashtable;
        private int cNo;
        private WebAPI api;

        public MenuForm(Form parentForm, int mNo, UserForm uv)
        {
            InitializeComponent();
            parentForm = this;

            Load += MenuForm_Load;
        }

        public MenuForm(Form parentForm, Form targetForm, int cNo, UserForm uv)
        {
            InitializeComponent();

            parentForm = this;
            this.targetForm = targetForm;
            this.cNo = cNo;
            this.uv = uv;

            Load += MenuForm_Load;
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            if (UserLoad.GetHandler(this, "menu"))
            {
                getView();
            }
        }

        private void getView()
        {
            api = new WebAPI();
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(170, 170));
            hashtable.Add("color", Color.BurlyWood);
            hashtable.Add("click", (EventHandler)menu_click);
            hashtable.Add("font", new Font("굴림", 12, FontStyle.Bold));
            Hashtable ht = new Hashtable();
            ht.Add("cNo", cNo);
            Hashtable hashtable2 = new Hashtable();
            hashtable2.Add("click", (EventHandler)menu_click);
            targetForm.Controls.Clear();
            if (!api.MenuPrint(Program.serverUrl + "menu/select", ht, hashtable, hashtable2, targetForm))
            {
                MessageBox.Show("메뉴 불러오기 실패...");
            }
        }
        private void menu_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Menuclick(button.Name);
        }

        private void Menuclick(string name)
        {
            string mName = name.Substring(name.IndexOf("_") + 1);

            ChoiceForm choiceForm = new ChoiceForm(mName);
            choiceForm.StartPosition = FormStartPosition.Manual;
            choiceForm.Location = new Point(parentForm.Location.X + (parentForm.Width / 2) - (choiceForm.Width / 4), parentForm.Location.Y + (parentForm.Height / 2) - (choiceForm.Height / 2));
            choiceForm.ShowDialog();
            uv.tt();
        }


    }
}
