import java.lang.*;

public class Customer
{
	private String name;
	private int cid;
	private Account acc;
	
	public Customer(String name, int cid, Account acc)
	{
		this.name = name;
		this.cid = cid;
		this.acc = acc;
	}
	public void performDeposit(double amount)
	{
		acc.deposit(amount);
	}
	public void display()
	{
		System.out.println("Name: "+name);
		System.out.println("CustomerID: "+cid);
		acc.display();
		
	}
}