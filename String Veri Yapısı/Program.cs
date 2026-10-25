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








/*
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

*/




/*

// kaçış karakterleri 
string report = "Log raporu:\n\t- kullanıcı: admin\n\t- işlem : yedekleme";
Console.WriteLine(report);


// dosya yolları
string path1 = "C:\\users\\admin\\documents\\data.txt";
Console.WriteLine("kaçış karakteri ile yol: " + path1);

// verbatim

string path2 = @"C:\users\admin\documents\data.txt";
Console.WriteLine("verbatim ile yol: " + path2);


// JSON
string jsonEscaped = "{\"username\" : \"admin\"}";
Console.WriteLine("JSON çıkışı: " + jsonEscaped);


// JSON verbatim

Console.WriteLine("\nJSON verbatim:");
string jsonVerbatim = @"{
""username"":""admin"",
""status"":""active""
}";
Console.WriteLine(jsonVerbatim);

Console.ReadKey();
*/






// örnekler

/*
var a = "İstanbul";
var b = "istanbul";
var c = "Istanbul";

System.Console.WriteLine("== vs Equal");
System.Console.WriteLine($"{a}=={b} ? {a == b}");

    System.Console.WriteLine($"Equals ([a],{b}, StringComparison.OrdinalIgnoreCase) ? " +
    $"{string.Equals(a,b, StringComparison.OrdinalIgnoreCase)}");

    System.Console.WriteLine($"Equals ([a],{b}, StringComparison.CurrentCultureIgnoreCase) ? " +
    $"{string.Equals(a,b, StringComparison.CurrentCultureIgnoreCase)}");




Console.ReadKey();

*/





var cities = new List<String> {"izmir",
"İzmir",
"Isparta",
"isparta",
"Istanbul",
"istanbul",
"samsun",
"van",
"adana",
};

// ordinal sıralama
var ordinalSorted = new List<string>(cities);
ordinalSorted.Sort(StringComparer.Ordinal);

foreach (var item in ordinalSorted)
{
    System.Console.WriteLine(item);
}

// CurrentCultureIgnoreCase

System.Console.WriteLine($"\n{new string('-',10)}");
var culturelSorted = new List<string>(cities);
culturelSorted.Sort(StringComparer.CurrentCultureIgnoreCase);
foreach (var item in culturelSorted)
{
    System.Console.WriteLine(item);
}



Console.ReadKey();
















