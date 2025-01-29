class result
{
	static public void main(String args[])
	{
		int[] sub={97,89,98,90,88};
		int total=0;
		for(int a=0;a<5;a++)
		{
			System.out.println("sub "+a+": "+sub[a]);
			total+= sub[a];
		}
		int mark=total/5;
		System.out.println("Total is: "+ total);
		System.out.println("mark is: "+ mark);
		
		if(mark>=80 && mark<=100)
			System.out.println("excellent");
		if else(mark>=70 && mark<80)
			System.out.println("very good");
		if else(mark>=50 && mark<70)
			System.out.println("good");
		if else(mark>=32 && mark<50)
			System.out.println("keep work");
		else
			System.out.println("better luck next time");
			

		
	}
}