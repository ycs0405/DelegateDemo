using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //1、委托简单例子
    //委托是对函数的引用，调用委托，等价于调用函数
    //委托在使用前必须实例化
    class TestDelegate
    {
        delegate int OperationNum(int n);
        int num = 10;
        public int add(int n)
        {
            num += n;
            return num;
        }
        public int mul(int n)
        {
            num *= n;
            return num;    
        }

       /*
        static void Main(string[] args)
        {
            TestDelegate t = new TestDelegate();

            //实例化add方法的委托
            OperationNum operationNum1 = new OperationNum(t.add);

            //相当于 
            //int res1 = t.add(5);
            int res1 = operationNum1(5);
            Console.WriteLine(res1);

            //实例化mul方法的委托
            OperationNum operationNum2 = new OperationNum(t.mul);

            //相当于 
            //int res2 = t.mul(20);
            int res2 = operationNum2(20);
            Console.WriteLine(res2);

        }
       */
    }
}
