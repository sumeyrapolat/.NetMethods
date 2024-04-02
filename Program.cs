using System;

class Program
{
    static void Main(string[] args)
    {
        // Test için örnekler
        int[] dizi = { 4, 2, 7, 1, 9, 3, 6, 5 };
        int[,] matris1 = { { 1, 2 }, { 3, 4 } };
        int[,] matris2 = { { 5, 6 }, { 7, 8 } };
        string metin = "Hello, world!";

        // Örnek method çağrıları
        Console.WriteLine($"Toplam: {Topla(5, 3)}");
        Console.WriteLine($"En büyük eleman: {EnBuyukEleman(dizi)}");
        Console.WriteLine($"Dizinin ortalaması: {DiziOrtalamasi(dizi)}");
        DiziSiralama(dizi);
        Console.WriteLine("Sıralanmış dizi: " + string.Join(", ", dizi));
        Console.WriteLine($"15 asal sayı mı: {AsalSayiMi(15)}");
        Console.WriteLine($"Ters çevrilmiş metin: {StringTersCevir(metin)}");
        Console.WriteLine($"Matris toplamı: ");
        Yazdir(MatrisToplama(matris1, matris2));
        Console.WriteLine($"Kelime sayısı: {KelimeSayisi(metin)}");
        Console.WriteLine($"Fibonacci(10): {Fibonacci(10)}");
        Console.WriteLine($"Ters çevrilmiş dizi: {string.Join(", ", DiziTersCevir(dizi))}");
    }

    // Methodlar
    static int Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    static int EnBuyukEleman(int[] dizi)
    {
        int max = dizi[0];
        foreach (int eleman in dizi)
        {
            if (eleman > max)
                max = eleman;
        }
        return max;
    }

    static double DiziOrtalamasi(int[] dizi)
    {
        int toplam = 0;
        foreach (int eleman in dizi)
        {
            toplam += eleman;
        }
        return (double)toplam / dizi.Length;
    }

    static void DiziSiralama(int[] dizi)
    {
        Array.Sort(dizi);
    }

    static bool AsalSayiMi(int sayi)
    {
        if (sayi <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(sayi); i++)
        {
            if (sayi % i == 0)
                return false;
        }
        return true;
    }

    static string StringTersCevir(string metin)
    {
        char[] karakterler = metin.ToCharArray();
        Array.Reverse(karakterler);
        return new string(karakterler);
    }

    static void Yazdir(int[,] matris)
    {
        int satirSayisi = matris.GetLength(0);
        int sutunSayisi = matris.GetLength(1);
        for (int i = 0; i < satirSayisi; i++)
        {
            for (int j = 0; j < sutunSayisi; j++)
            {
                Console.Write(matris[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[,] MatrisToplama(int[,] matris1, int[,] matris2)
    {
        int satirSayisi = matris1.GetLength(0);
        int sutunSayisi = matris1.GetLength(1);
        int[,] sonuc = new int[satirSayisi, sutunSayisi];
        for (int i = 0; i < satirSayisi; i++)
        {
            for (int j = 0; j < sutunSayisi; j++)
            {
                sonuc[i, j] = matris1[i, j] + matris2[i, j];
            }
        }
        return sonuc;
    }

    static int KelimeSayisi(string metin)
    {
        string[] kelimeler = metin.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return kelimeler.Length;
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int[] DiziTersCevir(int[] dizi)
    {
        int[] tersDizi = new int[dizi.Length];
        for (int i = 0; i < dizi.Length; i++)
        {
            tersDizi[i] = dizi[dizi.Length - 1 - i];
        }
        return tersDizi;
    }
}
