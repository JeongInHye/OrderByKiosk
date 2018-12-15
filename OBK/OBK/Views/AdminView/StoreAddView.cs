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
    class StoreAddView
    {
        private Draw draw;
        private Form parentForm;
        private Label lb_name, lb_city, lb_gu;
        private TextBox tb_name, tb_city, tb_gu;
        private Button btn_add;
        private Hashtable hashtable;

        public StoreAddView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("text", "매장명 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 110));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "lb_name");
            lb_name = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 110));
            hashtable.Add("hinttext", "매장명을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "tb_name");
            tb_name = draw.getHintTextBox(hashtable, parentForm);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "도시명 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 190));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "lb_city");
            lb_city = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 190));
            hashtable.Add("hinttext", "도시명을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "tb_city");
            tb_city = draw.getHintTextBox(hashtable, parentForm);

            //==============================================================================

            hashtable = new Hashtable();
            hashtable.Add("text", "구 : ");
            hashtable.Add("width", 110);
            hashtable.Add("point", new Point(100, 270));
            hashtable.Add("font", new Font("고딕", 18, FontStyle.Bold));
            hashtable.Add("name", "lb_gu");
            lb_gu = draw.getLabel1(hashtable, parentForm);

            hashtable = new Hashtable();
            hashtable.Add("width", 300);
            hashtable.Add("point", new Point(230, 270));
            hashtable.Add("hinttext", "구이름을 입력해주세요.");
            hashtable.Add("font", new Font("맑은고딕", 14, FontStyle.Bold));
            hashtable.Add("name", "tb_gu");
            tb_gu = draw.getHintTextBox(hashtable, parentForm);

            //==========================================================

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 50));
            hashtable.Add("point", new Point(490, 440));
            hashtable.Add("color", Color.FromArgb(246, 246, 246));
            hashtable.Add("name", "btn_add");
            hashtable.Add("text", "매장 등록");
            hashtable.Add("font", new Font("맑은 고딕", 15, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btn_add_Click);
            btn_add = draw.getButton1(hashtable, parentForm);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tb_name.Text+"지점 등록!!\n위치 : "+tb_city.Text+" "+tb_gu.Text);
        }
    }
}
