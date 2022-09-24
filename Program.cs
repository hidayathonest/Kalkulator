using System;
class Kalkulator 
{
    static void Main(String[] args)
    {
        Console.WriteLine("=== KALKULATOR SEDERHANA ===");
        Console.WriteLine("Ketikkan perintah berikut untuk memilih operasi perhitungan");
        Console.WriteLine("1. Penjumlahan");
        Console.WriteLine("2. Pengurangan");
        Console.WriteLine("3. Perkalian");
        Console.WriteLine("4. Pembagian");

        double angka1 = 0;
        double angka2 = 0;
        double hasil = 0;

        Console.Write("Masukkan angka pertama!: ");
        angka1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Masukkan angka kedua!: ");
        angka2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Pilih operasi kalkulator!");
        string operasi = Console.ReadLine();

        if (operasi == "1")
        {
            hasil = angka1 + angka2;
            Console.WriteLine($"Hasilnya adalah : {hasil}");
        }
        
        if (operasi == "2")
        {
            hasil = angka1 - angka2;
            Console.WriteLine($"Hasilnya adalah : {hasil}");
        }

        if (operasi == "3")
        {
            hasil = angka1 * angka2;
            Console.WriteLine($"Hasilnya adalah : {hasil}");
        }
         
        if (operasi == "4")
        {
            hasil = angka1 / angka2;
            Console.WriteLine($"Hasilnya adalah : {hasil}");
        }
            
    }
}