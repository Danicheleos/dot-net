public class Bank {
  private static int Total;
  public readonly int Id;
  public string Name;
  public string City;
  public string Address;

  public List<User> UserList;

  public Bank(string name, string city, string address) {
    Id = Total++;
    Name = name;
    City = city;
    Address = address;
    UserList = new List<User>();
  }

  public void RegisterUser(User user) {
    user.RegisterAccount(this);
    UserList.Add(user);
  }

  public void UnregisterUser(User user) {
    UserList.Remove(user);
  }

  public void BlockUser(User user) {
    var foundUser = UserList.Find(el => el.Id == user.Id);
    if (foundUser is not null) {
      foundUser.BlockUser();
    }
  }

  public void UnblockUser(User user) {
    var foundUser = UserList.Find(el => el.Id == user.Id);
    if (foundUser is not null) {
      foundUser.UnblockUser();
    }
  }
}