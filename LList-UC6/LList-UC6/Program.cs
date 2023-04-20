namespace LList_UC6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to Linked List Program UC-6*****\n");
           
            //Creating the instance of the Linked List Class
            LinkedList newList = new LinkedList();
            newList.Append(56);
            newList.Append(70);
            newList.InsertAtParticularPosition(2, 30);
            newList.DeleteLastNode();
            newList.DisplayList();
            Console.WriteLine();
        }
    }
}