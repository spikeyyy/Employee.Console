class Program
{
    public static void Main(string[] args)
    {
        ListProfiles listProfiles = new ListProfiles();
        listProfiles.DisplayProfiles();

        //to count the total users
        int profileCount = listProfiles.UserTotalCount();
        Console.WriteLine($"User Total Count: {profileCount}");
    }
}