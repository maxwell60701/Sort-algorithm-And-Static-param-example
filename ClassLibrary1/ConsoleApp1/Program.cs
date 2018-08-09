using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            //创建包含静态构造函数的类实例时和访问包含静态构造函数的静态成员时，先调用静态构造函数，无论创建了多少个类实例和调用多少次静态成员，其静态构造函数都只调用了一次。
            StaticTest s = new StaticTest();
            StaticTest s2 = new StaticTest();
            //s.Say(); //无法使用实例来引用来访问静态成员
            StaticTest.Say();
            StaticTest.Say();
            Console.WriteLine(StaticTest.constdemo);

            //调用静态类的静态方法，其中的静态构造也是只被调用一次
            StaticTest2.Say();
            StaticTest2.Say();

          
           
            Console.ReadKey();

        }
    }
    public class StaticTest
    {
        private static string staticparam ;  //静态变量属于全局，不会再被初始化，故第一次初始化后，不再被初始化
        private  string param = "";
        //静态构造方法不可以被修饰符public等修饰,静态构造必须无参数
        //public static StaticTest()
        static StaticTest()
        {
            Console.WriteLine("非静态类的静态构造方法只被调用一次");
        }
        //无参数的构造函数可以与静态构造函数共存。尽管参数列表相同，但一个属于类，一个属于实例，所以不会冲突。
        public StaticTest()
        {
            Console.WriteLine("staticparam第一次为:" + staticparam);  
            Console.WriteLine("param第一次为:" + param);
            Console.WriteLine("非静态类的非静态构造方法可以共存");
            staticparam = "1";
            param = "1";
            Console.WriteLine("staticparam第二次为:" + staticparam);
            Console.WriteLine("param第二次为:" + param);
        }
        //虽然字段不能声明为 static const，但 const 字段的行为在本质上是静态的。
        //这样的字段属于类，不属于类的实例。因此，可以同对待静态字段一样使用 ClassName.MemberName 表示法来访问 const 字段
        public const int constdemo = 1;
        public static void Say()
        {
            Console.WriteLine("非静态类的的静态方法");
        }
    }

    public static class StaticTest2
    {
        static StaticTest2()
        {
            Console.WriteLine("静态类的静态构造方法只被调用一次");
        }
        public static void Say()
        {
            Console.WriteLine("静态类的的静态方法");
        }
    }
}
