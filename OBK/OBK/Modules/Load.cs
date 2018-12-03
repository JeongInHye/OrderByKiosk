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
                default:
                    return null;
            }
        }

        
        private void GetMainLoad(object o, EventArgs a)
        {
            parentForm.IsMdiContainer = true;
            parentForm.Size = new Size(1000, 800);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "메인화면";
            new MainView(parentForm);
        }
        private void GetBillLoad(object sender, EventArgs e)
        {
            parentForm.Size = new Size(500, 400);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "영수증";
            new BillView(parentForm);
        }

    }
}
