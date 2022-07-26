using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace SHA256
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text =FormsAuthentication.HashPasswordForStoringInConfigFile(textBox1.Text, "SHA256");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
