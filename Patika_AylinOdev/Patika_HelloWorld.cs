// See https://aka.ms/new-console-template for more information
using Patika_AylinOdev;
using System;

try { 

Console.WriteLine("Hello, World!");
Console.WriteLine("İsminizi Giriniz:");
string  name = Console.ReadLine() ! ;
Console.WriteLine("Soyadınızı Giriniz:");
string  surname = Console.ReadLine()!;

Console.WriteLine("Merhaba" + " " + name + " " + surname);

int yas;

Console.WriteLine("Lütfen yaşınızı girin:");
string input = Console.ReadLine()!;
if (int.TryParse(input, out yas))
{
    Console.WriteLine("Teşekkürler Yaşınız:" + yas);
}
else
{
    Console.WriteLine("Hatalı giriş!Lütfen sadece rakam giriniz.");
}

Console.WriteLine("Üye olmak ister misiniz?");

bool tercih;

string startparam= Console.ReadLine();
if (startparam.ToLower() == "evet")
{
    tercih = true;
}
else
{
    tercih = false;
}

    

if (tercih)
{
    Operatorler op = new Operatorler(startparam);
    string response = op.Kontrol(yas);
    Console.WriteLine("Cevap:" +" "+ response);
}
else
{
    Console.WriteLine("yine bekleriz");
}
}
catch (Exception ex)
{
    Console.WriteLine("Bir hata oluştu: " + ex.Message);
}
Console.WriteLine("Lütfen ayı 1-12 arasında bir rakam olarak giriniz.");

if (!int.TryParse(Console.ReadLine(), out int month))
{
    Console.WriteLine("Geçersiz giriş! Lütfen sadece rakam giriniz.");
    return;
}


if (month < 1 || month > 12)
{
    Console.WriteLine("Lütfen 1 ile 12 arasında bir değer giriniz.");
    return;
}

switch (month)
{
    case int m when (m >= 1 && m <= 3):
        Console.WriteLine("Başlangıç üyeliği ücreti 10$");
        break;

    case int m when (m >= 4 && m <= 9):
        Console.WriteLine("Orta seviye üyelik 6$");
        break;

    case int m when (m >= 10 && m <= 12):
        Console.WriteLine("Premium üyelik 3$");
        break;

    default:
        Console.WriteLine("Şuanda işleminizi gerçekleştiremiyoruz.");
        break;
}






