// string tanımlama
/*
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

Console.ReadKey();    */





// OTP

// ASCII 65 - 90 (A-Z)
/*
Random rnd = new Random();
string userCode = "";

Console.WriteLine("ASCII KARAKTERİ (A-Z)");

for (int code =65 ; code <= 90; code++)
{
    char letter = (char)code;
    Console.Write(letter + " ");
}


Console.WriteLine("\n");
// 6 haneli kullanıcı kodu

for (int i = 0; i < 6; i++)
{
    int ascii = rnd.Next(65,91); // 65 90 arası rastgele sayı
    char randomLetter = (char)ascii;
    userCode+=randomLetter; // stringleri birleştiriyorum
}

Console.WriteLine($"oluşturulan kullanıcı kodu : {userCode}");


Console.ReadKey();   */









Console.WriteLine("adınızı giriniz");
string firstName = Console.ReadLine();

Console.WriteLine("soyadınızı giriniz: ");
string lastName = Console.ReadLine();

// + operatörü
string welcome1 = "merhaba " + firstName + " " + lastName + " , sisteme hoş geldiniz.";

// Concat
string welcome2 = String.Concat("Sayın " , firstName, " ", lastName, " , girişinizi başarı ile gerçekleştirdiniz.");


// interpolasyon

string welcome3 = $"hoş geldiniz {firstName} {lastName?.ToUpper()} {DateTime.Now:dd.MM.yyyy}";

Console.WriteLine(welcome1);
Console.WriteLine(welcome2);
Console.WriteLine(welcome3);

Console.ReadKey();







