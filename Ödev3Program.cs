Console.Write(" Bir Sayı Giriniz: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n + " Adet Kelime Giriniz");
string[] kelimeler = new string[n];
for (int i = 0; i < kelimeler.Length; i++)
{
    Console.Write("Lütfen {0}. Kelimeyi Giriniz : ", i + 1);
    kelimeler[i] = Console.ReadLine();
}

Array.Reverse(kelimeler);
foreach (var item in kelimeler)
{
    Console.WriteLine(item);
}






