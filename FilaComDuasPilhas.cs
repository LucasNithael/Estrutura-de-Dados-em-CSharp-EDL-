using System;
using System.Collections;

class Program{
  public static void Main(){
    Fila f = new Fila();
    Object[] array = new Object[f.p1.Count];
    f.Enqueue(1);
    f.Enqueue(2);
    f.Enqueue(3);
    f.Enqueue(4);

    Object[] a1 = f.p1.ToArray();
    
    
    Console.WriteLine("P1: ");
    foreach(Object i in a1)
      Console.Write(" "+i);

    f.Dequeue();
    Object[] a2 = f.p2.ToArray();
    Console.WriteLine("\nP2: ");
    foreach(Object i in a2)
      Console.Write(" "+i);

    f.Enqueue(5);
    f.Dequeue();
    a1 = f.p1.ToArray();
    Console.WriteLine("\nP1: ");
    foreach(Object i in a1)
      Console.Write(" "+i);
    
    
    Console.WriteLine("\nHá elemento? "+f.isEmpty());
    Console.WriteLine("Size: "+f.Size());
    Console.WriteLine("First: "+f.First());
  }
}

class Fila{
  public Stack p1 = new Stack();
  public Stack p2 = new Stack();
  public void Enqueue(object e){
    if(p1.Count==0)
      Inverter2();
    p1.Push(e);
  }
  public object Dequeue(){
    if(p1.Count!=0)
      Inverter1();
    return p2.Pop();
  }
  public object First(){
    if(p1.Count!=0)
      return p1.Peek();
    return p2.Peek();
  }
  public int Size(){
    return p2.Count+p1.Count;
  }
  public Boolean isEmpty(){
    return p1.Count!=p2.Count;
  }
  private void Inverter1(){
    for(int i=0; i<Size(); i++)
       p2.Push(p1.Pop());

    for(int i=0; i<Size(); i++)
      p1.Push(p2.Pop());
  }
}