class Program
{
    static void Main(string[] args)
    {
        int i;
        for (i = 0; i <= 10; i++)
        {
            if (i == 5)
                continue;
            if (i == 8)
                break;
            Console.WriteLine("Value is " + i);
        }
        Console.ReadLine();
    }
}


