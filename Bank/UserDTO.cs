public abstract class UserDTO : IComparable {
  public static int TotalUsers;
  public int Id;
  public string FirstName;
  public string LastName;
  public Account Account;

  public int CompareTo(object obj)
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