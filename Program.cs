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
    CreateLinkedList().print();

    ListService.getEvenList(CreateLinkedList()).print();
    ListService.getPrimeList(CreateLinkedList()).print();
    ListService.removeSpecificNumber(CreateLinkedList(), 5).print();
  }

  static void TestTWLinkedList()
  {
    Console.WriteLine("TEST TWO WAY LINKED LIST");
    CreateTWLinkedList().print();

    ListService.getEvenList(CreateTWLinkedList()).print();
    ListService.getPrimeList(CreateTWLinkedList()).print();
    ListService.removeSpecificNumber(CreateTWLinkedList(), 5).print();
    ListService.sort(CreateTWLinkedList()).print();
  }

  static LinkedList<int> CreateLinkedList()
  {
    LinkedList<int> list = new LinkedList<int>(0);
    list.add(3);
    list.add(2);
    list.add(6);
    list.add(1);
    list.add(5);
    list.add(4);
    return list;
  }

  static TWLinkedList<int> CreateTWLinkedList()
  {
    TWLinkedList<int> list = new TWLinkedList<int>(0);
    list.add(4);
    list.add(3);
    list.add(6);
    list.add(1);
    list.add(5);
    list.add(2);
    return list;
  }
}