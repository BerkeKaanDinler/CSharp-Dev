// list.Count	Öğe sayısını verir
// list.Add(value)	Listenin sonuna öğe ekler
// list.Remove(value)	İlk eşleşen öğeyi kaldırır
// list[i] = value	i dizinindeki öğenin üzerine yazar
// list.RemoveAt(i)	Dizindeki öğeyi kaldırır i
// list.Sort()	Listeyi yerinde sıralar küçükten büyüğe

// allScores.Reverse(); -> Listenin mevcut eleman sırasını tamamen tersine çevirir. Tek başına bir büyüklük sıralaması yapmaz, sadece listenin başını sonu, sonunu başı yapar.





// Set up the game
/*
Random random = new Random();
int roundsPlayed = 8;

List<int> allScores = new List<int>();

Console.WriteLine($"Playing {roundsPlayed} rounds...\n");


 // Simulate playing rounds and log every score

 for (int round = 1; round <= roundsPlayed; round++)
{
    int score = random.Next(0, 101);
    allScores.Add(score);
    Console.WriteLine($"Round {round}: scored {score} points");

}
Console.WriteLine($"\nTotal rounds logged: {allScores.Count}");

 // Build the Top 5 leaderboard array
allScores.Sort();
allScores.Reverse();

int[] topScores = new int [5];

for (int i = 0; i < topScores.Length; i++)
{
    topScores[i] = allScores[i];

}


 // Print the leaderboard

  Console.WriteLine("\n🏆 Top 5 Leaderboard 🏆");

  for (int i = 0; i < topScores.Length; i++)
 {
     Console.WriteLine($"{i + 1}. {topScores[i]} points");
 }




List<string> shoppingList = new List<string>();

for (int i = 1; i <= 3; i++)
{
    Console.Write($"{i}. ürünü giriniz: ");

    string product = Console.ReadLine() ?? "";

    shoppingList.Add(product);
}

Console.WriteLine("\nAlışveriş listeniz:");

foreach (string product in shoppingList)
{
    Console.WriteLine(product);
}

Console.WriteLine($"Toplam ürün: {shoppingList.Count}");






List<int> scores = new List<int>
{
    45, 90, 20, 75, 100, 60
};

scores.Sort();
scores.Reverse();

int count = Math.Min(3, scores.Count);

Console.WriteLine("En yüksek 3 puan:");

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{i + 1}. {scores[i],3} puan");      
}   */






/*
// benim yaptığım:

int[] notHesaplama = new int[5];
int basariliCount = 0;
int basarisizCount = 0;

Console.WriteLine("===== ÖĞRENCİ NOT ANALİZİ =====");

for (int i = 0; i < notHesaplama.Length; i++)
{
    Console.Write($"{i + 1}. öğrencinin notunu giriniz: ");
    int not = Convert.ToInt32(Console.ReadLine());
    notHesaplama[i] = not;

    if (not >= 50)
    {
        basariliCount++;
    }
    else
    {
        basarisizCount++;
    }
}

int toplamNot = 0;
foreach (int not in notHesaplama)
{
    toplamNot += not;
}

double ortalama = (double)toplamNot / notHesaplama.Length;
Console.WriteLine($"Başarılı öğrenci sayısı: {basariliCount}");
Console.WriteLine($"Başarısız öğrenci sayısı: {basarisizCount}");
Console.WriteLine($"Not ortalaması: {ortalama:F2}");








// olması gereken:

int[] notHesaplama = new int[5];

int basariliCount = 0;
int basarisizCount = 0;
int toplamNot = 0;

Console.WriteLine("===== ÖĞRENCİ NOT ANALİZİ =====");

// 1. Öğrencilerin notlarını al
for (int i = 0; i < notHesaplama.Length; i++)
{
    int not;

    // Geçerli bir not girilene kadar tekrar sor
    while (true)
    {
        Console.Write($"{i + 1}. öğrencinin notunu giriniz: ");

        if (int.TryParse(Console.ReadLine(), out not)
            && not >= 0 && not <= 100)
        {
            break;
        }

        Console.WriteLine("Hatalı giriş! 0 ile 100 arasında bir sayı giriniz.");
    }

    notHesaplama[i] = not;
}

// 2. En yüksek ve en düşük notun başlangıç değerleri
int enYuksekNot = notHesaplama[0];
int enDusukNot = notHesaplama[0];

// 3. Dizideki notları analiz et
foreach (int not in notHesaplama)
{
    // Toplam not
    toplamNot += not;

    // Başarılı / başarısız öğrenci sayısı
    if (not >= 50)
    {
        basariliCount++;
    }
    else
    {
        basarisizCount++;
    }

    // En yüksek not
    if (not > enYuksekNot)
    {
        enYuksekNot = not;
    }

    // En düşük not
    if (not < enDusukNot)
    {
        enDusukNot = not;
    }
}

// 4. Ortalama hesapla
double ortalama = (double)toplamNot / notHesaplama.Length;

// 5. Sonuçları göster
Console.WriteLine("\n===== SONUÇLAR =====");

Console.WriteLine($"Toplam not: {toplamNot}");
Console.WriteLine($"Not ortalaması: {ortalama:F1}");
Console.WriteLine($"Başarılı öğrenci sayısı: {basariliCount}");
Console.WriteLine($"Başarısız öğrenci sayısı: {basarisizCount}");
Console.WriteLine($"En yüksek not: {enYuksekNot}");
Console.WriteLine($"En düşük not: {enDusukNot}");     */



