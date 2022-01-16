Console.WriteLine("İki Adet Sayı Giriniz ");
int s1, s2;
Console.Write("1. Sayıyı Giriniz : ");
s1 = Convert.ToInt32(Console.ReadLine());

Console.Write("2. Sayıyı Giriniz : ");
s2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(s1 + " Adet Sayı Giriniz ");
int[] dizi = new int[s1];
for (int i = 0; i < s1; i++)
{
    Console.Write("Lütfen {0}. sayıyı giriniz :", i + 1);
    dizi[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < dizi.Length; i++)
{
    if (dizi[i] == s2)
    {
        Console.WriteLine("2. Değere Eşit Sayılar " + dizi[i]);

    }
    else if (dizi[i] % s2 == 0)
    {
        Console.WriteLine("2. Değere Tam Bölünenler " + dizi[i]);
    }
    else
    {
        Console.WriteLine("Değer Hiçbir Koşulu Karşılamamaktadır.");
    }
}











