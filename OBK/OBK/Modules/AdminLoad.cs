﻿using OBK.Views;
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
                case "storeadd":
                    return GetStoreAddLoad;
                case "storedelete":
                    return GetStoreDeleteLoad;
                case "store":
                    return GetStoreLoad;
                default:
                    return null;
            }
        }

        private void GetAdminMenuLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(500, 400);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메인화면";
            new AdminMenuView(parentForm);
        }
        private void GetLoginLoad(object sender, EventArgs e)    // 영수증
        {
            parentForm.Size = new Size(500, 500);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            new LoginView(parentForm);
        }
        private void GetMenuAddLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(450, 550);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메뉴추가화면";
            parentForm.BackColor = Color.White;
            new MenuAddView(parentForm);
        }
        private void GetMenuDeleteLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(1000, 300);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.AutoScroll = true;
            parentForm.Text = "메뉴";
            new MenuDeleteView(parentForm);
        }
        private void GetMenuEditLoad(object o, EventArgs a)      // 결제
        {
            parentForm.IsMdiContainer = false;
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            new MenuEditView(parentForm);
        }
        private void GetMenuIncomeLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메뉴별매출화면";
            new MenuIncomView(parentForm);
        }
        
        private void GetMenuSettingLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메뉴설정메인화면";
            new MenuSettingView(parentForm);
        }

        private void GetMonthlyLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "월별매출화면";
            new MonthlyView(parentForm);
        }

        private void GetSoldoutListLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "품절목록메인화면";
            new SoldoutListView(parentForm);
        }

        private void GetStoreAddLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "매장추가화면";
            new StoreAddView(parentForm);
        }

        private void GetStoreDeleteLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "매장삭제화면";
            new StoreDeleteView(parentForm);
        }

        private void GetStoreLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "매장관리메인화면";
            new StoreView(parentForm);
        }
    }
}
