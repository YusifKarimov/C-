using System;


namespace CovarianceAndContravarianceInGenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //exmple for convariance
            ICovariantInterFace<BaseClass> Baseob = new CovarinatClass<BaseClass>(new BaseClass("test Baseclass message"));
            ICovariantInterFace<DerivedClass> Derivedob = new CovarinatClass<DerivedClass>(new DerivedClass("test DerivedClass message"));
            Baseob.GetObj().ShowStr();
            Baseob = Derivedob; //  it is covaricance
            Baseob.GetObj().ShowStr();
            //exmple for contravarinace
            IContravariantInterFace<BaseClass> Baseobj = new ContravarinatClass<BaseClass>(new BaseClass());
            IContravariantInterFace<DerivedClass> Derivedobj = new ContravarinatClass<DerivedClass>(new DerivedClass());
            Derivedobj.Show(new DerivedClass());
            Baseobj.Show(new BaseClass());
            IContravariantInterFace<DerivedClass> Mixedobj = new ContravarinatClass<BaseClass>(new BaseClass()); // it is contravariance
            Mixedobj.Show(new DerivedClass());
            Mixedobj = Baseobj; // it is contravarinace
            Mixedobj.Show(new DerivedClass());
            Console.ReadKey();
        }
      
    }
 

    interface ICovariantInterFace<out T> 
    {
        T GetObj();
    }
    

    interface IContravariantInterFace<in V>
    {
        void Show(V v);
    }
    class CovarinatClass<T>:ICovariantInterFace<T> 
    {
        T ob;
        public CovarinatClass(T ob)
        {
            this.ob = ob;
        }
        public T GetObj()
        {
            return this.ob;
        }
    }
    class ContravarinatClass<V>:IContravariantInterFace<V>
    {
        V ob;
        public ContravarinatClass(V ob)
        {
            this.ob = ob;
        }

        public void Show(V v)
        {
            Console.WriteLine(v);
        }
    }
    class BaseClass
    {
        string str;
        public BaseClass() { }
        public BaseClass(string str) {
            this.str = str;
        }
        public override string ToString()
        {
            return "return from BaseClass";
        }
        public void ShowStr()
        {
            Console.WriteLine(str);
        }
        
    }
    class DerivedClass : BaseClass
    {
        public DerivedClass() { }
        public DerivedClass(string str):base(str) { }
        public override string ToString()
        {
            return "return from DerivedClass";
        }

    }
   }
