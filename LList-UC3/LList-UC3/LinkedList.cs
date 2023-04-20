namespace LList_UC3
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
        public Node GetLastNode()
        {
            Node temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
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
    }
}
