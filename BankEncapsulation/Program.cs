using BankEncapsulation;

var bankAccountKaylie = new BankAccount();

Console.Write("Please enter how much you would like to deposit: $ ");
var userDeposit = double.Parse(Console.ReadLine());

bankAccountKaylie.Deposit(userDeposit);

double answer = bankAccountKaylie.GetBalance();

Console.WriteLine($"Your new balance is $ {answer}");

//Can write this either way. 
//Console.WriteLine($"Your new balance is {bankAccountKaylie.GetBalance()}");


