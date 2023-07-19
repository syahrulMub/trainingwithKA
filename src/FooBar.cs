using System.Text;
using System.Collections.Generic;

namespace FooBarChangalle
{
    public class FooBar
    {
        SortedDictionary<int, string> fooBar = new SortedDictionary<int, string>();

        public SortedDictionary<int, string> FooBarData
        {
            get { return fooBar; }
            set { fooBar = value; }
        }

        public FooBar()
        {
            fooBar.Add(5, "Bar");
            fooBar.Add(3, "Foo");
        }

        public int GetInputUser()
        {
            Console.WriteLine("Masukkan Angka yang anda inginkan : ");
            int inputUser = Convert.ToInt32(Console.ReadLine());
            return inputUser;
        }

        //mengecek setiap key dalam dictionary 
        public string GetData(int input)
        {
            StringBuilder hasil = new();
            foreach (var key in fooBar.Keys)
            {
                if (input % key == 0)
                {
                    hasil.Append(fooBar[key]);
                }
            }
            if (hasil.Length == 0)
            {
                hasil.Append(input.ToString());
            }
            return hasil.ToString();
        }

        //menambah dictionary 
        public void AddData(int key, string value)
        {
            fooBar.TryAdd(key, value);
        }

        //menghapus input
        public void RemoveData(int key)
        {
            fooBar.Remove(key);
        }
    }
}
