namespace LList_UC7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Linked List Program UC-7*****\n");
                      
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            newList.Append(56);
            newList.Append(70);
            newList.InsertAtParticularPosition(2, 30);
            newList.DisplayList();
            Console.WriteLine("\nPostion of the element 30 is  " + newList.SearchTheNode(30));
            Console.WriteLine();
        }
    }
}