
public static class BankService {
  public static List<User> getUsers(List<Bank> bankList) {
    var bankArray = bankList.ToArray();
    List<User> userList = new List<User>();

    foreach (var bank in bankArray)
    {
      userList.AddRange(bank.UserList);
    }

    userList.Sort();


    return userList;
  }

  public static User getUser(List<Bank> bankList, int id) {
    var bankArray = bankList.ToArray();
    List<User> userList = new List<User>();

    foreach (var bank in bankArray)
    {
      userList.AddRange(bank.UserList);
    }
    return userList.Find(user => user.Id == id);
  }

  public static string GetUserWithMinScore(List<Bank> bankList) {
    var bankArray = bankList.ToArray();
    List<User> userList = new List<User>();

    foreach (var bank in bankArray)
    {
      userList.AddRange(bank.UserList);
    }

    User maxUser = userList[0];

    userList.ForEach(user => {
      if (user.Account.Score <= maxUser.Account.Score) {
        maxUser = user;
      }
    });

    return maxUser.FirstName + ' ' + maxUser.Account.Score;
  }

  public static string GetUserWithMaxScore(List<Bank> bankList) {
    List<User> userList = new List<User>();

    bankList.ForEach(bank => {
      userList.AddRange(bank.UserList);
    });

    User maxUser = userList[0];

    userList.ForEach(user => {
      if (user.Account.Score >= maxUser.Account.Score) {
        maxUser = user;
      }
    });
    
    return maxUser.FirstName + ' ' + maxUser.Account.Score;
  }
}