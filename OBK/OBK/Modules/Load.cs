using OBK.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Modules
{
    class Load
    {
        private Form parentForm;
        private object oDB;

        public Load(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        public Load(Form parentForm, object oDB)
        {
            this.parentForm = parentForm;
            this.oDB = oDB;
        }

        public EventHandler GetHandler(string viewName)
        {
            switch (viewName)
            {
                case "main":
                    return GetMainLoad;
                case "bill":
                    return GetBillLoad;
                case "choice":
                    return GetChoiceLoad;
                case "menu":
                    return GetMenuLoad;
                case "pay":
                    return GetPayLoad;
                case "user":
                    return GetUserLoad;

                default:
                    return null;
            }
        }

        
        private void GetMainLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(500, 400);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메인화면";
            new MainView(parentForm);
        }
        private void GetBillLoad(object sender, EventArgs e)    // 영수증
        {
            parentForm.Size = new Size(500, 500);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            new BillView(parentForm);
        }
        private void GetChoiceLoad(object o, EventArgs a)
        {
            parentForm.IsMdiContainer = true;
            parentForm.Size = new Size(800, 600);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "선택화면";
            new MainView(parentForm);
        }
        private void GetMenuLoad(object o, EventArgs a)
        {
            parentForm.IsMdiContainer = true;
            parentForm.Size = new Size(1000, 800);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메뉴";
            new MainView(parentForm);
        }
        private void GetPayLoad(object o, EventArgs a)      // 결제
        {
            parentForm.IsMdiContainer = false;
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            new PayView(parentForm);
        }
        private void GetUserLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "사용자화면";
            new UserView(parentForm);
        }

    }
}
