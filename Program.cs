namespace StopWatch;

public class Program
{
    public static void displayMenu()
    {
        Console.WriteLine("****************************" +
                          "\n1- Start the chronometer" +
                          "\n2- Stop the chronometer" +
                          "\n3- Quit" +
                          "\n****************************");
    }

    public static int takeInputChoice()
    {
        Console.Write("Enter a choice: ");
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || !isValidChoice(choice))
        {
            Console.Write("Your choice is invalid. Try again: ");
        }
        return choice;
    }
    
    public static Boolean isValidChoice(int choice)
    {
        return (choice <= 3 && choice >= 1);
    }
    
    public static void Main(string[] args)
    {
        var sw1 = new Stopwatch();
        
        TimeSpan duration;
        int choice;
        do
        {
            displayMenu();
            choice = takeInputChoice();
            switch (choice)
            {
                case 1 :
                    sw1.start();
                    Console.WriteLine("Your StopWatch successfully started.");
                    break; 
                case 2 :
                    sw1.stop();
                    break;
            }
        } while (choice != 3);
        Console.WriteLine("Thank you for using StopWatchPro");
    }
}

