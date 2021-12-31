﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackAndQueue
{
    public class Queue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {

                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("{0} enqueued to Queue", node.data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}


