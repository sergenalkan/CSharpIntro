internal class Program
{
    private static void Main(string[] args)
    {
        //Value Types
        //Console.WriteLine("Hello World!");
        string days = "Mondays";
        double number5 = 10.4;
        decimal number6 = 10.4m;
        char character = 'A';
        string city = "Ankara";
        bool condition = false;
        byte number4 = 255;//0-255 arasında veri tutar 8 bittir
        short number3 = -32768; //-32768 ile 32767 arasında
        int number1 = 2147483647; //2147483647 -2147483648 değerleri arasında
        long number2 = 9223372036854775807;  //9223372036854775807 -9223372036854775808
                                             //int 32 bit yer kaplar long 64 bit
        var number7 = 10;
        number7 = 'A';
        //number7 = "A"; A bir string ve atayamazsın ama üstte sadece asci değerini aldı
        Console.WriteLine("Number1 is {0}", number1);
        Console.WriteLine("Number2 is {0}", number2);
        Console.WriteLine("Number3 is {0}", number3);
        Console.WriteLine("Number4 is {0}", number4);
        Console.WriteLine("Number5 is {0}", number5);
        Console.WriteLine("Number7 is {0}", number7);
        Console.WriteLine("Character is : {0}", (int)character);
        Console.WriteLine((int)Days.Friday);

        Console.ReadLine();
    }
    enum Days
    {
        Monday = 10, Tuesday = 20, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}