import java.lang.*;

public class SavingsAccount extends Account
{
	private double interestRate;
	
	public SavingsAccount()
	{
		
	}
	public SavingsAccount(int ano, double balance, double interestRate)
	{
		super(ano, balance);
		this.interestRate = interestRate;
	}
	public void setInterestRate(double interestRate)
	{
		this.interestRate = interestRate;
	}
	public double getInterestRate()
	{
		return interestRate;
	}
	public void showDetails()
	{
		System.out.println("Account no: "+ano);
		System.out.println("Balance: "+balance);
		System.out.println("Interest Rate: "+interestRate);
	}
}