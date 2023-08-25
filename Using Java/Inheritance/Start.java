import java.lang.*;

public class Start {
    public static void main(String[] args) {
        // set class variable value for all object
        StoryBook.setDiscountRate(50);

        // object 1 for "StoryBook"
        System.out.println("");
        StoryBook sb1 = new StoryBook();
        sb1.setIsbn("1");
        sb1.setBookTitle("Tukunjil");
        sb1.setAuthorName("Jafor Iqbal");
        sb1.setPrice(500);
        sb1.setAvaiableQuantity(50);
        sb1.setCategory("Science Fiction");
        sb1.addQuantity(20);
        sb1.sellQuantity(10);

        System.out.println("Story Book \"" + sb1.getBookTitle() + "\" Details:");
        System.out.println("ISBN: "+sb1.getIsbn());
        System.out.println("Book Title: "+sb1.getBookTitle());
        System.out.println("Author Name: "+sb1.getAuthorName());
        System.out.println("Price: "+sb1.getPrice());
        System.out.println("Avaiable Quantity: "+sb1.getAvailableQuantity());
        System.out.println("Category: "+sb1.getCategory());
        System.out.println("Discount Rate: "+sb1.getDiscountRate());

        // object 2 for "StoryBook"
        System.out.println("");
        StoryBook sb2 = new StoryBook("2", "Beji", "Jafor Iqbal", 700, 40, "Science Fiction");
        sb2.showDetails();

        // set class variable value for all object
        TextBook.setDiscountRate(20);

        // object 1 for "TextBook"
        System.out.println("");
        TextBook tb1 = new TextBook();
        tb1.setIsbn("3");
        tb1.setBookTitle("Fundamentals of Physics");
        tb1.setAuthorName("Jearl Walker");
        tb1.setPrice(1500);
        tb1.setAvaiableQuantity(100);
        tb1.setStandard(5);
        tb1.addQuantity(20);
        tb1.sellQuantity(10);

        System.out.println("Text Book \"" + tb1.getBookTitle() + "\" Details:");
        System.out.println("ISBN: "+tb1.getIsbn());
        System.out.println("Book Title: "+tb1.getBookTitle());
        System.out.println("Author Name: "+tb1.getAuthorName());
        System.out.println("Price: "+tb1.getPrice());
        System.out.println("Avaiable Quantity: "+tb1.getAvailableQuantity());
        System.out.println("Standard: "+tb1.getStandard());
        System.out.println("Discount Rate: "+tb1.getDiscountRate());

        // object 2 for "TextBook"
        StoryBook.setDiscountRate(50);
        System.out.println("");
        TextBook tb2 = new TextBook("4", "CONCRETE MATHEMATICS", "Ronald L. Graham", 2700, 70, 6);
        tb2.showDetails();
    }
}