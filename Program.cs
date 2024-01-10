using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

class Program
{
    static void Main()
    {
        Nokia nokia = new Nokia(numero: "81987122230", modelo: "Modelo N24", imei: "2545587458745285", memoria: 128);
        Iphone iphone = new Iphone(numero: "81995404933", modelo: "Modelo Iphone 8", imei: "547855547852369", memoria: 128);

        Console.WriteLine("Smartphone Nokia");
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone");
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Telegram");        
    }
}