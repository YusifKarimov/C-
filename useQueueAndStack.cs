using System;
using System.Collections;
namespace useQueueAndStack
{
    class Program
    {
        
     public   static void Main(string[] args)
        {
            MyStack<string> mySt = new MyStack<string>(7);
            MyQueue <string> myQu = new MyQueue<string>(7);
            string[] name = { "Ramil", "Yusif", "Ilham", "Senan", "Evez", "Shura","Togrul" };
            mySt.myPush(name);
            myQu.myEnqueue(name);
            //mySt.myClear();
            try
            {
                mySt.myPeek();
                mySt.ShowStack();
            }
           catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            //myQu.myClear();
            try
            {
                myQu.myPeek();
                myQu.ShowQueue();
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }

            
            Console.ReadKey();
        }
        
    }
    class MyStack<T>:Stack
    {
        Stack St;
        public MyStack(int c = 0)
        {
            St = new Stack(c);
        }
        public void myPop(uint ct = 1)
        {
            if(ct>St.Count)
            {
                Console.WriteLine("ct bigger than number of elements of stack");

                return;
            }
            Console.WriteLine("\n****List of  elements of stack ****\n");
            for (uint i = 0; i < ct; i++)
                Console.WriteLine(St.Pop());
            
        }
        public void myPeek()
        {
            Console.WriteLine(St.Peek());
        }

        public void myPush(params T[] ob)
        {
            foreach (T o in ob)
            {
                St.Push(o);
            }
        }
        public void ShowStack()
        {
            Console.WriteLine("\n****List of all  elements of stack({0}) ****\n",St.Count);
            int ct = St.Count;
            for (int i = 0; i < ct; i++)
            Console.WriteLine(St.Pop());
            Console.WriteLine("*****************End List********************\n");
        }
        public void myClear()
        {
            St.Clear();
        }
    }

    class MyQueue<T> : Queue
    {
        Queue Que;
        public MyQueue(int c = 0)
        {
            Que = new Queue(c);
        }
        public void myDequeue(uint ct = 1)
        {
            if (ct > Que.Count)
            {
                Console.WriteLine("ct bigger than number of elements of queue");

                return;
            }
            Console.WriteLine("\n****List of  elements of queue ****\n");
            for (uint i = 0; i < ct; i++)
                Console.WriteLine(Que.Dequeue());
            
        }

        public void myEnqueue(params T[] ob)
        {
            foreach (T o in ob)
            {
                Que.Enqueue(o);
            }
        }
        public void ShowQueue()
        {
            Console.WriteLine("\n****List of all  elements of queue({0}) ****\n", Que.Count);
            int ct = Que.Count;
            for (int i = 0; i < ct; i++)
                Console.WriteLine(Que.Dequeue());
            Console.WriteLine("*****************End List********************\n");
        }
        public void myPeek()
        {
            Console.WriteLine(Que.Peek());
        }
        public void myClear()
        {
            Que.Clear();
        }
    }
}
