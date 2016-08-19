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

namespace WorkWindowFormAppliacaion
{
    
    public partial class addNewForm : Form
    {
        
        Node theNode = new Node();
        Part theList = new Part();
        
        public addNewForm(Part list)
        {
            if(list != null)
            {
                theList = list;
            }
            InitializeComponent();           
        }
           
        public void button1_Click(object sender, EventArgs e)
        {
           // Regex alpha = new Regex("a-zA-Z]");
           //  Regex number = new Regex("1-9");
            if (nameText.Text.Length > 0)
            {
                if(partNoText.Text.Length > 0)
                {
                    if(priceText.Text.Length > 0)
                    {
                        int partNumber = Convert.ToInt32(this.partNoText.Text);
                        double partPrice = Convert.ToDouble(this.priceText.Text);
                    
                        theList.addNodeToList(theList.createNode(nameText.Text, partNumber, partPrice));

                        Form1 firstForm = new Form1(theList);
                                                               
                        this.Close();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
 