using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
nokia.InstalarAplicativo("'Snake'");

Console.WriteLine("\n");


Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("987654321", "iPhone 14", "987654321012345", 128);
iphone.InstalarAplicativo("'Instagram'");