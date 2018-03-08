using System;
using DataStructures;

namespace OOP
{

    public class AbstractClassTest : IAlgorithm
    {
        public void Run()
        {
            BaseClass b=new BaseClass();
            DerivedClass d=new DerivedClass();
            BaseClass bd=new DerivedClass();
            b.FuncA();
            b.FuncAA();
            b.FuncC();
            d.FuncA();
            d.FuncAA();
            d.FuncC();
            bd.FuncA();
            bd.FuncAA();
            bd.FuncC();
        }
    }

    public class BaseClass
    {
        public void FuncA()
        {
            Console.WriteLine("Base FuncA");
        }

        public void FuncAA()
        {
            Console.WriteLine("Base FuncAA");
        }

        public virtual void FuncC()
        {
            Console.WriteLine("Base FuncC");
        }
    }

    public class DerivedClass:BaseClass
    {
        public new void FuncA()
        {
            Console.WriteLine("DerivedClass FuncA");
        }

        public new void FuncAA()
        {
            Console.WriteLine("DerivedClass FuncAA");
        }

        public override void FuncC()
        {
            Console.WriteLine("DerivedClass FuncC");
        }
    }
    public abstract class AbsBaseClass
    {
        public void FuncA()
        {
            Console.WriteLine("Base FuncA");
        }

        public void FuncAA()
        {
            Console.WriteLine("Base FuncAA");
        }

        private void FuncB()
        {

        }

        protected void FuncC()
        {
            
        }

        public virtual void FuncD()
        {

        }

        public abstract void FuncE();

    }

    public class AbsDerivedClass : AbsBaseClass
    {
        public new void FuncA()
        {
            Console.WriteLine("DerivedClass FuncA");
        }

        public new void FuncAA()
        {
            Console.WriteLine("DerivedClass FuncAA");
        }
        public override void FuncE()
        {
            // throw new NotImplementedException();
        }
    }
}