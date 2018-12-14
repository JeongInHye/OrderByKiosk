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
        private Button btnImgAdd, btnAdd;
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
            hashtable.Add("point", new Point(100, 30));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblCategory = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 30));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "comboCategory");
            comboCategory = draw.getComboBox(hashtable, parentForm);
            comboCategory.Items.AddRange(new object[] { "커피", "음료", "티", "디져트" });

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "메뉴명 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 110));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblMenu = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 110));
            hashtable.Add("hinttext", "메뉴명을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "txtMenu");
            txtMenu = draw.getHintTextBox(hashtable, parentForm);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "가격 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 190));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblPrice = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 190));
            hashtable.Add("hinttext", "가격을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "txtPrice");
            txtPrice = draw.getHintTextBox(hashtable, parentForm);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "이미지 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 270));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblImage = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 270));
            hashtable.Add("hinttext", "이미지를 첨부해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "txtImg");
            txtImg = draw.getHintTextBox(hashtable, parentForm);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(100, 360));
            hashtable.Add("text", "핫/아이스");
            hashtable.Add("name", "cboxHot");
            cboxHot = draw.getCheckBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(250, 360));
            hashtable.Add("text", "사이즈");
            hashtable.Add("name", "cboxSize");
            cboxSize = draw.getCheckBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(400, 360));
            hashtable.Add("text", "샷");
            hashtable.Add("name", "cboxShot");
            cboxShot = draw.getCheckBox(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(510, 360));
            hashtable.Add("text", "휘핑");
            hashtable.Add("name", "cboxWhip");
            cboxWhip = draw.getCheckBox(hashtable, parentForm);

            //==============================================================================


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 50));
            hashtable.Add("point", new Point(490, 440));
            hashtable.Add("color", Color.FromArgb(246,246,246));
            hashtable.Add("name", "btnAdd");
            hashtable.Add("text", "메뉴 등록하기");
            hashtable.Add("font", new Font("맑은 고딕", 15, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnAdd_Click);
            btnAdd = draw.getButton1(hashtable, parentForm);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메뉴 추가 완료");
        }
    }
}
