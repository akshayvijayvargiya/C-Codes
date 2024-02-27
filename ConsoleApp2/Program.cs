internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter Salary");
        decimal r = 0;
        decimal tax = 0;
        String salary = Console.ReadLine();
        int a = Int32.Parse(salary);
        if (a <= 200000)
        {
            Console.Write("No tax! Enjoy!!");
        }
        else if(a > 200000 & a<=400000)
        {
            a = a - 200000;
            r = 0.25M;
            tax = a * r;
            Console.WriteLine("Total tax: " + tax);

        }
        else
        {
            a = a - 400000;
            r = 0.50M;
            tax = (a * r) + 50000;
            Console.WriteLine("Total tax: " + tax);
        }
    }
}
//New code added