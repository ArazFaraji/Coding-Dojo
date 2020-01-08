using System;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BankAccounts.Models
{
    public class Transaction
    {
        public int TransactionId {get; set;}
        public double Amount {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public int UserId {get; set;}
        public User User {get; set;}
    }
}