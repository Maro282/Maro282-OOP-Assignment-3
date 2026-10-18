using RefactoringLab;


var shipping = new ShippingCostCalculator();
Console.WriteLine($"Aramex 2kg → {shipping.Calculate(2, new AramexCostStrategy())}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(2, new FedExCostStrategy())}");
// This strategy added by me
Console.WriteLine($"Marwan Express 2kg  → {shipping.Calculate(2, new MarwanExpressCostStrategy())}");
Console.WriteLine();




var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();






var user = new Recipient
{
    email = "customer@example.com",
    phone = "+201000000000"
};
//If we send both sms and phone
var notification1 = new Notification(new List<INotification>{ new UrgentScheduledEmailNotification(DateTime.Today.AddHours(18)),
                                      new UrgentSmsNotification() });
notification1.SendNotification(user, "Your order ships tomorrow");

// this if we need to send a sms only
var notification2 = new Notification(new List<INotification> { new UrgentSmsNotification() });
notification2.SendNotification(user, "OTP 4821");

