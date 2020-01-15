using System;

namespace Labs2
{
    class TestClainTwo
    {
        public void TestTwoInterfaces()
        {
            ClainTwo claintwo = new ClainTwo();
            claintwo.Prop1("Склейка свойства двух интерфейсов");
            claintwo.Prop2("перегрузка .: ", 99);
            claintwo.Prop2(9999);
            claintwo.Prop3FromInterface1();
            claintwo.Prop3FromInterface2();
            Console.WriteLine("Интерфейсный объект вызывает методы 1-го интерфейса!");
            IProps ip1 = (IProps)claintwo;
            ip1.Prop1("интерфейс IProps: свойство 1");
            ip1.Prop3();
            Console.WriteLine("Интерфейсный объект вызывает методы 2-го интерфейса!");
            IPropsOne ip2 = (IPropsOne)claintwo;
            ip2.Prop1("интерфейс IPropsOne: свойство1");
            ip2.Prop3();
        }
    }
}
