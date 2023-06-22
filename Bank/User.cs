public class User : IComparable {
  private static int TotalUsers;
  public readonly int Id;
  public string FirstName;
  public string LastName;
  public Account Account;

  public User(string firstName, string lastName) {
    Id = TotalUsers++;
    FirstName = firstName;
    LastName = lastName;
  }

  public void RegisterAccount(Bank bank) {
    Account = new Account(bank);
  }

  public void BlockUser() {
    if (Account is not null) {
      Account.BlockAccount();
    }
  }

  public void UnblockUser() {
    if (Account is not null) {
      Account.UnblockAccount();
    }
  }

  public int CompareTo(object? obj)
  {
    try {
      if(obj is User user) return Account.GetScore() - user.Account.GetScore();
      else throw new ArgumentException("Incorrect parameter");
    } catch {
      Console.WriteLine("Compare Error");
      return 0;
    }
  }
}