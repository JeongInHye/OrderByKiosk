using OBK.Views.StaffView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Modules
{
    class StaffLoad
    {
        private Form parentForm;

        public StaffLoad(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        public EventHandler GetHandler(string viewName)
        {
            switch (viewName)
            {
                case "staff":
                    return GetStaffLoad;
                case "OrderList":
                    return GetOrderListLoad;
                case "SoldoutAdd":
                    return GetSoldoutAddLoad;
                case "SoldoutDelete":
                    return GetSoldoutDelete;
                default:
                    return null;
            }
        }

        private void GetStaffLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(700, 480);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "직원용";
            new StaffView(parentForm);
        }

        private void GetOrderListLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(684, 341);
            parentForm.BackColor = Color.White;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            new OrderListView(parentForm);
        }

        private void GetSoldoutAddLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(684, 341);
            parentForm.BackColor = Color.White;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            new SoldoutAddView(parentForm);
        }

        private void GetSoldoutDelete(object o, EventArgs a)
        {
            parentForm.Size = new Size(684, 341);
            parentForm.BackColor = Color.White;
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            new SoldoutDeleteView(parentForm);
        }

    }
}
