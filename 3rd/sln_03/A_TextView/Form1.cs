using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A_TextView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string OrgStr = ""; //'결과 :' 문자열 저장 
        private void Form1_Load(object sender, EventArgs e)
        {
            OrgStr = this.lblResult.Text;
            this.txtEdit.Focus();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true) 
            { 
                this.lblResult.Text = OrgStr + this.txtEdit.Text;
                this.txtEdit.Text = "";
            }
        }

        private void txtEdit_Typed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //엔터키를 누를 때
            {
                //e.Handled = true; // 소리 없앰
                if (TextCheck() == true)
                { 
                    this.lblResult.Text = OrgStr + this.txtEdit.Text;
                    this.txtEdit.Text = "";
                }
            }
            if (e.KeyChar == (char)27)
            {
                this.txtEdit.Text = "";
            }
        }

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "" && this.txtEdit.Text.Count<char>(f => f == ' ') != this.txtEdit.Text.Length)
            {
                return true;
            }
            else
            {
                this.txtEdit.Text = "";
                this.lblResult.Text = OrgStr;
                MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtEdit.Focus();
                return false;
            }
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            this.lblResult.Text = OrgStr;

        }
    }
}
