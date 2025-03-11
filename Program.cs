using modul4;

class Program
{
    static void Main (string [] args) 
    {
        KodeProduk kodeProduk = new KodeProduk();
        int i = 0;

        Console.WriteLine(
            $"Kode laptop = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.LAPTOP)} \n" +
            $"Kode printer = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.PRINTER)} \n" +
            $"Kode Kamera = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.KAMERA)} \n" +
            $"Kode Mouse = {kodeProduk.GetKodeProduk(KodeProduk.produkElektronik.MOUSE)}");

    }
}

