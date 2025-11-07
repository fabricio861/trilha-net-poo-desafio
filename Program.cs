using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main()
    {
        Smartphone nokia = new Nokia("123456", "Nokia Tijolão", "111111", 1);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        Smartphone iphone = new Iphone("40028922", "Iphone 17", "222222", 2);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

    }

}