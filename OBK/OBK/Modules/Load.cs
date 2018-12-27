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
        private Form parent;//mdi를 사용할때 부모폼을 불러오기 위한 변수
        private UserView uv;//부모구현 코드 정보 받아오기
        private object oDB;
        private int cNo = 0;
        private string mName = "";

        public Load(Form parentForm)
        {
            this.parentForm = parentForm;
        }

        public Load(Form parentForm,int cNo)
        {
            this.parentForm = parentForm;
            this.cNo = cNo;
        }

        public Load(Form parentForm, int cNo,Form parent, UserView uv)
        {
            this.parentForm = parentForm;
            this.cNo = cNo;
            this.parent = parent;
            this.uv = uv;
        }

        public Load(Form parentForm, string mName)
        {
            this.parentForm = parentForm;
            this.mName = mName;
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
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            new BillView(parentForm);
        }
        private void GetChoiceLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(450, 550);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "선택화면";
            parentForm.BackColor = Color.White;
            new ChoiceView(parentForm, mName);
        }
        private void GetMenuLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(1000, 300);
            parentForm.FormBorderStyle = FormBorderStyle.None;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.AutoScroll = true;
            parentForm.Text = "메뉴";
            new MenuView(parent,parentForm, cNo, uv);
        }
        private void GetPayLoad(object o, EventArgs a)      // 결제
        {
            parentForm.IsMdiContainer = false;
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.BackColor = Color.White;
            parentForm.Size = new Size(500, 400);
            new PayView(parentForm);
        }
        private void GetUserLoad(object o, EventArgs a)
        {
            parentForm.Size = new Size(800, 900);
            parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            parentForm.StartPosition = FormStartPosition.CenterScreen;
            parentForm.MaximizeBox = false;
            parentForm.MinimizeBox = false;
            parentForm.Text = "사용자화면";
            new UserView(parentForm);
        }

    }
}
