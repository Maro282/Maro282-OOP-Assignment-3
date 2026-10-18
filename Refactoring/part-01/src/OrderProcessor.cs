namespace RefactoringLab;

// this class was violating DIP 
// so we will make the hight level modules not depending on low level
// and make all of them depend on Abstraction
// High level (order process)
// low level (sqlOrderRepository) & (SmtpEmailSender)


// 1 - Creating the abstraction
public interface IOrderRepository
{
    public void Save(int orderId, DateTime processedAt);
}

public interface IEmailSender
{
    public void Send(string to, string body);
}



// ====================== 3- make high level depends on abstractio only ===============

public class OrderProcessor
{

    private readonly IOrderRepository _orderRepository;
    private readonly IEmailSender _emailSender;

    public OrderProcessor(IOrderRepository orderRepository, IEmailSender emailSender)
    {
        _orderRepository = orderRepository;
        _emailSender = emailSender;
    }
    public void Process(int orderId, string customerEmail)
    {

        _orderRepository.Save(orderId, DateTime.Now);
        _emailSender.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}


// =================== 2- Make low level depends on abstraction ====================== 
public class SqlOrderRepository : IOrderRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender : IEmailSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}
