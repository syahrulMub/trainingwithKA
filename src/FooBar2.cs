using System.Text;
using System.Collections.Generic;

namespace FooBarChangalle
{
    public class FooBar2
    {
        private Dictionary<int, string> foobarList = new Dictionary<int, string>();
        public int inputUser;

        public FooBar2()
        {
            inputUser = input();
        }

        public void add(int key, string value)
        {
            foobarList.TryAdd(key, value);
        }

        public void remove(int key)
        {
            foobarList.Remove(key);
        }

        public int input()
        {
            Console.Write("Masukkan Angka yang anda inginkan : ");
            try
            {
                inputUser = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Exception ex = new Exception();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Inputan harus angka!\n");
                input();
            }
            return inputUser;
        }
        public void process()
        {
            // string result = "";
            for (int i = 1; i <= inputUser; i++)
            {
                StringBuilder result = new();
                foreach (var key in foobarList.Keys)
                {
                    if (i % key == 0)
                    {
                        result.Append(foobarList[key]);
                    }
                }
                if (result.Length == 0)
                {
                    result.Append(i);
                }
                Console.Write(result.ToString() + " ");
                // Boolean isDivisible = false;
                // foreach (var key in foobarList.Keys)
                // {
                //     if (i % key == 0)
                //     {
                //         result += foobarList[key] + ' ';
                //         isDivisible = true;
                //     }
                // }
                // if (!isDivisible)
                // {
                //     result += i.ToString() + ' ';
                // }
            }
            // Console.Write(result);
        }
    }
}