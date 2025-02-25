using System;
class cons
{
    static int a;
    static int b,ans;
	public cons(){}
    public cons(int a1,int b1)
    {
        a=a1;
        b=b1;
    } 
    public  void sum()
    {
        ans= a+b;
	   
    }
    public static void Main()
    {
       //cons o1=new cons();
        cons o2=new cons(10,20);
		o2.sum();
		Console.WriteLine("sum is: "+ans);
        
    }
}
