import java.lang.*;

public class Start
{
	public static void main(String[] args)
	{
		Account a1 = new FixedAccount(111, 2000, 5);
		Account a2 = new SavingsAccount(222, 1500, 1.5);
		
		//Account a3 = new Account(333, 2500);
		
		
		Customer c1 = new Customer("John", 101, 2);
		c1.addAccount(a1);
		c1.addAccount(a2);
		c1.display();
		
		
		
	}
}