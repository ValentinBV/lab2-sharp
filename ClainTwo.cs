using System;

namespace Labs2
{
    public class ClainTwo : IProps, IPropsOne
    {
        public void Prop1(string s)
        { 
            Console.WriteLine(s); 
        }
        public void Prop2(string s, int x)
        { 
            Console.WriteLine(s + x); 
        }
        public void Prop2(int x)
        { 
            Console.WriteLine(x); 
        }
        void IProps.Prop3()
        {
            Console.WriteLine("Метод 3 интерфейса 1");
        }
        void IPropsOne.Prop3()
        {
            Console.WriteLine("Метод 3 интерфейса 2");
        }
        public void Prop3FromInterface1()
        { 
            ((IProps)this).Prop3(); 
        }
        public void Prop3FromInterface2()
        { 
            ((IPropsOne)this).Prop3(); 
        }
    }
}
