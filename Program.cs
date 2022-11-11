using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smatphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "N2022", imei: "2222222222", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smatphone Iphone:");
Smartphone iphone = new Iphone(numero: "7891012", modelo: "IPH2022", imei: "3333333333", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");