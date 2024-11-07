namespace Section1._2
{
    internal class Problem1_2_13
    {
        public class Transaction
        {
            public string Customer { get; }
            public Problem1_2_11.SmartDate SmartDate { get; }

            public double Amount { get; }

            private Transaction(string customer, Problem1_2_11.SmartDate Date, double amount)
            {
                Customer = customer;
                SmartDate = Date;
                Amount = amount;

            }

            public static Transaction? CreateTransaction(string customer, int day, int month, int year, double amount)
            {
                if (customer == null)
                {
                    Console.WriteLine("Invalid Customer name");
                }
                if (amount <= 0)
                {
                    Console.WriteLine("Please ensure amount is valid");
                    return null;
                }
                if (Problem1_2_11.SmartDate.CreateInstance(year, month, day) == null)
                {
                    Console.WriteLine("Invalid Transaction Date");
                }

                Problem1_2_11.SmartDate NewDate = Problem1_2_11.SmartDate.CreateInstance(year, month, day);

                return new Transaction(customer, NewDate, amount);


            }

            public override bool Equals(object? that)
            {
                if (that is null) return false;
                if (that is not Transaction thatTransaction) return false;

                return Customer == thatTransaction.Customer && SmartDate.Equals(thatTransaction.SmartDate) && Amount == thatTransaction.Amount;
            }
        }

    }
}
