using System;

public static class ListService
{
	static public IList<int> getPrimeList(IList<int> list)
	{
        var count = list.getCount();
        for (var i = 0; i < count; i++)
		{
			var value = list.getValue();

            if (!isPrime(value)) { 
                list.remove(value);
            }
            else
            {
                list.next();
            }
    }
		return list;
	}

    static public IList<int> getEvenList(IList<int> list)
    {
        var count = list.getCount();
        for (var i = 0; i < count; i++)
        {
            var value = list.getValue();
            if (value % 2 != 0) {
                list.remove(value);
            }
            else {
                list.next();
            }
        }
        return list;
    }

    static public IList<int> removeSpecificNumber(IList<int> list, int number)
    {
        var count = list.getCount();
        for (var i = 0; i < count; i++)
        {
            var value = list.getValue();
            if (value == number)
            {
                list.remove(value);
                count--;
            }
                else
            {
                list.next();
            }
    }
        return list;
    }


    static public Boolean isPrime(int number)
	{
		for (var i = 2; i <= number / 2; i++)
		{
			if (number % i == 0) return false;
		}
		return true;
	}

    static public IList<int> sort(IList<int> list)
    {
        var array = quickSort(list.toArray()).Reverse();

        list.clear();
        foreach (var element in array)
        {
            list.add(element);
        }
        return list;
    }

    private static int[] quickSort(int[] array, int low = 0, int high = 0)
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
        if (low < j) quickSort(array, low, j);
        if (high > i) quickSort(array, i, high);
        return array;
    }
}

