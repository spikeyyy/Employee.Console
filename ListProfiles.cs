using Employee.Console;

public class ListProfiles
{
    private List<Profile> profiles;

    public ListProfiles()
    {
        profiles = new List<Profile>
        {
            new Profile(1, "Nathalia", "Bayley", "Minor", "Nathalia_Minor@gmail.com", GenderEnum.Female, new DateTime(1990, 3, 2), true),
            new Profile(2, "Lawrence", "Marquise", "Harlow", "Lawrence_Harlow@gmail.com", GenderEnum.Male, new DateTime(1994, 6, 5), true),
            new Profile(3, "Lana", "Jaidyn", "Houghton", "Lana_Houghton@gmail.com", GenderEnum.Female, new DateTime(2001, 12, 23), false),
            new Profile(4, "Kaya", "Vanesa", "Gallant", "Kaya_Gallant@gmail.com", GenderEnum.Female, new DateTime(2010, 7, 6), true),
            new Profile(5, "Bryant", "Immanuel", "Kirsch", "Bryant_Kirsch@gmail.com", GenderEnum.Male, new DateTime(2005, 8, 25), false),
            new Profile(6, "Lacie", "Madalyn", "Artis", "Lacie_Artis@gmail.com", GenderEnum.Female, new DateTime(1984, 1, 10), false),
            new Profile(7, "Debra", "Brieanna", "Mackey", "Debra_Mackey@gmail.com", GenderEnum.Female, new DateTime(1988, 6, 1), true),
            new Profile(8, "Eve", "Camille", "Hofmann", "Eve_Hofmann@gmail.com", GenderEnum.Female, new DateTime(1996, 9, 14), true),
            new Profile(9, "Bree", "Alma", "Trent", "Bree_Trent@gmail.com", GenderEnum.Female, new DateTime(1991, 4, 4), false),
            new Profile(10, "Valeria", "Olivia", "Wegner", "Valeria_Wegner@gmail.com", GenderEnum.Female, new DateTime(2006, 6, 6), true)
        };
    }

    //method to display the records
    public void DisplayProfiles()
    {
        foreach (var profile in profiles)
        {
            Console.WriteLine(profile);
        }
    }

    //method to count the total users
    public int UserTotalCount()
    {
        return profiles.Count();
    }

    //method to get the number of active users
    // public int TotalActive Users()
    // {
    //     return profiles.
    // }
}
