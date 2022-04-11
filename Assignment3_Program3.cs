//Create a custom exception class named StackException. The Push()and Pop() method should throw object of StackException when the stack is full or empty respectively.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Icloneable
    {
        void Push(int data);
        int Pop();
    }
    class UsingInterface_Icloneable
    {

        public static void Main()

        {
            MyStack pp = new MyStack();

            pp.Push(10);
            pp.Push(20);
            pp.Push(30);
            pp.Push(40);
            pp.Push(50);
            pp.Push(60);
            pp.print();
            Console.WriteLine();
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());

            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            Console.WriteLine("Element removed from stack:" + pp.Pop());
            

        }
    }

    public class MyStack : Icloneable
    {



        int[] arr = new int[5];

        int top = 0;



        public void Push(int data)

        {

            try
            {
                if (top == 5)
                {
                    Console.WriteLine("-----StackOverFlow-------");

                }


                else
                {
                    arr[top] = data;
                    top++;
                }

            }
            catch (Exception e)
            {

            }
        }

        public void print()
        {

            for (int i = top - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int Pop()
        {
            if (top <= 0)
            {
                Console.WriteLine("-----Stack Under Flow------");
                return -1;
            }
            else
            {
                int temp = arr[top - 1];
                top--;

                return temp;
            }
        }
    }



}
