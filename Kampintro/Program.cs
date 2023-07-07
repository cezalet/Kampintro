namespace Kampintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            String katagoriEtiketi = "Katagori";
            int ogrenciSayisi = 32000; //int : (+/-) tamsayılar
            double faizOrani = 1.45; //double : ondalıklı sayılar
            bool sistemeGirisYapmısMı=true;
            double dolarDun=7.35;
            double dolarBugun = 7.35;
            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }
            if (sistemeGirisYapmısMı==true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");                
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(katagoriEtiketi);
            Console.ReadKey();
        }
    }
}