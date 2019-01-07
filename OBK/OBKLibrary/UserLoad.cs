using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBKLibrary
{
    public static class UserLoad
    {
        //private Form parentForm;
        //private Form parent;//mdi를 사용할때 부모폼을 불러오기 위한 변수
        //private UserView uv;//부모구현 코드 정보 받아오기
        //private object oDB;
        //private int cNo = 0;
        //private string mName = "";

        //public Load(Form parentForm)
        //{
        //    this.parentForm = parentForm;
        //}

        //public Load(Form parentForm, int cNo)
        //{
        //    this.parentForm = parentForm;
        //    this.cNo = cNo;
        //}

        //public Load(Form parentForm, int cNo, Form parent, UserView uv)
        //{
        //    this.parentForm = parentForm;
        //    this.cNo = cNo;
        //    this.parent = parent;
        //    this.uv = uv;
        //}

        //public Load(Form parentForm, string mName)
        //{
        //    this.parentForm = parentForm;
        //    this.mName = mName;
        //}

        //public Load(Form parentForm, object oDB)
        //{
        //    this.parentForm = parentForm;
        //    this.oDB = oDB;
        //}

        public static bool GetHandler(Form parentForm, string viewName)
        {
            switch (viewName)
            {
                case "main":
                    parentForm.Size = new Size(500, 400);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "메인화면";
                    return true;
                case "bill":
                    parentForm.Size = new Size(500, 500);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    return true;
                case "choice":
                    parentForm.Size = new Size(450, 550);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "선택화면";
                    parentForm.BackColor = Color.White;
                    return true;
                case "menu":
                    parentForm.Size = new Size(1000, 300);
                    parentForm.FormBorderStyle = FormBorderStyle.None;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.AutoScroll = true;
                    parentForm.Text = "메뉴";
                    return true;
                case "pay":
                    parentForm.IsMdiContainer = false;
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.BackColor = Color.White;
                    parentForm.Size = new Size(500, 400);
                    return true;
                case "user":
                    parentForm.Size = new Size(800, 900);
                    parentForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    parentForm.StartPosition = FormStartPosition.CenterScreen;
                    parentForm.MaximizeBox = false;
                    parentForm.MinimizeBox = false;
                    parentForm.Text = "사용자화면";
                    return true;
                default:
                    return false;
            }
        }
    }
}
