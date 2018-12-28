using OBK.Views;
using OBK.Views.AdminView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Modules
{
    class AdminLoad
    {
        private Form parentForm;
        private object oDB;

        public AdminLoad(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        public AdminLoad(Form parentForm, object oDB)
        {
            this.parentForm = parentForm;
            this.oDB = oDB;
        }

        public EventHandler GetHandler(string viewName)
        {
            switch (viewName)
            {
                case "adminmenu":
                    return GetAdminMenuLoad;
                case "login":
                    return GetLoginLoad;
                case "income":
                    return GetIncomeLoad;
                case "menuadd":
                    return GetMenuAddLoad;
                case "menudelete":
                    return GetMenuDeleteLoad;
                case "menuedit":
                    return GetMenuEditLoad;
                case "menuincome":
                    return GetMenuIncomeLoad;
                case "menusetting":
                    return GetMenuSettingLoad;
                case "monthly":
                    return GetMonthlyLoad;
                case "soldoutlist":
                    return GetSoldoutListLoad;
                default:
                    return null;
            }
        }
        private void GetLoginLoad(object sender, EventArgs e)    // LoginForm(로그인)
        {
            parentForm.Size = new Size(400, 500);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메뉴추가화면";
            parentForm.BackColor = Color.White;
            new LoginView(parentForm);
        }

        private void GetAdminMenuLoad(object o, EventArgs a)    // AdminMenuForm(관리자메뉴)
        {
            parentForm.Size = new Size(600, 700);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메인화면";
            new AdminMenuView(parentForm);
        }

        private void GetIncomeLoad(object sender, EventArgs e)  // IncomeForm(매출현황)
        {
            parentForm.Size = new Size(900, 600);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "매출메인화면";
            new IncomeView(parentForm);
        }

        private void GetMonthlyLoad(object o, EventArgs a)      // MonthlyForm(월별매출)
        {
            parentForm.Size = new Size(680, 520);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "월별매출화면";
            parentForm.BackColor = Color.White;
            new MonthlyView(parentForm);
        }

        private void GetMenuIncomeLoad(object o, EventArgs a)   // MenuIncomeForm(메뉴별매출)
        {
            parentForm.Size = new Size(680, 520);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메뉴별매출화면";
            parentForm.BackColor = Color.White;
            new MenuIncomView(parentForm);
        }

        private void GetMenuSettingLoad(object o, EventArgs a)  // MenuSettingForm(메뉴관리)
        {
            parentForm.Size = new Size(900, 600);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            new MenuSettingView(parentForm);
        }

        private void GetMenuAddLoad(object o, EventArgs a)      // MenuAddForm(메뉴추가)
        {
            parentForm.Size = new Size(680, 520);
            parentForm.IsMdiContainer = false;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.BackColor = Color.White;
            new MenuAddView(parentForm);
        }

        private void GetMenuEditLoad(object o, EventArgs a)     // MenuEditForm(메뉴수정)
        {
            parentForm.Size = new Size(680, 520);
            parentForm.IsMdiContainer = false;
            parentForm.BackColor = Color.White;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            new MenuEditView(parentForm);
        }

        private void GetMenuDeleteLoad(object o, EventArgs a)   // MenuDeleteForm(메뉴삭제)
        {
            parentForm.Size = new Size(680, 520);
            parentForm.BackColor = Color.White;
            parentForm.IsMdiContainer = false;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            new MenuDeleteView(parentForm);
        }

        private void GetSoldoutListLoad(object o, EventArgs a)  // SoldoutListForm(품절목록)
        {
            parentForm.Size = new Size(900, 600);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.BackColor = Color.White;
            parentForm.Text = "품절목록메인화면";
            new SoldoutListView(parentForm);
        }
    }
}
