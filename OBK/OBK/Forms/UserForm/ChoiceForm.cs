using OBK.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Forms
{
    public partial class ChoiceForm : Form
    {
        public ChoiceForm()
        {
            InitializeComponent();
            Load load = new Load(this);
            Load += load.GetHandler("choice");
        }

        public ChoiceForm(string mName)
        {
            InitializeComponent();
            Load load = new Load(this, mName);
            Load += load.GetHandler("choice");
        }
    }
}
