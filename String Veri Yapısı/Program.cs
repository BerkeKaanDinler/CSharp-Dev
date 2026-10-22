// string tanımlama
string message = "merhaba";
Console.WriteLine("ilk mesaj : " + message);

// immutable
string newMessage= message + " Dünya"; 
Console.WriteLine("yeni mesaj : " + newMessage);
Console.WriteLine("eski mesaj : " + message);


// dizi benzer işlemler

Console.WriteLine("ilk karakter: "  + message[0]);
Console.WriteLine("ilk karakter: " + message[message.Length-1]);

// döngüler
Console.WriteLine("\n tüm karakterler");

foreach (char c in message)
{
    Console.WriteLine(c);
}

// string metodları

Console.WriteLine("karakter sayısı : " + message.Length);
Console.WriteLine("büyük harf : " + message.ToUpper());
Console.WriteLine("dünya içeriyor mu? " + message.Contains("dünya"));

Console.ReadKey();