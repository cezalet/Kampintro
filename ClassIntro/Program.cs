namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Zeynep Karatekin";
            kurs2.IzlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Zehra Karatekin";
            kurs3.IzlenmeOrani = 90;

            Kurs[] kurslar= new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (Kurs sınıf in kurslar)
            {
                Console.WriteLine(sınıf.KursAdi + " : " + sınıf.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}