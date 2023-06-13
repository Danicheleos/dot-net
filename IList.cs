using System;
public interface IList<T>
{
	public void add(T value);
	public T getValue();
	public T[] toArray();
    public void remove(T value);
    public void next();
    public Boolean contains(T value);
	public uint getCount();
	public void clear();
	public void print();
}


