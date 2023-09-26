using System;

class Laptop
{
    public string merk;
    public string tipe;
    public Vga vga;
    public Processor processor;

    public void LaptopDinyalakan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
{
    public ASUS()
    {
        merk = "ASUS";
    }
}

class ROG : ASUS
{
    public ROG()
    {
        tipe = "ROG";
    }
}
class Vivobook : ASUS
{
    public Vivobook()
    {
        tipe = "Vivobook";
    }
    public void Ngoding()
    {
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
    }
}
class ACER : Laptop
{
    public ACER()
    {
        merk = "ACER";
    }
}
class Swift : ACER
{
    public Swift()
    {
        tipe = "Swift";
    }
}
class Predator : ACER
{
    public Predator()
    {
        tipe = "Predator";
    }
    public void BermainGame()
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
{
    public Lenovo()
    {
        merk = "Lenovo";
    }
}

class IdeaPad : Lenovo
{
    public IdeaPad()
    {
        tipe = "IdeaPad";
    }
}
class Legion : Lenovo
{
    public Legion()
    {
        tipe = "Legion";
    }
}
class Vga
{
    public string merk;
}
class Nvidia : Vga
{
    public Nvidia()
    {
        merk = "Nvidia";
    }
}
class Amd : Vga
{
    public Amd()
    {
        merk = "AMD";
    }
}
class Processor
{
    public string merk;
    public string tipe;
}
class Intel : Processor
{
    public Intel()
    {
        merk = "Intel";
    }
}
class CoreI3 : Intel
{
    public CoreI3()
    {
        tipe = "Core i3";
    }
}
class CoreI5 : Intel
{
    public CoreI5()
    {
        tipe = "Core i5";
    }
}
class CoreI7 : Intel
{
    public CoreI7()
    {
        tipe = "Core i7";
    }
}
class AMD : Processor
{
    public AMD()
    {
        merk = "AMD";
    }
}
class Ryzen : AMD
{
    public Ryzen()
    {
        tipe = "RAYZEN";
    }
}
class Athlon : AMD
{
    public Athlon()
    {
        tipe = "ATHLON";
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Laptop laptop1 = new Vivobook();
        laptop1.vga = new Nvidia();
        laptop1.processor = new CoreI5();
        // laptop1.Ngoding();
        // error karena di class induk/ class laptop tidak memiliki method Ngoding()

        Laptop laptop2 = new IdeaPad();
        laptop2.vga = new Amd();
        laptop2.processor = new Ryzen();
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        Predator predator = new Predator();
        predator.vga = new Amd();
        predator.processor = new CoreI7();
        predator.BermainGame();

        //ACER acer = new Predator();
        //acer.BermainGame(); error karena acer adalah class dari laptop yang tidak memiliki method BermainGame().
    }
}