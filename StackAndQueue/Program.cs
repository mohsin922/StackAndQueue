using System;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack and Queue!");
            Stack linkedListStack = new Stack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            
        }
    }
}
