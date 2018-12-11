using OBK.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Views.AdminView
{
    class MenuAddView
    {
        private Draw draw;
        private Form parentForm;
        private Label label1, label2, label3, label4, label5, label6;
        private ListView list;
        private Button button;
        private Hashtable hashtable;

        public MenuAddView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {

        }
    }
}
