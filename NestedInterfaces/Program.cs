using System;

namespace NestedInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    
    public interface IInterface
    {
        public interface INestedInterface<T>
        {
        }
        public interface INestedSubInterface<T1, T2> : INestedInterface<T1>
            where T2 : INestedSubInterface<T1, T2>.IDoubleNestedInterface
        {
            public interface IDoubleNestedInterface
            {
            }
        }
    }
}