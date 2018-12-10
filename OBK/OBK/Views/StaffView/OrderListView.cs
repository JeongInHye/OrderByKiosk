using OBK.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Views.StaffView
{
    class OrderListView
    {
        private Draw draw;
        private Form parentForm, tagetForm;
        private Hashtable hashtable;


        public OrderListView(Form parentForm)
        {
            this.parentForm = parentForm;
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            
        }
    }
}
