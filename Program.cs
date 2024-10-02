using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "3264-2020", modelo: "Tijolão", imei: "1512168324", memoria: 64);
Smartphone iphone = new Iphone(numero: "4002-8922", modelo: "15", imei: "19519841621", memoria: 128);

Console.WriteLine("Celular Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("iPhone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");