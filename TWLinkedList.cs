using System;

public class TWLinkedList<T> : IList<T>
{
  public Node<T>? head { get; set; }
  private Node<T>? tail;
  private uint count = 0;

  public TWLinkedList()
  {
    this.head = null;
  }

  public TWLinkedList(T value)
  {
    this.head = new Node<T>(value);
    this.tail = this.head;
    this.count = 1;
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

    if (count == 0)
    {
      this.head = new Node<T>(value);
      this.tail = this.head;
      this.count = 1;
      return;
    }

    this.tail.next = newNode;
    newNode.prev = this.tail;
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
      this.head.prev = null;
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
    current.prev = previuos;
  }

  public Boolean Contains(T value)
  {
    Node<T>? current = this.head;

    while (current is not null && !current.value.Equals(value))
    {
      current = current.next;
    }

    return current is not null;
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