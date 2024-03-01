namespace LearningAbstractionInCshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Abstraction in c#...");
            PayBill payBill = new PayBill();
            payBill.display();
        }
    }
}
