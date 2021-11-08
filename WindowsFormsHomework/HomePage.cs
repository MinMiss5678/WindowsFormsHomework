using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
       
        List<object> windowsChildren = new List<object>();

        private void helloButton_Click(object sender, EventArgs e)
        {
            closeWindows();

            Hello windowsHello = new Hello();
            windowsChildren.Add(windowsHello);
            windowsHello.MdiParent = this;//設定窗體的父子關係
            windowsHello.Parent = splitContainer1.Panel2;//設定子窗體的容器為父窗體中的Panel
            windowsHello.Show();
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            closeWindows();

            Loan windowsLoan = new Loan();
            windowsChildren.Add(windowsLoan);
            windowsLoan.MdiParent = this;
            windowsLoan.Parent = splitContainer1.Panel2;
            windowsLoan.Show();
        }

        private void closeWindows()
        {
            foreach (Form i in windowsChildren)
            {
                i.Close();
            }
        }
    }
}

