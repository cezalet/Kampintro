namespace Donguler
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Kampı", "Programlama Başlangıç Kursu", "Java Kursu","python","C++" };
            for (int i = 0; i < kurslar.Length; i++) //kurslar.length : kurslar dizisinin eleman sayısı
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For Bitti");
            //foreach i genellikle diziler için kullanıyoruz.
            foreach (string kurs in kurslar) //Kurslar'ı dolaş, Kurslar dizisinin elemanlarını sırası ile kurs a at
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}