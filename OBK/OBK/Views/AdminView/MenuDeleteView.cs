using OBK.Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBK.Views.AdminView
{
    class MenuDeleteView
    {
        private Draw draw;
        private Form parentForm;
        private ListView listCategory, listMenu;
        private Button btnMenuDelete;
        private Hashtable hashtable;

        public MenuDeleteView(Form parentForm)
        {
            this.parentForm = parentForm;
            //db = new MYsql();
            draw = new Draw();
            getView();
        }

        private void getView()
        {
            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(150, 300));
            hashtable.Add("point", new Point(20, 30));
            hashtable.Add("name", "listCategory");
            hashtable.Add("click", (MouseEventHandler)listCategory_click);
            listCategory = draw.getListView1(hashtable, parentForm);
            listCategory.Columns.Add("", 0, HorizontalAlignment.Center);
            listCategory.Columns.Add("카테고리", 146, HorizontalAlignment.Center);
            listCategory.Items.Add(new ListViewItem(new string[] { "", "커피" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "음료" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "티" }));
            listCategory.Items.Add(new ListViewItem(new string[] { "", "디져트" }));

            hashtable = new Hashtable();
            hashtable.Add("color", Color.WhiteSmoke);
            hashtable.Add("size", new Size(490, 300));
            hashtable.Add("point", new Point(170, 30));
            hashtable.Add("name", "listMenu");
            listMenu = draw.getListView(hashtable, parentForm);
            listMenu.Columns.Add("", 50, HorizontalAlignment.Center);
            listMenu.Columns.Add("메뉴", 430, HorizontalAlignment.Center);
            listMenu.Items.Add(new ListViewItem(new string[] { " ", "아메리카노" }));

            hashtable = new Hashtable();
            hashtable.Add("size", new Size(150, 50));
            hashtable.Add("point", new Point(490, 440));
            hashtable.Add("color", Color.FromArgb(246, 246, 246));
            hashtable.Add("name", "btnAdd");
            hashtable.Add("text", "메뉴 삭제");
            hashtable.Add("font", new Font("맑은 고딕", 15, FontStyle.Regular));
            hashtable.Add("click", (EventHandler)btnMenuDelete_click);
            btnMenuDelete = draw.getButton1(hashtable, parentForm);
        }

        private void btnMenuDelete_click(object sender, EventArgs e)
        {
            MessageBox.Show("메뉴를 삭제했습니다.");
        }

        private void listCategory_click(object sender, MouseEventArgs e)
        {
            //listView2.Clear();

            //ListView listView = (ListView)sender;
            //ListView.SelectedListViewItemCollection itemGroup = listView.SelectedItems;
            //ListViewItem item1 = itemGroup[0];

            //string sql = string.Format("select * from {0}", item1.SubItems[0].Text);

            //MSsql mSsql = new MSsql();
            //SqlDataReader dataReader = mSsql.Select(sql);
            //bool Bool = true;

            //while (dataReader.Read())
            //{
            //    ListViewItem item = null;
            //    for (int i = 0; i < dataReader.FieldCount; i++)
            //    {
            //        if (Bool) listView2.Columns.Add(dataReader.GetName(i), 80, HorizontalAlignment.Left);

            //        string value = dataReader.GetValue(i).ToString();
            //        if (item == null) item = new ListViewItem(value);   // null이면 생성 만든다.
            //        else item.SubItems.Add(value);
            //    }
            //    Bool = false;

            //    listView2.Items.Add(item);
            //}
        }
    }
}
