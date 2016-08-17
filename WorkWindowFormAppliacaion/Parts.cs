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
        public Node addNodeToList(Part list, Node newNode)
        {
            bool notBreak = true;
            //if head is null we startThe list 
            if (list.head == null)
            {
                newNode.next = null;
                list.head = newNode;
                            
            }
            //If the head of list is not null make a new node
            else if (list.head != null)
            {
                Node curr = list.head;
                Node prev = list.head;
                if(head.name == newNode.name)
                {
                    System.Windows.Forms.MessageBox.Show("names were ==");
                }
                else if ((head.next == null)||((String.Compare(newNode.name, curr.name) < 0)))
                {
                    if (String.Compare(newNode.name, curr.name) < 0)
                    {
                        Console.WriteLine("head.next is null and  newNOde procedes");
                        list.head = newNode;                                             
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
                    curr = curr.next;
                    do
                    {
                        Console.WriteLine("Dodododo");

                        //head.next is not null
                        if (String.Compare(newNode.name, curr.name) == 0)
                        {
                            System.Windows.Forms.MessageBox.Show("names were ==");
                            newNode = null;
                            notBreak = false;
                        }
                        else if ((String.Compare(newNode.name, curr.name) < 0))
                        {
                            Console.WriteLine("newNode name preceds curr.name");
                            Console.WriteLine(prev.name + " | " + curr.name);
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

                        Console.WriteLine("break is true");
                        curr.next = newNode;
                        newNode.next = null;
                    }
                    // curr.next = newNode;
                } 
            }
            return newNode;
        }

        public void deleteNode()
        {

        }

    }
    
}





















