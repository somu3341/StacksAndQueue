using System;
namespace StacksAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag=true;
            while(flag)
            {
                LinkedListStacks stacks= new LinkedListStacks();
                Console.WriteLine("\nChoose Option to Perform \n1.Create Stack and Push \n2.Peek and Pop\n3.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        stacks.Push(70);
                        stacks.Push(30);
                        stacks.Push(56);
                        stacks.Dsiplay();
                        break;
                        case 2:
                        stacks.Push(70);
                        stacks.Push(30);
                        stacks.Push(56);
                        stacks.Peek();
                        stacks.Pop();
                        stacks.Dsiplay();
                        break;
                        case 3:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
