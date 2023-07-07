namespace Matematik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Topla(15, 61);
            dortIslem.Topla(8, 32);

            Console.WriteLine("Hello, World!");
        }
    }
}