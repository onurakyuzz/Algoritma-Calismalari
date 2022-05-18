//Algoritma1();  //Girilen sayı hem 2 hem de 3 ile tam bölünebiliyorsa “OK”, aksi halde “HATA” mesajı veren program
//Algoritma2();  //Girilen sayı hem 2 ile hem de 3 ile tam bölünebiliyorsa “2 ve 3’ün katı”, sadece 2 ile bölünebiliyorsa “2’nin katı”, sadece 3 ile bölünebiliyorsa “3’ün katı”, ne 2’ye ne de 3’e bölünmüyorsa “2 veya 3’ün katı değil” mesajı veren program
//Algoritma3();  //Girilen sayı 0 ile 100 arasında ve çift ise “Sayı Uygun”, aksi halde “Sayı Uygun Değil” mesajı veren program
//Algoritma4(10, 5, 70);  //Girilen 3 sayıdan en az biri 50’den büyükse “Yeterli”, aksi halde “Yetersiz” mesajı veren program
//Algoritma5();  //Bir dizi tam sayıdan büyük olanı bulan algoritmayı yazınız.
// Algoritma6();  //20 elemanlı diziye rasgele -100 ile +100 arası sayılar atan ve daha sonra dizinin elemanlarını, pozitif sayı adetini,negatif sayı adetini ve işaretsiz sayı adetini ekranda gösteren programı yazınız.
// Algoritma7();  //Kullanıcının girmiş olduğu sayının dizide olup olmadığını bulan,varsa kaç adet bulunduğunu ekranda gösteren programı yazınız.
// Algoritma8();  //Kullanıcıdan alınan metnin içinde bulunan sesli harf sayısını bulan uygulamayı yazınız.
// Algoritma9();  // Klavyeden girilen bir Türkçe cümledeki sesli harflerin (cümlenin toplam karakter sayısına göre) yüzde oranlarını veren bir program yazınız.

/* int index = int.Parse(Console.ReadLine());                   // Recursive metot ile faktoriyel hesapla
   Console.WriteLine(index+"! = "+Algoritma10(index)); 
*/

/*                                                              // Recursive metot ile fibonacci hesapla
Console.Write("Bir sayı girin : ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Fibonacci(sayi-1));
*/


static void Algoritma1()
    {
    Console.Write("Sayı Giriniz:");
    var sayi1=Convert.ToInt32(Console.ReadLine());
    if (sayi1 % 2 == 0 && sayi1 % 3 == 0)
        Console.WriteLine("OK");
    else
        Console.WriteLine("HATA");

    }
static void Algoritma2() 
{
    int sayi2;
    Console.Write("Sayı Giriniz:");
    sayi2 = Convert.ToInt32(Console.ReadLine());
    if (sayi2 % 2 == 0 && sayi2 % 3 == 0)
        Console.WriteLine(sayi2+" sayısı hem 2'nin ve hem 3'ün katı");
    else if (sayi2%2==0 && !(sayi2 % 3 == 0))
        Console.WriteLine(sayi2+" sayısı 2'nin katı");
    else if (!(sayi2 % 2 == 0) && sayi2 % 3 == 0)
        Console.WriteLine(sayi2 + " sayısı 3'nin katı");
    else if (!(sayi2 % 2 == 0) && !(sayi2 % 3 == 0))
        Console.WriteLine(sayi2+" sayısı ne 2'nin ne de 3'ün katı değil");

}
static void Algoritma3()
{
    int sayi3;
    Console.Write("Sayı Giriniz:");
    sayi3 = Convert.ToInt32(Console.ReadLine());
    if ((sayi3 > 0 && sayi3 <= 100) && (sayi3 % 2 == 0))
        Console.WriteLine(sayi3 + " sayısı uygun");
    else
        Console.WriteLine(sayi3 + " sayısı uygun değil");
}

static void Algoritma4(int sayi4,int sayi5,int sayi6)
{
    if (sayi4>50||sayi5>50||sayi6>50)
        Console.WriteLine("Yeterli");
    else
        Console.WriteLine("Yetersiz");
}

static void Algoritma5()
{
    int[] dizi = {1,5,8,3,12,18,7 };
    
    //int maxValue = dizi.Max();

    int maxValue = dizi[0];

    for (int i = 1; i < dizi.Length; i++)
    {
        if (dizi[i]>maxValue)
        {
        maxValue = dizi[i];
        }
    }
    Console.WriteLine(maxValue);
}

static void Algoritma6()
{
    var negatif = 0;
    var pozitif = 0;
    var dizi = new int[20];
    var rand = new Random();
    Console.WriteLine("Elemanlar: ");
    for (int i = 0; i < dizi.Length; i++)
    {
        dizi[i] = rand.Next(-100, 101);
        Console.Write(dizi[i] + " ");
        if (dizi[i] < 0)
            negatif++;
        if (dizi[i] > 0)
            pozitif++;
    }
    Console.WriteLine("\nNegatif eleman sayısı =" + negatif);
    Console.WriteLine("Poziif eleman sayısı=" + pozitif);
}

static void Algoritma7() 
{
    int sayac = 0;
    int sayi;
    var  rnd = new Random();
    var array = new int[30];

    Console.Write("Dizide aramak istediğiniz sayıyı girin: ");
    sayi = Convert.ToInt32(Console.ReadLine());
    Console.Write("Oluşturulan Dizi :");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 30);
        Console.Write(array[i].ToString() + " ");
        if (sayi == array[i])
            sayac++;
    }
    if (sayac>0)
    Console.WriteLine("\n"+sayi+" sayısından "+sayac+" tane var");
    else
        Console.WriteLine("\n"+sayi +" sayısı dizide bulunmuyor");

}
static void Algoritma8() 
{
    Console.Write("Metin girin: ");
    string metin = Console.ReadLine();
    string sesliHarf = "aeıioöuü";

    int sayac = 0;
    for (int i = 0; i < metin.Length; i++)
    {
        
        if (sesliHarf.Contains(metin[i]))
        {
            sayac++;
        }
    }
    Console.WriteLine("Metinde " + sayac +" tane sesli harf bulunur");    
}
    
static void Algoritma9() 
{
    Console.Write("Metin girin: ");
    string metin = Console.ReadLine();
    string sesliHarf = "aeıioöuü";
    float metinLenght = metin.Length;
    float sayac = 0;
    for (int i = 0; i < metin.Length; i++)
    {
   
        if (sesliHarf.Contains(metin[i]))
        {
            sayac++;
        }
    }
    
    float ratio= 100*(sayac/metinLenght);
    Console.WriteLine("Metindeki sesli harflaerin yüzdesel oranı: %"+ratio);
}

static int Algoritma10(int sayi ) 
{
    if(sayi<=1)
    {
        return 1;
    }
    return sayi * Algoritma10(sayi - 1);
}

static int Fibonacci(int sayi)
{
    if (sayi == 0)
        return 0;

    else if (sayi == 1)
        return 1;

    return   Fibonacci(sayi - 2)+Fibonacci(sayi - 1);

}






