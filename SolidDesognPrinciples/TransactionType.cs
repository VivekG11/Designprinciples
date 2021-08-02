using System;
using System.Collections.Generic;
using System.Text;

namespace SolidDesognPrinciples
{
    public class TransactionType : Opertion
    {
        public double balance = 10000;
      
        public void Deposit(int amount)
        {
          
            if (amount > 0)
            {
                balance += amount;
            }     
             if(amount < 0)
            {
                throw new InvalidOperationException();
            }
          
        }
        public void Withdraw(int amount)
        {
            if (amount > balance)
                throw new InvalidOperationException();
             if(amount < balance)
            balance = balance - amount;
        }
    }
}
