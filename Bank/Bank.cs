public class Bank {
  private static int Total;
  public readonly int Id;
  public string Name;
  public string City;
  public string Address;

  public LinkedList<User> UserList;

  public Bank(string name, string city, string address) {
    Id = Total++;
    Name = name;
    City = city;
    Address = address;
    UserList = new LinkedList<User>();
  }

  public void RegisterUser(User user) {
    user.RegisterAccount(this);
    UserList.Add(user);
  }

  public void UnregisterUser(User user) {
    UserList.Remove(user);
  }

  public void BlockUser(User user) {
    var foundUser = UserList.Contains(user);
    if (foundUser is not null) {
      foundUser.BlockUser();
    }
  }

  public void UnblockUser(User user) {
    var foundUser = UserList.Contains(user);
    if (foundUser is not null) {
      foundUser.UnblockUser();
    }
  }
}