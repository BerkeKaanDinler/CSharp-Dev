# C# Eğitim Alıştırmaları

C# öğrenirken yaptığım alıştırmaları ve projeleri bu repoda biriktiriyorum.

## İçerik

- `Döngüler/Program.cs`: Döngüler, koşullar, sayı toplama, en büyük ve en küçük sayıyı bulma ve menülü sayı analiz programı. Önceki alıştırmalar yorum bloklarında saklanıyor.
- `Diziler ve List/Program.cs`: Dizi ve liste alıştırmaları için yeni konsol projesi.
- `String Veri Yapısı/Program.cs`: String (metin) alıştırmaları için konsol projesi.
- `String Veri Yapıları Örnekleme ve Çalışma/Program.cs`: String örnekleri ve çalışmalar için ayrı konsol projesi.
- `ConsoleApp1/`: `while` döngüsü ve `continue` kullanımı üzerine ayrı bir konsol projesi.

## Çalıştırma

[.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) gereklidir.

Döngüler projesini repo klasöründe çalıştırmak için:

```bash
dotnet run --project "Döngüler/Döngüler.csproj"
```

Diziler ve List projesini çalıştırmak için:

```bash
dotnet run --project "Diziler ve List/DizilerVeList.csproj"
```

String Veri Yapısı projesini çalıştırmak için:

```bash
dotnet run --project "String Veri Yapısı/StringVeriYapisi.csproj"
```

String Veri Yapıları Örnekleme ve Çalışma projesini çalıştırmak için:

```bash
dotnet run --project "String Veri Yapıları Örnekleme ve Çalışma/StringVeriYapilariOrneklemeVeCalisma.csproj"
```

ConsoleApp1 projesini çalıştırmak için:

```bash
dotnet run --project ConsoleApp1/ConsoleApp1.csproj
```

`bin` ve `obj` klasörleri derleme sırasında otomatik oluşur ve Git'e eklenmez.

Her proje kendi klasöründedir. Yeni alıştırmaları ilgili projenin `Program.cs` dosyasına yazabilirsin. Terminalde proje klasörünün içindeysen çalıştırmak için yalnızca `dotnet run` yazman yeterlidir.
