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
            //if head is null we startThe list 
            if (list.head == null)
            {
                list.head = newNode;
                list.first = newNode;
                
            }
            //If the head of list is not null make a new node
            else if (list.head != null)
            {             
                Node curr = new Node();
                Node temp;

                curr = list.head;

                if (curr.next == null)
                {
                    if (String.Compare(newNode.name, curr.name) > 0)
                    {
                        list.head = newNode;
                        newNode.next = curr;
                        curr.next = null;

                    }
                }
                else
                {
                    //Traverse through the list untill end of list or Alphabedicaly correct order then break
                    while (curr.next != null)
                    {
                        Console.WriteLine("Close but no sugar");
                        // if less than 0 nweNode.name precedes string curr name in the list 
                        if (String.Compare(newNode.name, curr.name) > 0)
                        {
                            Console.WriteLine("We made it this far");
                            // head next is null and newNode is placed as new head
                            if (list.head.next == null)
                            {
                                list.head = newNode;
                                newNode.next = curr;
                                curr.next = null;
                                break;

                            }
                            //head.next is not null
                            else if ((curr == list.head) && (list.head.next != null))
                            {

                                list.head = newNode;
                                newNode.next = curr;
                                break;

                            }


                        }
                        else if (String.Compare(newNode.name, curr.name) < 0)
                        {
                            if(this is different )
                        }
                        curr = curr.next;
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





















