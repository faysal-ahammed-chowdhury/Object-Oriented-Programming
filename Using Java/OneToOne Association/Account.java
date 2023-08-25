import java.lang.*;

public class Account
{
	private int ano;
	private double balance;
	private static double maxLimit;
	private static double minLimit;
	
	
	
	public Account()
	{
		System.out.println("Empty Account");
	}
	public Account(int ano, double balance)
	{
		System.out.println("Param Account");
		this.ano = ano;
		this.balance = balance;
	}
	public void setAno(int ano)
	{
		this.ano = ano;
	}
	public void setBalance(double balance)
	{
		this.balance = balance;
	}
	public int getAno()
	{
		return ano;
	}
	public double getBalance()
	{
		return balance;
	}
	public void display()
	{
		System.out.println("Account no: "+ano);
		System.out.println("Balance: "+balance);
	}
	
	public void deposit(double amount)
	{
		if(amount>0 && (balance+amount)<=5000)
		{
			balance = balance+amount;
			System.out.println("Transaction successful");
		}
		else
		{
			System.out.println("Invalid amount");
		}
		
	}
	public void withdraw(double amount)
	{
		if(amount>0 && amount<=balance && (balance-amount)>=500)
		{
			balance = balance-amount;
			System.out.println("Transaction successful");
		}
		else
		{
			System.out.println("Invalid amount");
		}
	}
	public void transfer(Account a, double amount)
	{
		this.balance = this.balance - amount;
		a.balance = a.balance + amount;
	}
	static
	{
		System.out.println("Inside static block");
		maxLimit = 5000;
		minLimit = 500;
	}
}