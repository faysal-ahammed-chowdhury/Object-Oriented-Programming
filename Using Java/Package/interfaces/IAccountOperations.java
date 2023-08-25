package interfaces;
import classes.*;

public interface IAccountOperations
{
	public abstract void deposit(double amount);
	void withdraw(double amount);
	void transfer(Account a, double amount);
	void showDetails();
}