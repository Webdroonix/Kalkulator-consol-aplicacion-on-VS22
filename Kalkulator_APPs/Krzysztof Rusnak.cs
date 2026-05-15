using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_APPs
{
    public partial class Form1 : Form
    {
        private int clickedValue;

        public Form1()
        {
            InitializeComponent();
        }

        private void OnBtnNumberClick(object sender, EventArgs e)
        {
            var clickedValue = (sender as Button).Text;
            if (tbScreen.Text == "0")
                tbScreen.Text = string.Empty;
            tbScreen.Text = clickedValue;
        }

        private void OnBtnResultClick(object sender, EventArgs e)
        {

        }

        private void OnBtnClearClick(object sender, EventArgs e)
        {

        }

       private void tbScreen_TextChanged(object sender, EventArgs e)
        {
            tbScreen.Text += clickedValue;
            tbScreen.Text = "0";
        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            var operation = (sender as Button).Text;
        }



    }
}
