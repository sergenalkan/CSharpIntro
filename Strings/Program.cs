internal class Program
{
    private static void Main(string[] args)
    {
        //Intro(); 
        string sentence = "My name is Engin Demiroğ";

        var result = sentence.Length;
        var result2 = sentence.Clone();//referans almıyor yeni değişken oluşturuyor
        sentence = "My name is Derin Demiroğ";
        bool result3 = sentence.EndsWith("ğ");
        bool result4 = sentence.StartsWith("My name");
        //name kaçıncı karakterden başlıyor
        //dizi dışına çıkarsa -1 verir
        var result5 = sentence.IndexOf("name");
        var result6 = sentence.IndexOf(" ");
        //sondan sayarak ilk boşluğu bul
        var result7 = sentence.LastIndexOf(" ");
        //0. karakterden itibaren ekle
        var result8 = sentence.Insert(0, "Hello ");
        //ilk 3 karakterden sonrasını yaz veya  3. karaketerden itibaren 4 tane al(3,4)
        var result9 = sentence.Substring(3);
        //hepsini büyük veya küçük harf yap. .ToUpper()
        var result10 = sentence.ToLower();
        //boşluklar yerine - koy
        var result11 = sentence.Replace(" ", "-");
        //2den itibaren hepsini kaldır. (2,4): ikiden itibaren 4 tanesini kaldır
        var result12 = sentence.Remove(2, 8);
        Console.WriteLine(result12);
        Console.ReadLine();
    }

    private static void Intro()
    {
        string city = "Ankara";
        // Console.WriteLine(city[0]);

        foreach (var item in city)
        {
            Console.WriteLine(item);
        }

        string city2 = "İstanbul";
        Console.WriteLine(String.Format("{0} {1}", city, city2));

    }
}