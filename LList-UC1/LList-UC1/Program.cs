namespace LList_UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Linked List Program UC-1*****!\n");
            
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            newList.InsertEnd(56);
            newList.InsertEnd(30);
            newList.InsertEnd(70);
            newList.DisplayList();
            Console.WriteLine();
        }
    }
}