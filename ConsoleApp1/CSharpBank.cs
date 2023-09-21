namespace CSharpOOPs_Application
{
    internal class CSharpBank
    {
        private decimal balance;
        private readonly decimal minBalace;

        public decimal Balance { get { return balance; } }

        public CSharpBank(decimal minBalace)
        {
            this.minBalace = minBalace;
        }

        public bool Deposit(decimal amount)
        {
            if (amount >= minBalace)
            {
                balance += amount;
                Console.WriteLine($"Your Balance: {balance}, after depoist of amount Rs.{amount}");
                return true;
            }
            else
                Console.WriteLine($"Your deposit must meet the minimum balance Rs. {minBalace}. ");

            return false;
        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Your Balance: {balance}, after withdraw of amount Rs.{amount}");
            }
            else
            {
                Console.WriteLine("Sorry, Insufficient funds...");
            }
        }

        public void PrintMyBalance()
        {
            Console.WriteLine($"Your Balance: {balance}");
        }
    }
}
