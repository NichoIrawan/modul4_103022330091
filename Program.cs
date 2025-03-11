using modul4;

class Program
{
    static void Main(string[] args)
    {
        //Kode Produk
        KodeProduk kodeProduk = new KodeProduk();
        int i = 0;

        Console.WriteLine(
            $"Kode laptop = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.LAPTOP)} \n" +
            $"Kode printer = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.PRINTER)} \n" +
            $"Kode Kamera = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.KAMERA)} \n" +
            $"Kode Mouse = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.MOUSE)}"
            );
        Console.WriteLine("\n");

        //Fan State
        FanLaptop fanLaptop = new FanLaptop();

        Console.WriteLine("Mode up demo");
        fanLaptop.modeUp();
        fanLaptop.modeUp();
        fanLaptop.modeUp();

        Console.WriteLine("\nMode down demo");
        fanLaptop.modeDown();
        fanLaptop.modeDown();
        fanLaptop.modeDown();

        Console.WriteLine("\nTurbo shorcut demo");
        fanLaptop.turboShorcut();
        fanLaptop.turboShorcut();
    }
}

