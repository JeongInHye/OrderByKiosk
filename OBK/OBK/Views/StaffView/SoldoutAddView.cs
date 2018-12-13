﻿using OBK.Modules;
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
    class SoldoutAddView
    {
        private Draw draw;
        private Form parentForm;
        private Hashtable hashtable;
        private ListView listCategory, listMenu;
        private Button btnSoldoutAdd;

        public SoldoutAddView(Form parentForm)
        {
            this.parentForm = parentForm;
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(150, 250));
            hashtable.Add("point", new Point(10, 10));
            hashtable.Add("name", "주문리스트");
            listCategory = draw.getListView1(hashtable, parentForm);
            listCategory.Columns.Add("", 0, HorizontalAlignment.Center);
            listCategory.Columns.Add("카테고리", 146, HorizontalAlignment.Center);
            listCategory.Items.Add(new ListViewItem(new string[] { "", "커피" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "음료" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "티" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "디져트" }));



            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(500, 250));
            hashtable.Add("point", new Point(175, 10));
            hashtable.Add("name", "주문리스트");
            listMenu = draw.getListView(hashtable, parentForm);
            listMenu.Columns.Add("", 50, HorizontalAlignment.Center);
            listMenu.Columns.Add("메뉴", 440, HorizontalAlignment.Center);
            listMenu.Items.Add(new ListViewItem(new string[] { " ", "아메리카노" }));



            hashtable = new Hashtable();
            hashtable.Add("size", new Size(160, 60));
            hashtable.Add("point", new Point(510, 270));
            hashtable.Add("color", Color.LightGray);
            hashtable.Add("name", "ok");
            hashtable.Add("text", "품절추가");
            hashtable.Add("click", (EventHandler)btnSoldoutAdd_click);
            btnSoldoutAdd = draw.getButton(hashtable, parentForm);

        }

        private void btnSoldoutAdd_click(object o, EventArgs a)
        {
            foreach (ListViewItem listitem in listMenu.Items)
            {
                if (listMenu.Items.Count > 0)
                {
                    for (int i = listMenu.Items.Count - 1; i >= 0; i--)
                    {
                        if (listMenu.Items[i].Checked == true)
                        {
                            listMenu.Items[i].Remove();
                            MessageBox.Show("품절추가 완료");
                        }
                    }
                }
            }
        }
    }
}