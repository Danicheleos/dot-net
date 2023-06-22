using System;

public static class ListService
{
  static public IList<int> GetPrimeList(IList<int> list)
  {
    var count = list.GetCount();
    var current = list.head;
    while (current is not null)
    {
      var value = current.value;

      if (!IsPrime(value))
      {
        list.Remove(value);
      }
      current = current.next;
    }
    return list;
  }

  static public IList<int> GetEvenList(IList<int> list)
  {
    var count = list.GetCount();
    var current = list.head;

    while (current is not null)
    {
      var value = current.value;
      if (value % 2 != 0)
      {
        list.Remove(value);
      }
      current = current.next;
    }
    return list;
  }

  static public IList<int> RemoveSpecificNumber(IList<int> list, int number)
  {
    var count = list.GetCount();
    var current = list.head;

    for (var i = 0; i < count; i++)
    {
      var value = current.value;
      if (value == number)
      {
        list.Remove(value);
        count--;
      }
      else
      {
        current = current.next;
      }
    }
    return list;
  }


  static public Boolean IsPrime(int number)
  {
    for (var i = 2; i <= number / 2; i++)
    {
      if (number % i == 0) return false;
    }
    return true;
  }

  static public IList<int> Sort(IList<int> list)
  {
    list.Print();
    var array = QuickSort(list.ToArray());
    list.Clear();
    foreach (var element in array)
    {
      list.Add(element);
    }
    return list;
  }

  private static int[] QuickSort(int[] array, int low = 0, int high = 0)
  {
    if (high == 0) high = array.Length - 1;
    if (low >= high || array.Length == 0) return array;

    int center = low + (high - low) / 2;
    int element = array[center];

    int i = low, j = high;

    while (i <= j)
    {
      while (array[i] < element) i++;
      while (array[j] > element) j--;

      if (i <= j)
      {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        i++;
        j--;
      }
    }
    if (low < j) QuickSort(array, low, j);
    if (high > i) QuickSort(array, i, high);
    return array;
  }
}

