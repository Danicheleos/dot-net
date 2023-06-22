public class Account {
  private static int Total;
  public readonly int Id;
  public int Score = 0;
  public Bank Bank;
  public bool IsBlocked = false;

  public Account(Bank bank) {
    Id = Total++;
    Bank = bank;
  }

  public int GetScore() {
    return Score;
  }

  public void AddScore(int amount) {
    Score += amount;
  }

  public void BlockAccount() {
    IsBlocked = true;
  }

  public void UnblockAccount() {
    IsBlocked = false;
  }
}