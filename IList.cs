using System;
public interface IList<T>
{
	public void Add(T value);
	public T getValue();
	public T[] toArray();
    public void Remove(T value);
    public void next();
    public Boolean Contains(T value);
	public uint Count();
	public void Clear();
	public void Print();
}


