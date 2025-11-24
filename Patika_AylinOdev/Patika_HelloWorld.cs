// See https://aka.ms/new-console-template for more information
using System;
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
{ Console.WriteLine("Teşekkürler Yaşınız:" + yas);
}
else
{
    Console.WriteLine("Hatalı giriş!Lütfen sadece rakam giriniz.");
}


