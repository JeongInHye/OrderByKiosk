using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Modules
{
    class Draw
    {
        public Form getMdiForm(Form parentForm, Form tagetForm, Control parentDomain)
        {
            parentForm.IsMdiContainer = true;
            tagetForm.MdiParent = parentForm;
            tagetForm.WindowState = FormWindowState.Maximized;
            tagetForm.FormBorderStyle = FormBorderStyle.None;
            tagetForm.Dock = DockStyle.Fill;
            parentDomain.Controls.Add(tagetForm);
            return tagetForm;
        }

        public Panel getPanel(Hashtable hashtable, Control parentDomain)
        {
            Panel panel = new Panel();
            panel.Size = (Size)hashtable["size"];
            panel.Location = (Point)hashtable["point"];
            panel.BackColor = (Color)hashtable["color"];
            panel.Name = hashtable["name"].ToString();
            panel.Click += (EventHandler)hashtable["click"];
            //panel.AutoScroll = true;
            parentDomain.Controls.Add(panel);
            return panel;
        }

        public Label getLabel(Hashtable hashtable, Control parentDomain)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Location = (Point)hashtable["point"];
            label.Name = hashtable["name"].ToString();
            label.Text = hashtable["text"].ToString();
            label.Font = (Font)hashtable["font"];
            parentDomain.Controls.Add(label);
            return label;
        }

        public Label getLabel1(Hashtable hashtable, Control parentDomain)
        {
            Label label = new Label();
            label.Width = (int)hashtable["width"];
            label.TextAlign = ContentAlignment.MiddleRight;
            label.Location = (Point)hashtable["point"];
            label.Name = hashtable["name"].ToString();
            label.Text = hashtable["text"].ToString();
            label.Font = (Font)hashtable["font"];
            parentDomain.Controls.Add(label);
            return label;
        }

        public Button getButton(Hashtable hashtable, Control parentDomain)
        {
            Button button = new Button();
            button.Size = (Size)hashtable["size"];
            button.Location = (Point)hashtable["point"];
            button.BackColor = (Color)hashtable["color"];
            button.Name = hashtable["name"].ToString();
            button.Text = hashtable["text"].ToString();
            button.Click += (EventHandler)hashtable["click"];
            button.Cursor = Cursors.Hand;
            parentDomain.Controls.Add(button);
            return button;
        }

        public Button getButton1(Hashtable hashtable, Control parentDomain)
        {
            Button button = new Button();
            button.Size = (Size)hashtable["size"];
            button.Location = (Point)hashtable["point"];
            button.BackColor = (Color)hashtable["color"];
            button.Name = hashtable["name"].ToString();
            button.Text = hashtable["text"].ToString();
            button.Font = (Font)hashtable["font"];
            button.Click += (EventHandler)hashtable["click"];
            button.Cursor = Cursors.Hand;
            parentDomain.Controls.Add(button);
            return button;
        }

        public TextBox getTextBox(Hashtable hashtable, Control parentDomain)
        {
            TextBox textBox = new TextBox();
            textBox.Width = Convert.ToInt32(hashtable["width"].ToString());
            textBox.Location = (Point)hashtable["point"];
            textBox.BackColor = (Color)hashtable["color"];
            textBox.Name = hashtable["name"].ToString();
            textBox.Enabled = (bool)hashtable["enabled"];
            parentDomain.Controls.Add(textBox);
            return textBox;
        }

        public ComboBox getComboBox(Hashtable hashtable, Control parentDomain)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Width = Convert.ToInt32(hashtable["width"].ToString());
            comboBox.DropDownWidth = Convert.ToInt32(hashtable["width"].ToString());
            comboBox.Location = (Point)hashtable["point"];
            comboBox.BackColor = (Color)hashtable["color"];
            comboBox.Font = (Font)hashtable["font"];
            comboBox.Name = hashtable["name"].ToString();
            comboBox.DisplayMember = "value";
            comboBox.ValueMember = "Key";
            parentDomain.Controls.Add(comboBox);
            return comboBox;
        }

        public ListView getListView(Hashtable hashtable, Control parentDomain)
        {
            ListView listView = new ListView();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.Location = (Point)hashtable["point"];
            listView.Size = (Size)hashtable["size"];
            listView.BackColor = (Color)hashtable["color"];
            listView.Name = hashtable["name"].ToString();
            listView.CheckBoxes = true;
            listView.MouseClick += (MouseEventHandler)hashtable["click"];
            parentDomain.Controls.Add(listView);
            return listView;
        }

        public ListView getListView1(Hashtable hashtable, Control parentDomain)
        {
            ListView listView = new ListView();
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.Location = (Point)hashtable["point"];
            listView.Size = (Size)hashtable["size"];
            listView.BackColor = (Color)hashtable["color"];
            listView.Name = hashtable["name"].ToString();
            listView.MouseClick += (MouseEventHandler)hashtable["click"];
            parentDomain.Controls.Add(listView);
            return listView;
        }

        public CheckBox getCheckBox(Hashtable hashtable, Control parentDomain)
        {
            CheckBox checkBox = new CheckBox();
            checkBox.AutoSize = true;
            checkBox.Location = (Point)hashtable["point"];
            checkBox.Name = hashtable["name"].ToString();
            parentDomain.Controls.Add(checkBox);
            //checkBox.TabIndex = 
            return checkBox;
        }

        public PictureBox getPictureBox(Hashtable hashtable,Control parentDomain)
        {
            PictureBox pictureBox = new PictureBox();
            //pictureBox.Image = ()
            pictureBox.Location = (Point)hashtable["point"];
            pictureBox.Size = (Size)hashtable["size"];
            pictureBox.BackColor = (Color)hashtable["color"];
            parentDomain.Controls.Add(pictureBox);
            return pictureBox;
        }
    }
}
