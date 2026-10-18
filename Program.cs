
/*
for (int i =2; i<=20; i+=2)
{
    Console.WriteLine(i);
} */



/* int sayi = 15;

while (sayi >=1)
{
    Console.WriteLine(sayi);
    sayi -= 2;

if (sayi == 5)
    {
        Console.WriteLine("sayı 5 e eşit oldu döngüden çıkılıyor");
        break;
    }

}    */

/*
int number = 2;
int total = 0;
while (number <= 20)
{
    total += number;
    number += 2;
}
Console.WriteLine($"çift sayıların toplamı : {total}");  */



/*
int number;
int total = 0;

do
{
    Console.WriteLine("lütfen bir sayı giriniz:");
    number = Convert.ToInt32(Console.ReadLine());
    total += number;
}
while (number !=0);

Console.WriteLine($"girdiğiniz sayıların toplamı : {total}");   */



/* int çiftCount = 0;
int tekCount = 0;

for (int i = 1; i <= 5; i++)
{
Console.WriteLine("litfen bir sayı giriniz:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
çiftCount++;
}
else
{
tekCount++;
}

}
Console.WriteLine($"Girdiğiniz sayıların çift sayısı: {çiftCount}");
Console.WriteLine($"Girdiğiniz sayıların tek sayısı: {tekCount}");    */



 /* int total = 0;
int succesfulCount = 0;
int failedCount = 0;


for (int i = 1; i <=5; i++)
{
    
    Console.WriteLine($"{i}. öğrencinin notunu giriniz:");
    int grade = Convert.ToInt32(Console.ReadLine());
    total += grade;
    
    
    if (grade >= 50)
    {
        succesfulCount++;
    }
    else
    {
        failedCount++;
    }


    
}
double average = total / 5.0;
Console.WriteLine($"Girdiğiniz notların ortalaması: {average}");
Console.WriteLine($"Başarılı öğrenci sayısı: {succesfulCount}");
Console.WriteLine($"Başarısız öğrenci sayısı: {failedCount}");     */



/* int total = 0;
int grade = 0;

for (int i = 1; i <= 3; i++)
{
    Console.Write($"{i}. öğrencinin notu: ");
    grade = Convert.ToInt32(Console.ReadLine());

    total += grade;
}

double average = total / 3.0;

Console.WriteLine($"Toplam: {total}");
Console.WriteLine($"Ortalama: {average}");
Console.WriteLine($"Son not: {grade}");   */




/* int number;

do 
{
    Console.WriteLine("Lütfen bir sayı giriniz:");
    number = Convert.ToInt32(Console.ReadLine());

} while (number != 7);

Console.WriteLine("Tebrikler! Doğru sayıyı buldunuz.");  */


 /* int total = 0;

for (int i = 1; i <= 10; i++)
{
    total += i;
}
Console.WriteLine($" 1 den 10 a kadar olan sayıların toplamı: {total}");  */









 /* int maxNumber = 0;

for (int i = 1; i <=5; i++)
{
    Console.WriteLine($"{i}. sayıyı giriniz:");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number > maxNumber)
    {
        maxNumber = number;
    
    }
    
}

Console.WriteLine($"Girdiğiniz sayıların en büyüğü: {maxNumber}");   */




  /* Console.Write("1. sayıyı giriniz: ");
int minNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= 5; i++)
{
    Console.Write($"{i}. sayıyı giriniz: ");
    int number = Convert.ToInt32(Console.ReadLine());

    // Yeni sayı minNumber'dan küçük mü?
    if (number < minNumber)
    {
        minNumber = number;
    }
    // Küçükse minNumber'ı güncelle.
}
Console.WriteLine($"girdiğiniz en küçük sayı : {minNumber}");
// En küçük sayıyı ekrana yazdır.  */








 /* int choice;

do
{
    Console.WriteLine("\n===== SAYI ANALİZ PROGRAMI =====");
    Console.WriteLine("1 - Sayıların toplamını hesapla");
    Console.WriteLine("2 - En büyük sayıyı bul");
    Console.WriteLine("3 - En küçük sayıyı bul");
    Console.WriteLine("0 - Çıkış");

    Console.Write("Seçiminiz: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            int total = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}. sayıyı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());

                total += number;
            }

            Console.WriteLine($"Toplam: {total}");
            break;

        case 2:
            Console.Write("1. sayıyı giriniz: ");
            int maxNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 5; i++)
            {
                Console.Write($"{i}. sayıyı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }

            Console.WriteLine($"En büyük sayı: {maxNumber}");
            break;

        case 3:
            Console.Write("1. sayıyı giriniz: ");
            int minNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 5; i++)
            {
                Console.Write($"{i}. sayıyı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < minNumber)
                {
                    minNumber = number;
                }
            }

            Console.WriteLine($"En küçük sayı: {minNumber}");
            break;

        case 0:
            Console.WriteLine("Program kapatılıyor...");
            break;

        default:
            Console.WriteLine("Geçersiz seçim!");
            break;
    }

} while (choice != 0);    */








int choice;

do
{
    Console.WriteLine("\n---- Sayı analiz programı -----");
    Console.WriteLine("1 -- sayıların toplamını hesapla");
    Console.WriteLine("2 - en büyük sayıların toplamını hesapla");
    Console.WriteLine("3 - en küçük sayıyı bul");
    Console.WriteLine("0 - çıkış");

    Console.WriteLine("seçiminiz :");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
           int total = 0;

           for (int i = 1; i<=5; i++)
            {
            Console.WriteLine($"{i}. sayıyı giriniz");
            int number = Convert.ToInt32(Console.ReadLine());
             
             total += number;
        
            } 
            Console.WriteLine($"Toplam: {total}");
            break;

            case 2:
                 Console.WriteLine("1. sayıyı giriniz: ");
                 int maxNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i<=5; i++)
            {
                Console.WriteLine($"{i}. sayıyı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > maxNumber)
                {
                    maxNumber = number;

                }

            }
            Console.WriteLine($"en büyük sayı: {maxNumber}");
            break;

            case 3:
            Console.WriteLine("1. sayıyı giriniz:" );
            int minNumber = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= 5; i++)

            {
                Console.WriteLine($"{i}. sayıyı giriniz: ");
                int number = Convert.ToInt32(Console.ReadLine());
                 
                 if (number < minNumber)
                {
                    minNumber = number;
                }

            }
            Console.WriteLine($"En küçük sayı: {minNumber}");
            break;

            case 0:
            Console.WriteLine("Program kapatılıyor....");
            break;

            default: 
            Console.WriteLine("Geçersiz seçim!");
            break;
    }



} while(choice != 0);

















