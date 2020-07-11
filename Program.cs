using System;
using System.Text;
using System.Collections;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime before = DateTime.UtcNow;

            // Elapsed: 39.5ms
            // int num = 0;
            // for (int i = 0; i < 10000000; i++) {
            //     num++;
            // }

            // Elapsed: 3331.3ms
            // string a = "";
            // for (int i = 0; i < 100000; i++) {
            //     a+= "a";
            // }

            // Elapsed: 1.2ms
            // StringBuilder builder = new StringBuilder();
            // for (int i = 0; i < 100000; i++) {
            //     builder.Append("a");
            // }

            // Elapsed: 118.5ms
            // string[] strings = new string[10000000];
            // for (int i = 0; i < 10000000; i++) {
            //     strings[i] = "a";
            // }

            // Elapsed: 299.4ms
            // ArrayList list = new ArrayList();
            // for (int i = 0; i < 10000000; i++) {
            //     list.Add("a");
            // }
            
            // Elapsed: 0.1ms
            TestObject testObject = new TestObject("Testy");

            Console.WriteLine("took=" + (DateTime.UtcNow - before).TotalMilliseconds + "ms");
        }
    }
}
