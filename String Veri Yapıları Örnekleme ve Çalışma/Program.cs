
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
