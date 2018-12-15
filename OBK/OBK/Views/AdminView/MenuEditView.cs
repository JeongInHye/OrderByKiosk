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
    class MenuEditView
    {
        private Draw draw;
        private Form parentForm;
        private Label lblCategory, lblMenu, lblPrice, lblImage;
        private CheckBox cboxHot, cboxSize, cboxShot, cboxWhip;
        private ComboBox comboCategory;
        private TextBox txtMenu, txtPrice, txtImg;
        private ListView listCategory, listMenu;
        private Panel panelOne, panelTwo;
        private Button btnEdit, btnImgAdd, btnEditOk;
        private Hashtable hashtable;

        public MenuEditView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("size", new Size(680, 520));
            hashtable.Add("point", new Point(0, 0));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "panelOne");
            panelOne = draw.getPanel(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(150, 400));
            hashtable.Add("point", new Point(20, 30));
            hashtable.Add("name", "listCategory");
            hashtable.Add("click", (MouseEventHandler)listCategory_click);
            listCategory = draw.getListView1(hashtable, panelOne);
            listCategory.Columns.Add("", 0, HorizontalAlignment.Center);
            listCategory.Columns.Add("카테고리", 146, HorizontalAlignment.Center);
            listCategory.Items.Add(new ListViewItem(new string[] { "", "커피" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "음료" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "티" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "디져트" }));

            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(490, 400));
            hashtable.Add("point", new Point(170, 30));
            hashtable.Add("name", "listMenu");
            listMenu = draw.getListView(hashtable, panelOne);
            listMenu.Columns.Add("", 50, HorizontalAlignment.Center);
            listMenu.Columns.Add("메뉴", 430, HorizontalAlignment.Center);
            listMenu.Items.Add(new ListViewItem(new string[] { " ", "아메리카노" }));


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 50));
            hashtable.Add("point", new Point(490, 440));
            hashtable.Add("color", Color.FromArgb(246, 246, 246));
            hashtable.Add("name", "btnEdit");
            hashtable.Add("text", "선택 수정");
            hashtable.Add("font", new Font("맑은 고딕", 15, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnEdit_click);
            btnEdit = draw.getButton1(hashtable, panelOne);

            //======================================================================

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(680, 520));
            hashtable.Add("point", new Point(0, 0));
            hashtable.Add("color", Color.White);
            hashtable.Add("name", "panelTwo");
            panelTwo = draw.getPanel(hashtable,parentForm);


            hashtable = new Hashtable();
            hashtable.Add("text", "카테고리 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 30));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblCategory = draw.getLabel1(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 30));
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "comboCategory");
            comboCategory = draw.getComboBox(hashtable, panelTwo);
            comboCategory.Items.AddRange(new object[] { "커피", "음료", "티", "디져트" });

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "메뉴명 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 110));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblMenu = draw.getLabel1(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 110));
            hashtable.Add("hinttext", "메뉴명을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "txtMenu");
            txtMenu = draw.getHintTextBox(hashtable, panelTwo);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "가격 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 190));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblPrice = draw.getLabel1(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 190));
            hashtable.Add("hinttext", "가격을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "txtPrice");
            txtPrice = draw.getHintTextBox(hashtable, panelTwo);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "이미지 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 270));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "주문번호");
            lblImage = draw.getLabel1(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 270));
            hashtable.Add("hinttext", "이미지를 첨부해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "txtImg");
            txtImg = draw.getHintTextBox(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(50, 50));
            hashtable.Add("point", new Point(550, 260));
            hashtable.Add("color", Color.FromArgb(246, 246, 246));
            hashtable.Add("name", "btnAdd");
            hashtable.Add("text", "이미지첨부");
            hashtable.Add("font", new Font("맑은 고딕", 10, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnImgAdd_Click);
            btnImgAdd = draw.getButton1(hashtable, panelTwo);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(100, 360));
            hashtable.Add("text", "핫/아이스");
            hashtable.Add("name", "cboxHot");
            cboxHot = draw.getCheckBox(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(250, 360));
            hashtable.Add("text", "사이즈");
            hashtable.Add("name", "cboxSize");
            cboxSize = draw.getCheckBox(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(400, 360));
            hashtable.Add("text", "샷");
            hashtable.Add("name", "cboxShot");
            cboxShot = draw.getCheckBox(hashtable, panelTwo);

            hashtable = new Hashtable();
            hashtable.Add("point", new Point(510, 360));
            hashtable.Add("text", "휘핑");
            hashtable.Add("name", "cboxWhip");
            cboxWhip = draw.getCheckBox(hashtable, panelTwo);

            //==============================================================================


            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 50));
            hashtable.Add("point", new Point(490, 440));
            hashtable.Add("color", Color.FromArgb(246, 246, 246));
            hashtable.Add("name", "btnEditOk");
            hashtable.Add("text", "수정");
            hashtable.Add("font", new Font("맑은 고딕", 15, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnEditOk_Click);
            btnEditOk = draw.getButton1(hashtable, panelTwo);
        }

        private void btnImgAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이미지추가");
        }

        private void btnEditOk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("수정 완료");
        }

        private void listCategory_click(object sender, MouseEventArgs e)
        {
            MessageBox.Show("리스트클릭");
        }

        private void btnEdit_click(object sender, EventArgs e)
        {
            panelOne.Visible = false;
            panelTwo.Show();
        }
    }
}
