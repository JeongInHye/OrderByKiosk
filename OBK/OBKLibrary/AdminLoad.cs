using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBKLibrary
{
    public static class AdminLoad
    {
        public static bool GetHandler(Form parentForm, string viewName)
        {
            switch (viewName)
            {
                case "adminmenu":
                    parentForm.Size = new Size(600, 700);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "메인화면";
                    return true;
                case "login":
                    parentForm.Size = new Size(400, 500);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "메뉴추가화면";
                    parentForm.BackColor = Color.White;
                    return true;
                case "income":
                    parentForm.Size = new Size(900, 600);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "매출메인화면";
                    return true;
                case "menuadd":
                    parentForm.Size = new Size(680, 520);
                    parentForm.IsMdiContainer = false;
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.BackColor = Color.White;
                    return true;
                case "menudelete":
                    parentForm.Size = new Size(680, 520);
                    parentForm.BackColor = Color.White;
                    parentForm.IsMdiContainer = false;
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    return true;
                case "menuedit":
                    parentForm.Size = new Size(680, 520);
                    parentForm.IsMdiContainer = false;
                    parentForm.BackColor = Color.White;
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    return true;
                case "menuincome":
                    parentForm.Size = new Size(680, 520);
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "메뉴별매출화면";
                    parentForm.BackColor = Color.White;
                    return true;
                case "menusetting":
                    parentForm.Size = new Size(900, 600);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    return true;
                case "monthly":
                    parentForm.Size = new Size(680, 520);
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "월별매출화면";
                    parentForm.BackColor = Color.White;
                    return true;
                case "soldoutlist":
                    parentForm.Size = new Size(900, 600);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.BackColor = Color.White;
                    parentForm.Text = "품절목록메인화면";
                    return true;
                default:
                    return false;
            }
        }

    }
}
