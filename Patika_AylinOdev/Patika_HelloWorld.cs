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
    Console.WriteLine("cevap" + response);
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




