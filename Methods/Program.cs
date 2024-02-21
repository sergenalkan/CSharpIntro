internal class Program
{
    private static void Main(string[] args)
    {
        //Add();
        //Add();
        //var result = Add2();

        //int n1 = 20;
        //int n2 = 40;
        //var result2 = Add3(ref n1, n2);
        //Console.WriteLine(result2);
        //Console.WriteLine(n1);
        Console.WriteLine(Multiply(2, 4));
        Console.WriteLine(Multiply(2, 4, 5));

        Console.WriteLine(Add4(2, 4, 6, 7, 8));
        Console.ReadLine();
    }


    static void Add()
    {
        Console.WriteLine("Added!");
    }
    //default değer her zaman en sonda olması lazım, baştakinde olmaz.
    //Her ikisi de default olabilir.
    static int Add2(int n1 = 20, int n2 = 30)
    {
        var result = n1 + n2;
        return result;
    }
    //ref keywordü değer tiplerini referans tipleri gibi kullanılır
    //ref kullanırsan yukarda n1 tanımlamak zorunlu, out ise zorunlu değil
    //out ise metod içinde bir kere set edilmesi zorunlu, ref böyle bir zorunluluk yok 

    static int Add3(ref int n1, int n2)
    {
        n1 = 30;
        return n1 + n2;
    }

    static int Multiply(int n1, int n2)
    {
        return n1 * n2;
    }
    //metodlarda overloading yani aşırı yüklenmesi
    //aynı isimler ek özellikle oluyor
    static int Multiply(int n1, int n2, int n3)
    {
        return n1 * n2 * n3;
    }

    //params ile metoda istediğin kadar sayı eklersin
    //paramstan önce değişken tanımlanır ancak sonasında tanımlanmaz. Son değişken params olmalı
    static int Add4(params int[] numbers)
    {
        return numbers.Sum();
    }
}