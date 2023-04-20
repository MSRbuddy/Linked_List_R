﻿namespace LList_UC7
{
    public class LinkedList
    {
        public Node head;
        // UC-1 Adding the node to the end of the linked list
        public void InsertEnd(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }
        // Getting the last node of the linked list by traversal
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
        // Displaying the linked list by traversal
        public void DisplayList()
        {
            Node temp = this.head; 
            if (temp == null)
            {
                Console.WriteLine("The Linked List is Empty...");
                return;
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.value + "  ");
                    temp = temp.next;
                }
            }
        }
        // UC2- Inserting the element at the head of the linked list
        public void InsertInFront(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = this.head;
            this.head = newNode;
        }
        // UC-3 Appending the node to the end of the linked list
        public void Append(int newData)
        {
            Node newNode = new Node(newData);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.next = newNode;
            }
        }
        // UC4- Inserting the node at a particular position in the linked list
        public Node InsertAtParticularPosition(int position, int newData)
        {
            if (position < 1)
                Console.WriteLine("The Position passed is invalid to insert...");
            else if (position == 1)
            {
                Node newNode = new Node(newData);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node temp = new Node(newData);
                        temp.next = this.head.next;
                        head.next = temp;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                    Console.WriteLine("Position Out Of Range....");
            }
            Console.WriteLine("Inserted Value is - " + head.next.value);
            return head;
        }
        // UC5- Deleting the first node of the linked list
        public Node DeleteFirstNode()
        {
            if (this.head == null)
                return null;
            else
            {
                this.head = this.head.next;
                return this.head;
            }
        }
        // UC6- Deleting the last node of the linked list
        public Node DeleteLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
            {
                Console.WriteLine("Only one node in the linked list...");
            }
            Node tempNode = this.head;
            while (tempNode.next.next != null)
            {
                tempNode = tempNode.next;
            }
            tempNode.next = null;
            return head;
        }
        // UC7- Getting the position of the node with the value passed by the user        
        public int SearchTheNode(int valueOfNode)
        {
            int count = 0;
            while (this.head != null)
            {
                if (this.head.value == valueOfNode)
                    return ++count;
                this.head = this.head.next;
                count++;
            }
            return count;
        }
    }
}
