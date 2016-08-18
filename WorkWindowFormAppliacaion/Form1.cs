using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WorkWindowFormAppliacaion
{

    public partial class Form1 : Form
    {
     
        public Part newPartList = new Part();

        public Form1(Part partList)
        {
           
            InitializeComponent();
            textBox1.Text = "Search";
            if(partList != null)
            {
                newPartList = partList;
            }
            
        }
 
        private void button1_Click(object sender, EventArgs e)
        {

            addNewForm addNewPartForm = new addNewForm(newPartList);
            addNewPartForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (newPartList.head != null)
            {
                listView2.Items.Clear();
                Node curr = newPartList.head;

                while (curr.next != null)
                {
                    ListViewItem listBox1 = new ListViewItem(curr.name);
                    listBox1.SubItems.Add((curr.price.ToString("C")));
                    listBox1.SubItems.Add(curr.partNo.ToString());
                    listView2.Items.Add(listBox1);

                    curr = curr.next;

                }
                ListViewItem listBox11 = new ListViewItem(curr.name);
                listBox11.SubItems.Add(curr.price.ToString("C"));
                listBox11.SubItems.Add(curr.partNo.ToString());
                listView2.Items.Add(listBox11);

            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
 
        private void listView2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach(ListViewItem eachItem in listView2.SelectedItems)
            {
               newPartList.deleteNode(listView2.Items.IndexOf(eachItem));
                
                listView2.Items.Remove(eachItem);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newPartList.writeToFile();
        }
    }
}

   
