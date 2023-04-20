namespace LList_UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Linked List Program UC-2*****\n");
            
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            newList.InsertInFront(70);
            newList.InsertInFront(30);
            newList.InsertInFront(56);
            newList.DisplayList();
            Console.WriteLine();
        }
    }
}