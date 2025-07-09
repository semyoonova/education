using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class BankUser
    {
        public Guid Id { get; init; }
        public string FullName { get; set; }
        public required string Email { get; init; }
        public string PhoneNumber { get; private set; }
        public decimal Balance { get; private set; }
        private int PasswordHash { get; set; }
        public bool IsVerified { get; private set; }
        DateTime AccountCreated { get; init; }

        public BankUser()
        {
            Id = Guid.NewGuid();
            AccountCreated = DateTime.Now;
        }

        public void UpdatePhone(string newPhone)
        {
            PhoneNumber = newPhone;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void VerifyAccount()
        {
            IsVerified = true; 
        }
    }
}
