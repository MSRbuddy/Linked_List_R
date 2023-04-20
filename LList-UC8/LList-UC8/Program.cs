namespace LList_UC8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Linked List Program UC-8*****\n");
            
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            newList.Append(56);
            newList.Append(70);
            newList.InsertAtParticularPosition(2, 30);
            Console.WriteLine("\nLinked List Status......");
            newList.DisplayList();
            Console.WriteLine("\nPostion of the element 30 is  " + newList.SearchTheNode(30));
            int position = newList.SearchTheNode(30);
            newList.InsertAtParticularPosition(position + 1, 40);
            Console.WriteLine("\nLinked List Status......");
            newList.DisplayList();
            Console.WriteLine();
        }
    }
}