// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//DIP: Bir bağımlılık, büyük sistemin içerisinde değil; dışında tanımlanmalı. Böylece küçük sistem; büyük sisteme aktarılmalı.
Report report = new Report(new WhatsAppSender());
Report report1 = new Report(new TelegramSender());

report1.SendReport();
report.SendReport();

public class Report
{
    private ISender sender;

    //Constructor:
    public Report(ISender sender)
    {
        this.sender = sender;
    }
    //Metot parametrersi
    //Set Property
    //public MailSender MailSender { get; set; }

    public void SendReport()
    {
        //MailSender mailSender = new MailSender();
        sender.Send();
    }
}
public interface ISender
{
    void Send();
}
public class MailSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Mail gönderildi");
    }
}

public class WhatsAppSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Whatsapp ile gönderildi");
    }
}

public class TelegramSender : ISender
{
    public void Send()
    {
        Console.WriteLine("Telegram ile gönderildi");
    }
}