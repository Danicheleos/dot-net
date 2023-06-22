// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.Xml.Linq;
using System;

class Program
{
  static void Main(string[] args)
  {
    Program.TestLinkedList();
    Program.TestTWLinkedList();
  }

  static void TestLinkedList()
  {
    Console.WriteLine("TEST LINKED LIST");
    ListService.Sort(CreateLinkedList()).Print();
    ListService.GetEvenList(CreateLinkedList()).Print();
    ListService.GetPrimeList(CreateLinkedList()).Print();
    ListService.RemoveSpecificNumber(CreateLinkedList(), 5).Print();
  }

  static void TestTWLinkedList()
  {
    Console.WriteLine("TEST TWO WAY LINKED LIST");
    ListService.Sort(CreateTWLinkedList()).Print();
    ListService.GetEvenList(CreateTWLinkedList()).Print();
    ListService.GetPrimeList(CreateTWLinkedList()).Print();
    ListService.RemoveSpecificNumber(CreateTWLinkedList(), 5).Print();
  }

  static LinkedList<int> CreateLinkedList()
  {
    LinkedList<int> list = new LinkedList<int>();
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
    TWLinkedList<int> list = new TWLinkedList<int>();
    list.Add(4);
    list.Add(3);
    list.Add(6);
    list.Add(1);
    list.Add(5);
    list.Add(2);
    return list;
  }
}