import java.lang.*;

public class Start
{
	public static void main(String[] args)
	{
		Person p1 = new Person();
		p1.setName("Faysal Ahammed Chowdhury");
		p1.setAge(20);
		p1.display();
		
		Person p2 = new Person();
		p2.setName("Faiyaz Ahammed Chowdhury");
		p2.setAge(15);
		// p2.display();
		System.out.println("Name: " + p2.getName());
		System.out.println("Age: " +p2.getAge());
	}
}