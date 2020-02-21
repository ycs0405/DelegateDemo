using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //委托的多播:
    //两个委托通过“+”运算符进行合并，合并委托相当于依次调用单个委托。只有相同类型的委托才能合并
    //通过“-”运算符从合并委托中移除委托
    class TestDelegate3
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
            TestDelegate3 t = new TestDelegate3();
            OperationNum operationNum1 = new OperationNum(t.add);
            OperationNum operationNum2 = new OperationNum(t.mul);

            OperationNum operationNum = null;
            operationNum = operationNum1;
            operationNum += operationNum2; //合并委托
            int res = operationNum(5); //75

            Console.WriteLine(res);

            operationNum -= operationNum2; //移除委托
            int res2 = operationNum(6);
            Console.WriteLine(res2);
        }
        */
    }
}
