using System;
using System.Collections.Generic;

public class LinkedList<T> : IList<T>
{
  public Node<T> head { get; set; }
  private Node<T> tail;
  private uint count = 0;

  public LinkedList()
  {
    this.head = null;
    this.tail = null;
    this.count = 0;
  }

  public LinkedList(T value)
  {
    this.head = new Node<T>(value);
    this.tail = this.head;
    this.count = 1;
  }

  public LinkedList(LinkedList<T> list)
  {
    this.head = list.head;
    this.tail = list.tail;
    this.count = list.count;
  }

  public void Concat(LinkedList<T> list) {
    if (this.head is null) {
      this.head = list.head;
      this.tail = list.tail;
      this.count = list.count;
      return;
    }
    this.tail.next = list.head;
    this.tail = list.tail;
    this.count += list.count;
  }

  public T GetValue()
  {
    return this.head.value;
  }

  public T[] ToArray()
  {
    T[] array = new T[this.count];
    Node<T> current = this.head;
    var index = 0;

    while (current is not null)
    {
      array[index] = current.value;
      current = current.next;
      index++;
    }

    return array;
  }

  public void Add(T value)
  {
    Node<T> newNode = new Node<T>(value);
    if (head is null) {
      this.head = new Node<T>(value);
      this.tail = this.head;
      this.count++;
      return;
    }
    this.tail.next = newNode;
    this.tail = newNode;
    this.count++;
  }

  public void Remove(T value)
  {
    Node<T>? current = this.head;
    Node<T>? previuos = null;

    if (head is null || head.value is null) return;

    if (head.value.Equals(value))
    {
      this.head = this.head.next;
      this.count--;
      return;
    }


    while (current is not null && !current.value.Equals(value))
    {
      previuos = current;
      current = current.next;
    }

    if (current is null || previuos is null) return;

    this.count--;
    previuos.next = current.next;
  }

  public T Contains(T value)
  {
    Node<T>? current = this.head;

    while (current is not null && !current.value.Equals(value))
    {
      current = current.next;
    }

    return current.value;
  }

  public uint GetCount()
  {
    return this.count;
  }

  public void Clear()
  {
    this.head = null;
    this.tail = null;
    this.count = 0;
  }

  public void Print()
  {
    Node<T>? current = this.head;
    while (current is not null) {
      Console.Write(current.value + ", ");
      current = current.next;
    }
    Console.Write("\n");
  }
}