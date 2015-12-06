using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ITransaction transaction = new Transaction();
            // transaction.doTransaction();
            //Console.WriteLine(transaction.getAmount);
            Transaction transaction = new Transaction();
            transaction.startTransaction();
            transaction.doTransaction();
            Console.WriteLine(transaction.getAmount);
            Console.ReadLine();

        }
    }
}
