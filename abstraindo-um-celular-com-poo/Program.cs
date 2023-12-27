using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "(35) 96765-5633", modelo: "G11 Plus NK095", imei: "494960247140492", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\nSmartphone Iphone");
Iphone iphone = new Iphone(numero: "(98) 99832-8565", modelo: "iPhone 14", imei: "915215508002084", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");