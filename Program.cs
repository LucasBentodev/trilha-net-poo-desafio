using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("123456","Modelo 1", "1111111",64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone("7891011","Modelo 2", "333333333",78);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
