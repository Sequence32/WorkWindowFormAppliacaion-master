using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWindowFormAppliacaion
{
    public class Node
    {

        public Node next;
        public int partNo;
        public string name;
        public double price;

    }

    public class Part
    {
        public Node head = null;
        public Node first = null;

        //Makes new node to add to partList
        public Node createNode(string name, int partNo, double price)
        {
           
            Node newNode = new Node();
            Node temp = new Node();

            newNode.partNo = partNo;
            newNode.name = name;
            newNode.price = price;

            return newNode;
        }

        //Adding new Node to list in Alphabedical order
        public void addNodeToList(Node newNode)
        {
            bool notBreak = true;
            //if head is null we startThe list 
            if (head == null) 
            {
                head = newNode;
                newNode.next = null;
                                          
            }
            //If the head of list is not null make a new node
            else if (head != null)
            {
                Node curr = head;
                Node prev = head;
                if(head.name == newNode.name)
                {
                    System.Windows.Forms.MessageBox.Show("names were ==");
                }
                else if ((head.next == null)||((String.Compare(newNode.name, curr.name) < 0)))
                {
                    if (String.Compare(newNode.name, curr.name) < 0)
                    {

                        head = newNode;                                             
                        notBreak = false;
                        newNode.next = curr;
                        if(head.next == null)
                        {
                            curr.next = null;
                        }

                    }
                    else
                    {
                        head.next = newNode;
                        newNode.next = null;
                        notBreak = false;
                    }                   
                }
                else
                {
                    //Traverse through the list untill end of list or Alphabedicaly correct order then break
                    prev = curr;
                    do
                    {

                        if(curr.next != null)
                        {
                            if(String.Compare(newNode.name, curr.next.name) == 0)
                            {
                                System.Windows.Forms.MessageBox.Show("names were ==");
                                newNode = null;
                                notBreak = false;
                                break;
                            }
                        }
                        if (String.Compare(newNode.name, curr.name) == 0)
                        {
                            System.Windows.Forms.MessageBox.Show("names were ==");
                            newNode = null;
                            notBreak = false;
                            break;
                        }
                        else if ((String.Compare(newNode.name, curr.name) < 0))
                        {
                            prev.next = newNode;
                            newNode.next = curr;                          
                            
                            notBreak = false;
                            break;
                        }
                        prev = curr;
                        curr = curr.next;
                    } while (curr.next != null);

                    if (notBreak == true)
                    {
                        if (String.Compare(newNode.name, curr.name) < 0)
                        {
                            newNode.next = curr;
                            prev.next = newNode;
                            curr.next = null;
                        }
                        else
                        {
                            curr.next = newNode;
                            newNode.next = null;
                        }
                           
                    } 
                } 
            }
        }


        public void deleteNode(int nodeToRemove)
        {
            Node retreve = head, prev = head;
           
            for(int i=0; i<nodeToRemove; i++)
            {
                prev = retreve;
                retreve = retreve.next;
            }
            if(retreve == head)
            {               
                if(head.next == null)               
                    head = null;                                   
                else              
                    head = head.next;        
                         
            }
            else if (retreve.next == null)            
                prev.next = null;         
            else
            {
                prev.next = retreve.next;
                retreve = null;
            }

        }

        public void writeToFile()
        {
            Node curr = head;
            if (head != null)
            {


                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"partInformation1.txt"))
                {
                    while (curr.next != null)
                    {
                        file.WriteLine(curr.name);
                        file.WriteLine(curr.partNo);
                        file.WriteLine(curr.price);
                        Console.WriteLine(curr.name + "written to file");
                        curr = curr.next;
                    }
                    file.WriteLine(curr.name);
                    file.WriteLine(curr.partNo);
                    file.WriteLine(curr.price);
                    Console.WriteLine(curr.name + "written to file");

                    file.Close();
                }
            }
        }
        public void readFromFile()
        {
            int i = 0;
            Node curr = head;
            int partNum =1;
            string partName="";
            double partPrice;

            string[] file = System.IO.File.ReadAllLines(@"partInformation1.txt");
           
            {
                foreach (string line in file)
                {
                    if (i == 0)
                    {
    
                        partName = line;
                        i++;
                    }     
                    else if(i == 1)
                    {  
                        partNum = Convert.ToInt32(line);
                        i++;
                    }
                    else
                    {
                        partPrice = Convert.ToDouble(line);
                        addNodeToList(createNode(partName, partNum, partPrice));
                        i = 0;
                    }

                }
            }
        }


    }
    

}





















