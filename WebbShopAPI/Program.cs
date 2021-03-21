using System;
using WebbShopAPI.Database;
using WebbShopAPI.Helpers;
using WebbShopAPI.Views;

namespace WebbShopAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WScontext())
            {
                var test = new TestDemo();

                test.Demo();

            }

        }
    }
}
