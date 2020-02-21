using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //委托的使用：可以把委托当成函数参数。
    class TestDelegate4
    {
        public delegate int OperationNum(int n);
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

        //将委托作为函数参数，委托代理的函数不同，doSomething就实现不同的功能
        public void doSomething(OperationNum operationNum,int n)
        {
            int res = operationNum(n);
            Console.WriteLine(res);
        }
        /*
        static void Main(string[] args)
        {
            TestDelegate4 t = new TestDelegate4();
            OperationNum operationNum1 = new OperationNum(t.add);   //作为add方法代理         
            t.doSomething(operationNum1,5); //调用加法功能

            OperationNum operationNum2 = new OperationNum(t.mul);   //作为mul方法代理     
            t.doSomething(operationNum2, 20); //调用乘法功能
        }
        */
    }
}
