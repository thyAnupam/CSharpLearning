namespace CSharpLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i;
            i = Convert.ToDouble(Console.ReadLine());
            int ans = RoundOff(i);
            Console.WriteLine(ans);
        }

        static int RoundOff(double a)
        {
            int temp = (int)a;
            double secondTemp = (double)temp;

            if (secondTemp + 0.5 == a)
            {
                if (temp % 2 == 0)
                    return temp;

                else return temp + 1;
            }

            if (secondTemp + 0.5 > a)
            {
                return temp;
            }

            return temp + 1;

        }


        class BankAccount
        {
            int balance;
            bool isActive;
            int accountNumber;


            public bool Status
            {
                get
                {
                    return isActive;
                }
                set { isActive = value; }
            }
            public BankAccount(int x, int acc_num) 
            {
                this.balance = x;
                this.accountNumber= acc_num;
                isActive = true;

            }

            public void ShowBalance()
            {
                //print balance
                Console.WriteLine(balance);
            }

            public void AddBalance(int amount)
            {
                //add balance
                if(amount>0 && isActive)
                    balance += amount;
            }
            public void WithdrawBalance(int amount)
            {
                //minus balance
                if (amount > balance && isActive)
                {
                    Console.WriteLine("Not enough");
                }
                else
                {
                    balance -= amount;
                }
            }
        }
    }

}
    