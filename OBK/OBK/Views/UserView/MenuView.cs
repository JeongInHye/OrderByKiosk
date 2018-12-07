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
                    for(int i = 0; i < 4; i++)
                    {
                        for(int j = 0; j < 20; j++)
                        {
                            hashtable = new Hashtable();
                            hashtable.Add("type", "");
                            hashtable.Add("size", new Size(170, 140));
                            hashtable.Add("point", new Point(20+190*i, 20+160*j));
                            hashtable.Add("color", Color.BurlyWood);
                            hashtable.Add("name", "i"+i+"j"+j);
                            hashtable.Add("click",(EventHandler)menu_click);
                            panel = draw.getPanel(hashtable, parentForm);
                        }
                    }
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
        }

        private void menu_click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            MessageBox.Show(panel.Name);
        }
    }
}
