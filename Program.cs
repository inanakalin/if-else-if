internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour;

        if(time>=21 && time<24)
        Console.WriteLine("İyi uykular");

        else if(time<=18)
        Console.WriteLine("iyi Günler");

        else
        Console.WriteLine("iyi Geceler");

        string sonuc = time<18 ? "İyi Günler" : "İyi Geceler";

        sonuc = time>=21 && time<=24 ? "İyi Uykular" : time<18 ? "İyi Günler" : "İyi Geceler";
        Console.WriteLine(sonuc);



    }
}