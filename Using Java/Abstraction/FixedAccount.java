import java.lang.*;


public class FixedAccount extends Account
{
	private int tenureYear;
	
	public FixedAccount()
	{
		
	}
	public FixedAccount(int ano, double balance, int tenureYear)
	{
		super(ano, balance);
		this.tenureYear = tenureYear;
	}
	
	public void setTenureYear(int tenureYear)
	{
		this.tenureYear = tenureYear;
	}
	public int getTenureYear()
	{
		return tenureYear;
	}
	public void showDetails()
	{
		System.out.println("Account no: "+ano);
		System.out.println("Balance: "+balance);
		System.out.println("Tenure Year: "+tenureYear);
	}
}