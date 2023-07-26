
public static class BankService {
  public static List<User> getUsers(List<Bank> bankList) {
    return bankList.SelectMany(bank => bank.UserList.Select(user => user)).OrderBy(user => user).ToList();
  }

  public static User getUser(List<Bank> bankList, int id) {
    return bankList.SelectMany(bank => bank.UserList.Where(user => user.Id == id)).FirstOrDefault();
  }

  public static string GetUserWithMinScore(List<Bank> bankList) {
    var minUser = bankList.SelectMany(bank => bank.UserList.Select(user => user)).Min();
    return minUser.FirstName + ' ' + minUser.Account.Score;
  }

  public static string GetUserWithMaxScore(List<Bank> bankList) {
    var maxUser = bankList.SelectMany(bank => bank.UserList.Select(user => user)).Max();
    return maxUser.FirstName + ' ' + maxUser.Account.Score;
  }
}