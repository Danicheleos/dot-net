// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Xml.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    var bank1 = new Bank("Bank 1", "City 1", "Address 1");
    var bank2 = new Bank("Bank 2", "City 2", "Address 2");

    var user1 = new User("Ivan", "Iv");
    var user2 = new User("Dan", "Da");
    var user3 = new User("Andrej", "An");
    var user4 = new User("Jan", "Ja");

    bank1.RegisterUser(user1);
    bank1.RegisterUser(user2);
    user1.Account.AddScore(1000);
    user2.Account.AddScore(250);

    bank2.RegisterUser(user3);
    bank2.RegisterUser(user4);
    user3.Account.AddScore(500);
    user4.Account.AddScore(750);

    var bankList = new LinkedList<Bank>();
    bankList.Add(bank1);
    bankList.Add(bank2);

    var userList = new LinkedList<User>();
    userList.Add(user1);
    userList.Add(user2);

    Console.WriteLine(BankService.GetUserWithMaxScore(bankList));
    Console.WriteLine(BankService.GetUserWithMinScore(bankList));

    Console.WriteLine("----------------");

    var allUsers = BankService.getUsers(bankList);
    foreach (var user in allUsers.ToArray())
    {
      Console.WriteLine(user.FirstName + ' ' + user.LastName + ' ' + user.Account.Bank.Name + ' ' + user.Account.Score);
    }

    Console.WriteLine("----------------");

    var singleEser = BankService.getUser(bankList, 2);
    Console.WriteLine(singleEser.FirstName + ' ' + singleEser.LastName + ' ' + singleEser.Account.Bank.Name + ' ' + singleEser.Account.Score);
  }
}