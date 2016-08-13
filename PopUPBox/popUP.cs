using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopUPBox
{
    public partial class addNewForm : Form
    {
        public addNewForm()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex alpha = new Regex("a-zA-Z]");
            Regex number = new Regex("1-9");
            if (alpha.IsMatch(nameText.Text))
            {
                if(number.IsMatch(partNoText.Text))
                {
                    if(number.IsMatch(priceText.Text))
                    {
                        
                    }
                }
            }
        }

        private void nameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
