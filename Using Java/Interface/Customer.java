import java.lang.*;
public class Customer implements ICustomerOperations
{
	private String name;
	private int cusID;
	private Account accounts[];
	
	public Customer()
	{
		
	}
	public Customer(String name, int cusID, int num)
	{
		this.name = name;
		this.cusID = cusID;
		accounts = new Account[num];
	}
	public void addAccount(Account a)
	{
		int check = 0;
		for(int i=0; i<accounts.length; i++)
		{
			if(accounts[i]==null)
			{
				accounts[i] = a;
				check = 1;
				break;
			}
		}
		if(check == 1)
		{
			System.out.println("Account added!");
		}
		else
		{
			System.out.println("Account not added!");
		}
	}
	public void deleteAccount(Account a)
	{
		int check = 0;
		for(int i=0; i<accounts.length; i++)
		{
			if(accounts[i]==a)
			{
				accounts[i] = null;
				check = 1;
				break;
			}
		}
		if(check == 1)
		{
			System.out.println("Account deleted!");
		}
		else
		{
			System.out.println("Account not deleted!");
		}
	}
	
	public void searchAccount(Account a)
	{
		int check = 0;
		for(int i=0; i<accounts.length; i++)
		{
			if(accounts[i]==a)
			{
				check = 1;
				break;
			}
		}
		if(check == 1)
		{
			System.out.println("Account found!");
		}
		else
		{
			System.out.println("Account not found!");
		}
	}
	
	public void performDeposit(Account a, double amount)
	{
		//acc.deposit(amount);
		int check = 0;
		for(int i=0; i<accounts.length; i++)
		{
			if(accounts[i]==a)
			{
				accounts[i].deposit(amount);
				check = 1;
				break;
			}
		}
		if(check == 1)
		{
			System.out.println("Deposited!");
		}
		else
		{
			System.out.println("Not Deposited!");
		}
		
		
	}
	public void performWithdraw(double amount)
	{
		//acc.withdraw(amount);
	}
	public void display()
	{
		System.out.println("Name: "+name);
		System.out.println("Customer ID: "+cusID);
		System.out.println("Account details: ");
		//acc.display();
		for(int i=0; i<accounts.length; i++)
		{
			if(accounts[i]!=null)
			{
				accounts[i].showDetails();
			}
			else
			{
				System.out.println("Account might have been deleted or not created yet!");
			}
			
		}
	}
}