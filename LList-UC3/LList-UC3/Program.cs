namespace LList_UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Linked List Program UC-3*****\n");
            
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            newList.Append(56);
            newList.Append(30);
            newList.Append(70);
            newList.DisplayList();
            Console.WriteLine();
        }
    }
}