// kısa alıştırma:
/*
int[] notlar = new int[4];
notlar[0] = 75;
notlar[1] = 60;
notlar[2] = 95;
notlar[3] = 40;

Console.WriteLine($"İkinci not: {notlar[1]}");
Console.WriteLine($"dördüncü not: {notlar[3]}");
Console.WriteLine($"toplam öğrenci sayısı: {notlar.Length}");    */


int[] numbers = new int[4];

// 1. for döngüsü

for (int i = 0; i< numbers.Length; i++)
{
    Console.Write($"{i + 1}. sayıyı giriniz: ");
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}




// 2. for döngüsü
 Console.WriteLine("kaydedilen sayılar:");

for (int i = 0; i< numbers.Length;i++)
{
    
    Console.WriteLine($"{i + 1}. sayı: {numbers[i]}");
}
// Dizideki sayıları sırayla ekrana yazdır.







int[] notlar = new int[5];

Console.WriteLine("===== ÖĞRENCİ NOT KAYIT SİSTEMİ =====");

// 1. Öğrencilerin notlarını al
for (int i = 0; i < notlar.Length; i++)
{
    int not;

    // Geçerli not girilene kadar tekrar sor
    while (true)
    {
        Console.Write($"{i + 1}. öğrencinin notunu giriniz: ");

        bool sonuc = int.TryParse(Console.ReadLine(), out not);

        if (sonuc && not >= 0 && not <= 100)
        {
            break;
        }

        Console.WriteLine("Hatalı giriş! 0-100 arasında bir sayı giriniz.");
    }

    // Geçerli notu diziye kaydet
    notlar[i] = not;
}

// 2. Kaydedilen notları ekrana yazdır
Console.WriteLine("\n===== KAYDEDİLEN NOTLAR =====");

foreach (int not in notlar)
{
    Console.WriteLine(not);
}









int[] notlar = new int[5];

int toplamNot = 0;
int basariliCount = 0;
int basarisizCount = 0;

Console.WriteLine("===== ÖĞRENCİ NOT ANALİZ SİSTEMİ =====");

// 1. Öğrencilerin notlarını güvenli şekilde al
for (int i = 0; i < notlar.Length; i++)
{
    int not;

    while (true)
    {
        Console.Write($"{i + 1}. öğrencinin notunu giriniz: ");

        bool sonuc = int.TryParse(Console.ReadLine(), out not);

        if (sonuc && not >= 0 && not <= 100)
        {
            break;
        }

        Console.WriteLine("Hatalı giriş! 0-100 arasında bir sayı giriniz.");
    }

    notlar[i] = not;
}

// 2. En yüksek ve en düşük notu belirlemek için
// ilk öğrencinin notunu başlangıç kabul et
int enYuksekNot = notlar[0];
int enDusukNot = notlar[0];

// 3. Bütün notları analiz et
foreach (int not in notlar)
{
    toplamNot += not;

    if (not >= 50)
    {
        basariliCount++;
    }
    else
    {
        basarisizCount++;
    }

    if (not > enYuksekNot)
    {
        enYuksekNot = not;
    }

    if (not < enDusukNot)
    {
        enDusukNot = not;
    }
}

// 4. Ortalamayı hesapla
double ortalama = (double)toplamNot / notlar.Length;

// 5. Sonuçları ekrana yazdır
Console.WriteLine("\n===== ANALİZ SONUÇLARI =====");

Console.WriteLine($"Toplam not: {toplamNot}");
Console.WriteLine($"Not ortalaması: {ortalama:F1}");
Console.WriteLine($"Başarılı öğrenci: {basariliCount}");
Console.WriteLine($"Başarısız öğrenci: {basarisizCount}");
Console.WriteLine($"En yüksek not: {enYuksekNot}");
Console.WriteLine($"En düşük not: {enDusukNot}");
