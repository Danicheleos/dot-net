﻿using System;


public class Node<T>
{
  public T value;
  public Node<T> next;
  public Node<T> prev;

  public Node(T value)
  {
    this.value = value;
  }
}

