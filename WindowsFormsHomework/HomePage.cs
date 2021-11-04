﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsHomework
{
    public partial class HomePage : Form
    {
        private readonly List<IPanel> windowsChildren = new List<IPanel>();

        public HomePage()
        {
            InitializeComponent();
        }

        private void helloButton_Click(object sender, EventArgs e)
        {
            FactoryPanel(new Hello());
        }

        private void loanButton_Click(object sender, EventArgs e)
        {
            FactoryPanel(new Loan());
        }

        private void FactoryPanel(IPanel panel)
        {
            panel.Open(this, splitContainer1.Panel2, CloseWindows);
            windowsChildren.Add(panel);
        }

        private void CloseWindows()
        {
            foreach (var i in windowsChildren)
            {
                i.Close();
            }
        }
    }

    internal interface IPanel
    {
        void Open(Form mdiParent, Control parent, Action onOpen);
        void Close();
    }
}