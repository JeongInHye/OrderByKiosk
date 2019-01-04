using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBKLibrary
{
    public static class StaffLoad
    {
        public static bool GetHandler(Form parentForm,string viewName)
        {
            switch (viewName)
            {
                case "staff":
                    parentForm.Size = new Size(700, 480);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "직원용";
                    return true;
                case "OrderList":
                    parentForm.Size = new Size(684, 341);
                    parentForm.BackColor = Color.White;
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    return true;
                case "SoldoutAdd":
                    parentForm.Size = new Size(684, 341);
                    parentForm.BackColor = Color.White;
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    return true;
                case "SoldoutDelete":
                    parentForm.Size = new Size(684, 341);
                    parentForm.BackColor = Color.White;
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    return true;
                default:
                    return false;
            }
        }
    }
}
