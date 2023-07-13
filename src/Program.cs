class Program
{    
    static void Main(string[] args) 
    {
        Console.WriteLine("hallo kang!!!!");
        Print("Hallo juga");
        Print("error kah?");
        Print("ini adalah push");
        Print("apakah teori error itu nyata");
        Print(100);
        Print(0.75);
        Print(true);
    }
    
    static void Print<T>(T data)
    {
        Console.WriteLine(data);
    }
}
