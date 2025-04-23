namespace Lab5;

class Program
{
    static void Main(string[] args)
    {
    //Problem 1
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };

        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }
    
    //Problem 2
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        foreach (string day in days)
        {
            Console.WriteLine("Day: " + day);
        }

        Console.Write("Enter a number 1-7: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine("The day of the week is: " + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 1-7");
        }
    //Problem 3
    string[] books = { "The Great Gatsby", "1984", "The Catcher in the Rye" };  
    
    string[] authors = { "F. Scott Fitzgerald", "George Orwell", "J.D. Salinger" };
    
    for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }
    }

}

