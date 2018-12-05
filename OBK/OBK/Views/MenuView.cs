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
    class MenuView
    {
        private Form parentForm;
        private Draw draw;
        private Hashtable hashtable;
        private int mNo;
        private Panel panel;
        public MenuView(Form parentForm,int mNo)
        {
            this.parentForm = parentForm;
            this.mNo = mNo;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            switch (mNo)
            {
                case 1:
                    hashtable = new Hashtable();
                    hashtable.Add("type", "");
                    hashtable.Add("size", new Size(100, 50));
                    hashtable.Add("point", new Point(10, 10));
                    hashtable.Add("color", Color.Black);
                    hashtable.Add("name", "head");
                    panel = draw.getPanel(hashtable, parentForm);
                    break;
                case 2:
                    parentForm.BackColor = Color.AliceBlue;
                    break;
                case 3:
                    parentForm.BackColor = Color.AntiqueWhite;
                    break;
                case 4:
                    parentForm.BackColor = Color.Aqua;
                    break;

            }
            //hashtable = new Hashtable();
            //hashtable.Add("type", "");
            //hashtable.Add("size", new Size(100, 50));
            //hashtable.Add("point", new Point(10, 10));
            //hashtable.Add("color", Color.Black);
            //hashtable.Add("name", "head");
            //panel = draw.getPanel(hashtable, parentForm);
        }
    }
}
