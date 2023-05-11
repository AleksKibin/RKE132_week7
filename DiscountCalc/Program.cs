Console.WriteLine("Write total");
int UserInput = Int32.Parse(Console.ReadLine());

double discount = calculateDiscount(UserInput);

Console.WriteLine($"Your discount is: {discount}%");

double newTotal = CalculateNewTotal(UserInput, discount);
Console.WriteLine($"Your new total is: {newTotal} ");

static double calculateDiscount(int total)
{
    if(total < 10)
    {
        return 1;
    }
    else if (total >= 10 && total <= 20)
    {
        return 5;
    }
    else
    {
        return 10; 
    }
}

static double CalculateNewTotal(double total, double discount)
{
    double result = total - (total * discount) / 100;
    return result;
} 