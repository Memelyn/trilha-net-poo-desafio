using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "modelo 1", imei: "5555555", memoria: 128); 
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("SmartphoneIphone: ");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "modelo 2", imei: "44444444", memoria: 256); 
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");