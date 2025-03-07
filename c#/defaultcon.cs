using System;
class xyz
{
    public xyz()
    {
        Console.WriteLine("cons");
    }
    
    int a;

    void fun()
    {
        Console.WriteLine(a);

    }
    public static void Main()
    {
        xyz obj1=new xyz();
        xyz obj2=new xyz();
        obj1.a=10;
        obj1.fun();
        obj2.a=20;
        obj2.fun();
        Console.WriteLine("hello");
        Console.Read();
    }
}