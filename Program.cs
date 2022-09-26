using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero:"564616545",modelo:"Modelo 1",imei:"4545",memoria:45);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero:"49849454645",modelo:"Modelo 2",imei:"7745",memoria:64);
iphone.Ligar();
iphone.InstalarAplicativo("Poo");


