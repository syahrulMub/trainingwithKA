using System.Diagnostics;
using System.Text;

namespace FooBarChangalle
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();

            FooBar2 obj = new FooBar2();
            obj.add(3, "Fizz");
            obj.add(5, "Buzz");
            obj.add(7, "Dazz");
            obj.remove(7);
            obj.process();

            sw.Stop();
            Console.WriteLine("\nElapsed={0}", sw.Elapsed);

            // FooBar obj = new FooBar();
            // int Input = obj.GetInputUser();
            // obj.AddData(3, "Fizz");
            // obj.RemoveData(5);
            // obj.AddData(4, "Dazz");


            // //menampilkan hasil akhir
            // StringBuilder result = new();
            // for (int i = 1; i <= Input; i++)
            // {
            //     string resultData = obj.GetData(i);
            //     result.Append(resultData).Append(" ");
            // }
            // Console.WriteLine(result.ToString());
        }
    }
}