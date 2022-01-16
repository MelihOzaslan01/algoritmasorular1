Console.Write("Dizi Uzunluğu İçin İstediğiniz Bir Sayı Giriniz: ");
int diziLength = int.Parse(Console.ReadLine());
int[] dizi = new int[diziLength];
for (int i = 0; i < diziLength; i++)
{
    Console.Write("Lütfen {0}. sayı'yı giriniz :", i + 1);
    dizi[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < dizi.Length; i++)
{
    if (dizi[i] % 2 == 0)
    {
        Console.WriteLine("Çift Olan Sayı " + dizi[i]);

    }   
}
