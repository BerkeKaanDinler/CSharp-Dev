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
Console.WriteLine(welcome4);




















