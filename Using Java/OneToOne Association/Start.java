import java.lang.*;

public class Start
{
	public static void main(String[] args)
	{
		Account a1 = new Account(111, 2000);
		Customer c1 = new Customer("Bruce Wayne", 101, a1);
		c1.display();
		c1.performDeposit(1000);
		c1.display();
		
	}
}
