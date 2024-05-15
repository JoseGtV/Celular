using System.ComponentModel;
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "15 998630335", modelo: "Android", imei: "02", memoria: 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatssap");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone(numero: "15 998620991", modelo:"Iphone", imei: "01", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");







