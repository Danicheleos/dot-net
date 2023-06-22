using System;
public interface IList<T>
{
  public Node<T> head { get; set; }
  public void Add(T value);
  public T[] ToArray();
  public void Remove(T value);
  public bool Contains(T value);
  public uint GetCount();
  public void Clear();
  public void Print();
}


