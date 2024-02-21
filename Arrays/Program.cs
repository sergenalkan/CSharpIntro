internal class Program
{
    private static void Main(string[] args)
    {
        //string student1 = "Engin";
        //string student2 = "Derin";
        //string student3 = "Salih";

        string[] students = new string[3];
        students[0] = "Engin";
        students[1] = "Derin";
        students[2] = "Salih";

        //Bunlar farklı kullanım, aynı tipteki verileri arraylar bir arada tutabilir
        //Array sınırı aşılamaz, temp ile yapabilrsin ama zahmetli. En iyisi collections kullanmak
        string[] students4 = new string[3] { "E", "A", "S" };
        string[] students2 = new[] { "E", "A", "S" };
        string[] students3 = { "E", "A", "S" };
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        string[,] regions = new string[7, 3]
        {
            {"İstanbul", "Kocaeli", "Tekirdağ" },
            {"Ankara", "Konya", "Sivas" },
            {"Adana", "Mersin", "Antalya" },
            {"Artvin", "Trabzon", "Samsun" },
            {"Gaziantep", "Şanlıurfa", "Mardin" },
            {"İzmir", "Denizli", "Muğla" },
            {"Erzurum", "Van", "Kars" },
        };

        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("*********");
        }
        //regions[0,0] = "İstanbul";
        Console.WriteLine();
        Console.ReadLine();
    }
}