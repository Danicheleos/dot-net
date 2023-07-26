public class User : UserDTO {

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
}