namespace RefactoringLab;

// I have made this record to specify through methods if we send email or phone number 
public record Recipient(string? email = null, string? phone = null);


// i made this class to not modifying in the Notification class
// if i have to add new channel to send notifications so each class will implement this interface
// and the notification class will contain IEnumerable list of channels 
public interface INotification
{
    public void Send(Recipient to, string message);
}

public class Notification
{
    private readonly IEnumerable<INotification> _channels;
    public Notification(IEnumerable<INotification> channels)
    {
        _channels = channels;
    }

    public void SendNotification(Recipient to, string message)
    {


        foreach (var channel in _channels)
        {

            channel.Send(to, message);
        }

    }


}

public class EmailNotification
{
    public void Send(Recipient to, string message)
    {
        if (to.email is null) return;
        Console.WriteLine($"[email] {to}: {message}");
    }

}

public class SmsNotification : INotification
{
    public void Send(Recipient to, string message)
    {
        if (to.phone is null) return;
        Console.WriteLine($"[sms] {to}: {message}");
    }
}

public class UrgentEmailNotification : INotification
{
    public void Send(Recipient to, string message)
    {
        if (to.email is null) return;
        Console.WriteLine($"[email] {to}:[URGENT] {message}");
    }
}

public class UrgentSmsNotification : INotification
{
    public void Send(Recipient to, string message)
    {
        if (to.phone is null) return;
        Console.WriteLine($"[sms] {to}: [URGENT] {message}");
    }
}

public class UrgentScheduledEmailNotification : INotification
{
    public DateTime SendAt { get; set; }


    public UrgentScheduledEmailNotification(DateTime at)
    {
        SendAt = at;
    }

    public void Send(Recipient to, string message)
    {
        if (to.email is null) return;
        Console.WriteLine($"[email scheduled {SendAt:g}] {to}: [URGENT] {message}");
    }
}

public class UrgentScheduledSmsNotification : INotification
{
    public DateTime SendAt { get; set; }

    public UrgentScheduledSmsNotification(DateTime at)
    {
        SendAt = at;
    }
    public void Send(Recipient to, string message)
    {
        if (to.phone is null) return;
        Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
    }
}

public class WhatsAppNotification : INotification
{
    public void Send(Recipient to, string message)
    {
        if (to.phone is null) return;
        Console.WriteLine($"[WhatsApp Reminder To {to}: {message}");
    }
}

public class UrgentWhatsAppNotification : INotification
{
    public void Send(Recipient to, string message)
    {
        if (to.phone is null) return;
        Console.WriteLine($"[sms] {to}: [URGENT] {message}");
    }
}


public class UrgentScheduledWhatsAppNotification : INotification
{
    public DateTime SendAt { get; set; }

    public UrgentScheduledWhatsAppNotification(DateTime at)
    {
        SendAt = at;
    }
    public void Send(Recipient to, string message)
    {
        if (to.phone is null) return;
        Console.WriteLine($"[sms scheduled {SendAt:g}] {to}: [URGENT] {message}");
    }
}