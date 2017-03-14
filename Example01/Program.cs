using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Status response = Status.Error;

            switch (response)
            {
                case Status.Success:
                    //需要的程式
                    Console.WriteLine("狀態是成功");
                    Console.WriteLine((int)response);
                    break;

                case Status.Error:
                    //需要的程式
                    Console.WriteLine("狀態是失敗");
                    Console.WriteLine((int)response);
                    break;

                default:
                    //需要的程式
                    Console.WriteLine("狀態是不明，什麼都不做");
                    Console.WriteLine(response);
                    break;
            }
        }
    }
}