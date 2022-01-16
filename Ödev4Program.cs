int harfsayisi = 0;
string cumle;
Console.Write("Cümleyi Girin : ");
cumle = Console.ReadLine();
string[] kelimeler = cumle.Split(' ');
Console.WriteLine("Toplam Kelime Sayısı: " + kelimeler.Length);
for (int i = 0; i < kelimeler.Length; i++)
{
    char[] harf = kelimeler[i].ToCharArray();
    harfsayisi += kelimeler[i].Length;
}

Console.WriteLine("Toplam Harf Sayısı: " + harfsayisi);
Console.ReadKey();
