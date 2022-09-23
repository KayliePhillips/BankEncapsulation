using BankEncapsulation;
using System;

var bankAccountKaylie = new BankAccount();

Console.Write("Please enter how much you would like to deposit: $ ");


var userDepositValid = double.TryParse(Console.ReadLine(), out double userDepositAmount);

while (!userDepositValid) //this answer need to be true or false.  If false, write try again, if true leave and go to next step.  
{
    Console.WriteLine("Invalid entry.  Please enter a valid deposit amount: $");
    userDepositValid = double.TryParse(Console.ReadLine(), out userDepositAmount);
}

bankAccountKaylie.Deposit(userDepositAmount);

double answer = bankAccountKaylie.GetBalance();

Console.WriteLine($"Your new balance is $ {answer}");

Console.Write("Please enter how much you would like to withdrawal: $ ");

var userWithdrawalValid = double.TryParse(Console.ReadLine(), out double userWithdrawalAmount);

while (!userDepositValid) //this answer need to be true or false.  If false, write try again, if true leave and go to next step.  
{
    Console.WriteLine("Invalid entry.  Please enter a valid withdrawal amount: $");
    userWithdrawalValid = double.TryParse(Console.ReadLine(), out userWithdrawalAmount);
}

bankAccountKaylie.Withdrawal(userWithdrawalAmount);

answer = bankAccountKaylie.GetBalance();

Console.WriteLine($"Your new balance is $ {answer}");
//Can write this either way. 
//Console.WriteLine($"Your new balance is {bankAccountKaylie.GetBalance()}");


