namespace BankEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccount = new BankAccount();

            Console.WriteLine("How much do you want to deposit");
            var amountToDeposit = double.Parse(Console.ReadLine());

            myAccount.Deposit(amountToDeposit);

            myAccount.Deposit(100);

            Console.WriteLine(myAccount.GetBalance());

            Console.WriteLine("How much do you want to withdraw");
            var amountTowithdraw = double.Parse(Console.ReadLine());
            

            myAccount.Withdraw(amountTowithdraw);
            Console.WriteLine(myAccount.GetBalance());


        }
    }
}