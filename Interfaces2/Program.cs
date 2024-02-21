﻿internal class Program
{
    private static void Main(string[] args)
    {
        //IPersonManager customerManager = new CustomerManager();

        //IPersonManager employeeManager = new EmployeeManager();
       
        ProjectManager projectManager = new ProjectManager();
        
        projectManager.Add(new InternManager());
    }
}
interface IPersonManager
{
    //unimplemented operation
    void Add();
    void Update();
}
//inherits - class ------------------ implements - interface
class CustomerManager : IPersonManager
{
    public void Add()
    {
        //Müşteri ekleme kodları
        Console.WriteLine("Müşteri eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Müşteri güncellendi");
    }
}
class EmployeeManager : IPersonManager
{
    public void Add()
    {
        //Personel ekleme kodları
        Console.WriteLine("Personel eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Personel güncellendi");
    }
}
class InternManager : IPersonManager
{
    public void Add()
    {
        Console.WriteLine("Stajyer eklendi");
    }

    public void Update()
    {
        Console.WriteLine("Stajyer güncellendi");
    }
}
class ProjectManager
{
    public void Add(IPersonManager personManager)
    {
        personManager.Add();
    }
}