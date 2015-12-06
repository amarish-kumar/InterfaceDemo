
using System;

namespace InterfaceDemo
{
    class Transaction : ITransaction
    {
        //Not part of interface
        public void startTransaction()
        {
            Console.WriteLine("Started doing Transaction");
        }
        public void doTransaction()
        {
            Console.WriteLine("Doing Cash Transaction");
        }

        public double getAmount
        {

            get { return 10000; }
        }
    }
}
