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
using static System.Windows.Forms.Control;

namespace OBK.Views
{
    class MenuView
    {
        private Form parentForm,targetForm;
        private Draw draw;
        private Hashtable hashtable;
        private int cNo;
        private WebAPI api;

        public MenuView(Form parentForm,Form targetForm, int cNo)
        {
            this.parentForm = parentForm;
            this.targetForm = targetForm;
            this.cNo = cNo;
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            targetForm.BackColor = Color.WhiteSmoke;
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
            if (!api.MenuPrint("http://192.168.3.17:5000/menu/select", ht, hashtable, hashtable2, targetForm))
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
            string mName = name.Substring(name.IndexOf("_")+1);
            //MessageBox.Show(mName);
            
            ChoiceForm choiceForm = new ChoiceForm(mName);
            choiceForm.StartPosition = FormStartPosition.CenterParent;
            choiceForm.FormClosed += choiceForm_FormClosed;
            choiceForm.ShowDialog();
        }

        private void choiceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Choice 선택폼이 닫히게 되면 기존의 UserForm을 업데이트해주기 위한 이벤트
            
        }
    }
}
