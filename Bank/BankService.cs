
public static class BankService {
  public static IEnumerable<User> getUsers(List<Bank> bankList) {
    var userList = from bank in bankList from user in bank.UserList orderby user select user;
    return userList;
  }

  public static User getUser(List<Bank> bankList, int id) {
    return (from bank in bankList from user in bank.UserList where user.Id == id select user).First();
  }

  public static string GetUserWithMinScore(List<Bank> bankList) {
    var minUser = (from bank in bankList from user in bank.UserList select user).Min();
    return minUser.FirstName + ' ' + minUser.Account.Score;
  }

  public static string GetUserWithMaxScore(List<Bank> bankList) {
    var maxUser = (from bank in bankList from user in bank.UserList select user).Max();
    return maxUser.FirstName + ' ' + maxUser.Account.Score;
  }
}