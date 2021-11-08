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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }
        string name;
        string englishName;
        string sexName;
        string constellation;
        string line = ",\n";

        private void SayHelloButton_Click(object sender, EventArgs e)
        {
            Keep();

            MessageBox.Show("Hello, 我是" + name + line + "英文名字是" + englishName + line + "性別是" + sexName + line + "星座是" + constellation + line + "很高興認識你。");
        }

        private void SayHiButton_Click(object sender, EventArgs e)
        {
            Keep();

            MessageBox.Show("Hi, 我是" + name + line + "英文名字是" + englishName + line + "性別是" + sexName + line + "星座是" + constellation + line + "很高興認識你。");
        }

        private void Keep()
        {
            name = nameTextBox.Text;
            englishName = englishNameTextBox.Text;
            sexName = sexTextBox.Text;
            constellation = constellationTextBox.Text;
        }
    }
}
