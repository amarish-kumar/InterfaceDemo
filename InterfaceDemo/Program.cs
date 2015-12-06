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
            //Transaction transaction = new Transaction();
            //transaction.startTransaction();
            //transaction.doTransaction();
            //Console.WriteLine(transaction.getAmount);
            var transaction = new Transaction();
            transaction.startTransaction();
            transaction.doTransaction();
            Console.WriteLine(transaction.getAmount);

            //Assigned the object to Interface variable
            ITransaction iTransaction = transaction;
            //Here also only interface stuffs will be available
            //However, if at all we would like to transaction explicit method available, then we need to cast like shown below
            Transaction transactionObj = iTransaction as Transaction;
            //Here, as keyword will examine the iTransaction and if it is of type Transaction, then it will return Transaction
            //else will return null. Hence, null check is recommended here
            if(transactionObj!=null)
                transactionObj.startTransaction();

            Console.ReadLine();

        }
    }
}
