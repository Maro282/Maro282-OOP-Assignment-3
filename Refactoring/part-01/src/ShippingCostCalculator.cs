namespace RefactoringLab;



// i have done the strategy design pattern to calculate the cost of the shipment 
// so the shipping class doesn't need to know how the strategy will be done 
// and it's became easy to use many carries at the same time


public interface ICostCalculationStrategy
{
    public decimal Calculate(decimal weightKg);
}

public class AramexCostStrategy : ICostCalculationStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}
public class FedExCostStrategy : ICostCalculationStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}
public class DHLCostStrategy : ICostCalculationStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}
public class MarwanExpressCostStrategy : ICostCalculationStrategy
{
    public decimal Calculate(decimal weightKg) => weightKg * 20m;
}



public class ShippingCostCalculator
{

    public decimal Calculate(decimal weightKg, ICostCalculationStrategy strategy)
    {
        if (strategy is null) throw new ArgumentNullException(nameof(strategy));
        return strategy.Calculate(weightKg);
    }
}
