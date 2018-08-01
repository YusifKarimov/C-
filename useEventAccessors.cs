using System;

//static void Main(string[] args)

delegate void myDelType();
public class Program
{
    int ct,top;

    myDelType[] eventArr;
    public Program(int ct)
    {
        this.ct = ct;
        top = 0;
        eventArr = new myDelType[this.ct];
    }

    //main function
    public static void Main(string[] args)
    {
        Program test = new Program(6);
        test.myEvent += new myDelType(X.XHandler);
        
        test.myEvent += new myDelType(X.XHandler1);
        test.myEvent += new myDelType(X.XHandler2);
        
        test.myEvent += new myDelType(Y.YHandler);
        test.myEvent += new myDelType(Y.YHandler1);
        test.myEvent += new myDelType(Y.YHandler2);
        
        test.check();
        Console.ReadKey();
    }

    event myDelType myEvent
    {
        add
        { // add function to delegate arr
            int i;
            for (i = 0; i < ct; i++)
                if (eventArr[i] == null)
                {

                    eventArr[i] = value;
                    Console.WriteLine("Funstion added to Event ");
                    top++;
                    break;
                }
                if(top==ct)
                {
                    Console.WriteLine("Event is full");
                
                }
        }
        remove
        {
            //remove function delegate array
            int i;
            for (i = 0; i < ct; i++)
                if (eventArr[i] == value)
                {
                    eventArr[i] = null;
                    Console.WriteLine("Funstion removed from Event ");
                    top--;
                    break;
                }
                if(top==0)
                {
                    Console.WriteLine("Event is empty");
                    
                }
        }
    }

  
  public  void check()
    {
        byte i;
        for (i = 0; i < ct; i++)
            if (eventArr[i] != null) // which event isnt null, fire it
            eventArr[i]();
    }
}
class X
{
    public static void XHandler()
    {
        Console.WriteLine("Class - X,fun: Xhandler");
    }
    public static void XHandler1()
    {
        Console.WriteLine("Class - X,fun: Xhandler1");
    }
    public static void XHandler2()
    {
        Console.WriteLine("Class - X,fun: Xhandler2");
    }
}
class Y
{
    public static void YHandler()
    {
        Console.WriteLine("Class - Y,fun: Yhandler");
    }
    public static void YHandler1()
    {
        Console.WriteLine("Class - Y,fun: Yhandler1");
    }
    public static void YHandler2()
    {
        Console.WriteLine("Class - Y,fun: Yhandler2");
    }
}
