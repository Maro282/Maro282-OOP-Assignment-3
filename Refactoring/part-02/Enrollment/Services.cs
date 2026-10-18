namespace RefactoringLab.Part02.Enrollment;


public class EnrollmentFacade
{

    private readonly PaymentGateway _paymentGateway;
    private readonly SeatInventory _seatInventory;
    private readonly InvoiceGenerator _invoiceGenerator;
    private readonly EmailService _emailService;


    public EnrollmentFacade()
    {
        _paymentGateway = new PaymentGateway();
        _seatInventory = new SeatInventory();
        _invoiceGenerator = new InvoiceGenerator();
        _emailService = new EmailService();
    }


    public void EnrollStudent(string studentId, string courseId, decimal amount)
    {

        if (studentId == null || courseId == null)
        {
            throw new ArgumentNullException("StudentId or CourseId coudn't be Empty or null");
        }

        if (amount < 0) throw new ArgumentOutOfRangeException("Amount Coudn't be negative");

        _seatInventory.Reserve(courseId, studentId); // reserve seat first
        _paymentGateway.Charge(studentId, amount);
        var invoiceId = _invoiceGenerator.Create(studentId, amount);
        _emailService.Send(studentId, "Enrollment confirmed", $"Invoice {invoiceId} for {courseId}");

    }





    public class PaymentGateway
    {
        public void Charge(string studentId, decimal amount) =>
            Console.WriteLine($"charge {studentId}: {amount}");
    }

    public class SeatInventory
    {
        public void Reserve(string courseId, string studentId) =>
            Console.WriteLine($"reserve seat {courseId} for {studentId}");
    }

    public class InvoiceGenerator
    {
        public string Create(string studentId, decimal amount)
        {
            var invoiceId = $"INV-{studentId}-{amount}";
            Console.WriteLine($"invoice {invoiceId}");
            return invoiceId;
        }
    }

    public class EmailService
    {
        public void Send(string studentId, string subject, string body) =>
            Console.WriteLine($"email {studentId}: {subject} / {body}");
    }

}