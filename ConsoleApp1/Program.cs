using CSharpOOPs_Application;
namespace BestPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of Abstraction :: 
            //Shape c = new Circle(5.0);
            //Console.WriteLine("Area of Circle = {0}", c.Area());
            //Shape s = new Square(2.5);
            //Console.WriteLine("Area of Square = {0}", s.Area());
            //Shape t = new Triangle(2.0, 5.0);
            //Console.WriteLine("Area of Triangle = {0}", t.Area());


            // Example of Encapsulation :: 

            CSharpBank myAccount = new CSharpBank(minBalace: 1000);
            var isDone = myAccount.Deposit(5000);
            if (isDone)
            {
                myAccount.Withdraw(1200);
                Console.WriteLine($"To Know your Balance call `myAccount.Balance` value is-> {myAccount.Balance}");
            }

            SmartWatch iWatch=new SmartWatch();
            iWatch.Tracking();

            Maths maths = new();
            maths.Add(10, 20);
            maths.Add(10, 20, 30);

            Console.ReadKey();
        } 
    }
}
