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

            Queue linkedListQueue = new Queue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            Console.WriteLine("Elements inside Queue are: ");
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            Console.WriteLine("Elements inside Queue after Dequeuing are: ");
            linkedListQueue.Display();

        }
    }
}
