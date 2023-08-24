namespace InheritanceExamples1
{
    internal class Program
    {
        static void Main1()
        {
            BaseClass o1 = new BaseClass();
            //o1.

            DerivedClass o2 = new DerivedClass();
            //o2.
        }
    }

    public class BaseClass //: Object
    {
        public int i;
    }

    public class DerivedClass : BaseClass
    {
        public int j;
    }
}

//access specifiers
namespace InheritanceExamples2
{
    class Program
    {
        static void Main2()
        {
            //BaseClass o = new BaseClass();
            //o.

            //TestAccessSpecifiers.BaseClass o2 = new TestAccessSpecifiers.BaseClass();
            //o2.
        }
    }
    //public -> everywhere
    //private -> same class
    //protected -> same class, derived class
    //internal -> same class, same assembly(same project)
    //protected internal -> same class, derived class, same assembly
    //private protected - same class, derived class which is in the same assembly
    public class BaseClass
    {
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;
        int x; //private

    }
    public class DerivedClass : TestAccessSpecifiers.BaseClass    //:  BaseClass
    {

        void DoNothing()
        {
            //this.
        }
    }
}


//constructors in inheritance
namespace InheritanceExamples3
{

    class Program
    {
        static void Main()
        {
            //DerivedClass o = new DerivedClass();

            DerivedClass o2 = new DerivedClass(123, 456);
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            //i = 10;
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int,int cons");
            //this.i = i;
            this.j = j;
        }
    }
}