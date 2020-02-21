using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
     //委托可在运行时改变
    class TestDelegate2
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
            TestDelegate2 t = new TestDelegate2();

            //实例化add方法的委托
            OperationNum operationNum1 = new OperationNum(t.add);

            //相当于 
            //int res1 = t.add(5);
            int res1 = operationNum1(5);
            Console.WriteLine(res1);

            //指向另一个方法mul()
            //实例化mul方法的委托
            operationNum1 = new OperationNum(t.mul);

            //相当于 
            //int res2 = t.mul(20);
            int res2 = operationNum1(20);
            Console.WriteLine(res2);
        }
      */
    }
}
