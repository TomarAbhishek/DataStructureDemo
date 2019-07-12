using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class Node{
        public int data;
        public Node next;

        public Node(int d){
            data=d;
            next=null;

        }
        public void printList(){
            Console.Write("|"+data+"|-> ");
            if(next!=null){
                next.printList();
            }
        }
        public void AddToEnd(int data){
            if(next==null){
                next=new Node(data);
            }
            else{
                next.AddToEnd(data);
            }
        }
        /*public void AddtoStart(int data){
            if(next==null){
                next=new Node(data);
            }
            else{
                next.AddtoEnd(data);
            }
        }*/
    }

    public class MyList{
        public Node headNode;
        
        public MyList(){
            headNode=null;
        }
        public void AddToEnd(int data){
            if(headNode==null){
                headNode=new Node(data);
            }
            else{
                headNode.AddToEnd(data);
            }
        }
        
        public void print(){
            if(headNode!=null){
                headNode.printList();
            }
        }

        public void AddToStart(int data){
            if(headNode== null){
                headNode=new Node(data);
            }
            else{
                Node temp=new Node(data);
                temp.next=headNode;
                headNode=temp;
            }
        }
        public void PrintReverse(Node node){
            if(node==null)
                return ; 
            PrintReverse(node.next);
            Console.Write("|"+ node.data +"|-> ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList mynode=new MyList(); 
            mynode.AddToEnd(11);
            mynode.AddToEnd(12);
            mynode.AddToEnd(22);
            mynode.AddToEnd(13);
            mynode.AddToEnd(14);
            mynode.AddToStart(3);
            mynode.print();
            Console.WriteLine();
            mynode.PrintReverse(mynode.headNode);
            Console.ReadLine();
        }
    }
}
