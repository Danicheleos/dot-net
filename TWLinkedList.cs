using System;

public class TWLinkedList<T> : IList<T>
{
    private Node<T>? head;
    private Node<T>? tail;
    private uint count = 0;

    public TWLinkedList()
    {
        this.head = null;
    }

    public TWLinkedList(T value)
    {
        this.head = new Node<T>(value);
    }

    public T getValue()
    {
        return this.head.value;
    }

    public T[] toArray()
    {
        T[] array = new T[this.count];
        Node<T> head = this.head;

        for (int index = 0; index < this.count; index++)
        {
            array[index] = head.value;
            head = head.next;
        }

        return array;
    }

    public void next()
    {
        this.head = this.head.next;
        this.tail = this.tail.next;
    }


    public void prev()
    {
        this.head = this.head.prev;
    }

    public void add(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (count == 0)
        {
            newNode.next = newNode;
            newNode.prev = newNode;
            this.tail = newNode;
            this.head = newNode;
            this.count++;
            return;
        }

        newNode.prev = this.tail;
        newNode.next = this.head;
        this.head.prev = newNode;
        this.tail.next = newNode;
        this.head = newNode;

        this.count++;

    }

    public void remove(T value)
    {
        Node<T>? head = this.head;
        Node<T>? previuos = null;

        if (head is null || head.value is null) return;

        if (head.value.Equals(value))
        {
            this.head = this.head.next;
            this.tail.next = this.head;
            count--;
            return;
        }


        while (head is not null && !head.value.Equals(value))
        {
            previuos = head;
            head = head.next;
        }

        if (head is null || previuos is null) return;

        this.count--;
        head.prev = previuos;
        previuos.next = head.next;
    }

    public Boolean contains(T value)
    {
        Node<T>? head = this.head;

        do
        {
            if (head is not null && head.value.Equals(value)) return true;
            head = head.next;
        } while (head is not null);

        return false;
    }

    public uint getCount()
    {
        return this.count;
    }

    public void clear()
    {
        this.head = null;
        this.tail = null;
        this.count = 0;
    }


    public void print()
    {
        Node<T>? head = this.head;
        for (int index = 0; index < this.count; index++)
        {
            Console.Write(head.value + ", ");
            head = head.next;
        }
        Console.Write("\n");
    }
}