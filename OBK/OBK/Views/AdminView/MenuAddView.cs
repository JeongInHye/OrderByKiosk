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
    class MenuAddView
    {
        private Draw draw;
        private Form parentForm;
        private Label lblCategory, lblMenu, lblPrice, lblImage;
        private CheckBox cboxHot, cboxSize, cboxShot, cboxWhip;
        private ComboBox comboCategory;
        private TextBox txtMenu, txtPrice, txtImg;
        private Button btnAdd;
        private Hashtable hashtable;

        public MenuAddView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("text", "카테고리 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(20, 20));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblCategory = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(150, 20));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "comboCategory");
            comboCategory = draw.getComboBox(hashtable, parentForm);
            comboCategory.Items.AddRange(new object[] { "커피", "음료", "티","디져트" });

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "메뉴명 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(20, 100));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblMenu = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(150, 108));
            hashtable.Add("name", "comboCategory");
            txtMenu = draw.getTextBox(hashtable, parentForm);
            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "가격 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(20, 180));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblPrice = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("text", "이미지 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(20, 260));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblImage = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(50, 340));
            hashtable.Add("text", "핫/아이스");
            hashtable.Add("name", "cboxHot");
            cboxHot = draw.getCheckBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(200, 340));
            hashtable.Add("text", "사이즈");
            hashtable.Add("name", "cboxSize");
            cboxSize = draw.getCheckBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(350, 340));
            hashtable.Add("text", "샷");
            hashtable.Add("name", "cboxShot");
            cboxShot = draw.getCheckBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(480, 340));
            hashtable.Add("text", "휘핑");
            hashtable.Add("name", "cboxWhip");
            cboxWhip = draw.getCheckBox(hashtable, parentForm);
        }
    }
}
