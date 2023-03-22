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
                Console.WriteLine("\nChoose Option to Perform \n1.Create Stack and Push \n2.Peek and Pop \n3.Option to Perform Queue \n4.Exit");
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
                        bool flag1=true;
                        while (flag1)
                        {
                            QueueList queueList= new QueueList();
                            Console.WriteLine("\n.Select option to perform \n1.Create Queue of List(Enqueue) \n2.Dequeue \n3.Exit");
                            int option1=Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    queueList.Enqueue(56);
                                    queueList.Enqueue(30);
                                    queueList.Enqueue(70);
                                    queueList.Display();
                                    break;
                                    case 2:
                                    queueList.Enqueue(56);
                                    queueList.Enqueue(30);
                                    queueList.Enqueue(70);
                                    queueList.Display();
                                    queueList.Dequeue();                     
                                    break;
                                case 3:
                                    flag1=false;
                                    break;
                            }
                        }
                        break;
                        case 4:
                        flag = false;
                        break;
                }
            }           
        }
    }
}
