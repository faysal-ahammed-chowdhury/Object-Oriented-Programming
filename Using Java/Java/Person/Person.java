import java.lang.*;

public class Person
{
	private String name;
	private int age;
	
	public void setName(String n)
	{
		name=n;
	}
	public void setAge(int a)
	{
		age=a;
	}
	
	public String getName()
	{
		return name;
	}
	public int getAge()
	{
		return age;
	}
	
	public void display()
	{
		System.out.println("Name: "+name);
		System.out.println("Age: "+age);
	}
}