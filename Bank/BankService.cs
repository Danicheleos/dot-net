
public static class BankService {
  public static LinkedList<User> getUsers(LinkedList<Bank> bankList) {
    var bankArray = bankList.ToArray();
    LinkedList<User> userList = new LinkedList<User>();

    foreach (var bank in bankArray)
    {
      userList.Concat(bank.UserList);
    }

    var userArray = userList.ToArray();
    Array.Sort(userArray);
    userList.Clear();

    foreach (var user in userArray)
    {
      userList.Add(user);
    }

    return userList;
  }

  public static User getUser(LinkedList<Bank> bankList, int id) {
    var bankArray = bankList.ToArray();
    LinkedList<User> userList = new LinkedList<User>();

    foreach (var bank in bankArray)
    {
      userList.Concat(bank.UserList);
    }

    var current = userList.head;
    while (current is not null) {
      if (current.value.Id == id) {
        return current.value;
      }
      current = current.next;
    }
    return null;
  }

  public static string GetUserWithMinScore(LinkedList<Bank> bankList) {
    var bankArray = bankList.ToArray();
    LinkedList<User> userList = new LinkedList<User>();

    foreach (var bank in bankArray)
    {
      userList.Concat(bank.UserList);
    }

    var current = userList.head;
    int minScore = current.value.Account.Score;
    User minUser = current.value;

    while (current is not null) {
      if (current.value.Account.Score <= minScore) {
        minScore = current.value.Account.Score;
        minUser = current.value;
      }
      current = current.next;
    }
    return minUser.FirstName + ' ' + minUser.Account.Score;
  }

  public static string GetUserWithMaxScore(LinkedList<Bank> bankList) {
    var bankArray = bankList.ToArray();
    LinkedList<User> userList = new LinkedList<User>();

    foreach (var bank in bankArray)
    {
      userList.Concat(bank.UserList);
    }

    var current = userList.head;
    int maxScore = current.value.Account.Score;
    User maxUser = current.value;

    while (current is not null) {
      if (current.value.Account.Score >= maxScore) {
        maxScore = current.value.Account.Score;
        maxUser = current.value;
      }
      current = current.next;
    }
    return maxUser.FirstName + ' ' + maxUser.Account.Score;
  }
}