/*
string message = "merhaba";

// String tanımlama
Console.WriteLine("İlk mesaj: " + message);

// Immutable
string newMessage = message + " Dünya";

Console.WriteLine("Yeni mesaj: " + newMessage);
Console.WriteLine("Eski mesaj: " + message);

// İndeksler
Console.WriteLine("İlk karakter: " + message[0]);
Console.WriteLine("Son karakter: " + message[message.Length - 1]);

// Foreach döngüsü
Console.WriteLine("\nTüm karakterler:");

foreach (char c in message)
{
    Console.WriteLine(c);
}

// String özellikleri ve metotları
Console.WriteLine("Karakter sayısı: " + message.Length);
Console.WriteLine("Büyük harf: " + message.ToUpper());
Console.WriteLine("Dünya içeriyor mu? " + message.Contains("dünya"));
*/



/*
string text = "Backend";
 Console.WriteLine(text.Length);
 Console.WriteLine(text[0]);
 Console.WriteLine(text[6]);
 Console.WriteLine(text[text.Length -1]);   // fantezi kurbanı oldum burda
 Console.WriteLine(text.Contains("end"));
 Console.WriteLine(text.Contains("End"));
 Console.WriteLine(text.ToUpper());

 
 foreach (char c in text)
 {
    Console.WriteLine(c);
 }


string text = "Backend";   */

/*
// Karakter sayısı
Console.WriteLine($"Karakter sayısı: {text.Length}");

// İlk ve son karakter
Console.WriteLine($"İlk karakter: {text[0]}");
Console.WriteLine($"Son karakter: {text[text.Length - 1]}");

// Büyük harfe dönüştürme
Console.WriteLine($"Büyük harf: {text.ToUpper()}");

// Metin içerisinde arama
Console.WriteLine($"end içeriyor mu? {text.Contains("end")}");
Console.WriteLine($"End içeriyor mu? {text.Contains("End")}");

// Karakterleri alt alta yazdırma
Console.WriteLine("\nTüm karakterler:");

foreach (char c in text)
{
    Console.WriteLine(c);
}
*/




/*
Console.Write("Adınızı giriniz: ");
string? firstName = Console.ReadLine();

Console.Write("Soyadınızı giriniz: ");
string? lastName = Console.ReadLine();

// 1. + operatörü
string welcome1 =
    "Merhaba " + firstName + " " + lastName;

// 2. Concat
string welcome2 = string.Concat(
    "Sayın ",
    firstName,
    " ",
    lastName,
    ", sisteme hoş geldiniz."
);

// 3. String interpolation
string welcome3 =
    $"Hoş geldiniz {firstName} {lastName?.ToUpper()}";

// 4. Tarih biçimlendirme
string welcome4 =
    $"Giriş tarihi: {DateTime.Now:dd.MM.yyyy}";

Console.WriteLine("\n===== SONUÇLAR =====");
Console.WriteLine(welcome1);
Console.WriteLine(welcome2);
Console.WriteLine(welcome3);
Console.WriteLine(welcome4); */







/*
 // 1. Kaçış karakterleri
string report = "Log raporu:\n\t- kullanıcı: admin\n\t- işlem: yedekleme";

Console.WriteLine(report);

// 2. Normal string ile dosya yolu
string path1 = "C:\\users\\admin\\documents\\data.txt";

Console.WriteLine("\nNormal dosya yolu:");
Console.WriteLine(path1);

// 3. Verbatim string ile dosya yolu
string path2 = @"C:\users\admin\documents\data.txt";

Console.WriteLine("\nVerbatim dosya yolu:");
Console.WriteLine(path2);

// 4. Normal string ile JSON
string jsonEscaped = "{\"username\":\"admin\"}";

Console.WriteLine("\nJSON normal:");
Console.WriteLine(jsonEscaped);

// 5. Verbatim string ile JSON
string jsonVerbatim = @"{
    ""username"": ""admin"",
    ""status"": ""active""
}";

Console.WriteLine("\nJSON verbatim:");
Console.WriteLine(jsonVerbatim);    
*/


Random rnd = new Random();

string userCode = "";

// 1. ASCII ile A-Z karakterlerini göster
Console.WriteLine("ASCII KARAKTERLERİ (A-Z)");

for (int code = 65; code <= 90; code++)
{
    char letter = (char)code;

    Console.Write(letter + " ");
}

Console.WriteLine("\n");

// 2. Altı karakterli kullanıcı kodu oluştur
for (int i = 0; i < 6; i++)
{
    int ascii = rnd.Next(65, 91);

    char randomLetter = (char)ascii;

    userCode += randomLetter;
}

// 3. Sonucu göster
Console.WriteLine($"Oluşturulan kullanıcı kodu: {userCode}");

Console.WriteLine($"Kod uzunluğu: {userCode.Length}");

































