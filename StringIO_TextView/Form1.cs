using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StringIO_TextView
{
    public partial class Form1 : Form //partial => 클래스를 쪼개놓았다고 생각(나중에 하나의 클래스로 합쳐서 봄)
    {
        string OrgStr = ""; // "결과 : " 문자열 저장  //org => original

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.txtEdit.Text;
        }
    }
}
