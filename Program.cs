// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Xml.Linq;

struct Person
{
    public string name;
}
class Program
{
    static void Main(string[] args)
    {
        Program.TestLinkedList();
        Program.TestTWLinkedList();
        Console.ReadKey();
    }

    static void TestLinkedList()
    {
        Console.WriteLine("TEST LINKED LIST");
        CreateLinkedList().Print();

        ListService.getEvenList(CreateLinkedList()).Print();
        ListService.getPrimeList(CreateLinkedList()).Print();
        ListService.removeSpecificNumber(CreateLinkedList(), 5).Print();
    }

    static void TestTWLinkedList()
    {
        Console.WriteLine("TEST TWO WAY LINKED LIST");
        CreateTWLinkedList().Print();

        ListService.getEvenList(CreateTWLinkedList()).Print();
        ListService.getPrimeList(CreateTWLinkedList()).Print();
        ListService.removeSpecificNumber(CreateTWLinkedList(), 5).Print();
        ListService.sort(CreateTWLinkedList()).Print();
    }

    static LinkedList<int> CreateLinkedList()
    {
        LinkedList<int> list = new LinkedList<int>(0);
        list.Add(3);
        list.Add(2);
        list.Add(6);
        list.Add(1);
        list.Add(5);
        list.Add(4);
        return list;
    }

    static TWLinkedList<int> CreateTWLinkedList()
    {
        TWLinkedList<int> list = new TWLinkedList<int>(0);
        list.Add(4);
        list.Add(3);
        list.Add(6);
        list.Add(1);
        list.Add(5);
        list.Add(2);
        return list;
    }
}