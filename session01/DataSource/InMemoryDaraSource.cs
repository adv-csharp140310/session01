using session01.Model;

namespace session01.DataSource;
public static class InMemoryDaraSource
{
    public static List<User> Users { get; set; } = new List<User>()
    {
        new User {Id =1, FirstName="Ali 1", LastName = "Mohamadi 1", Email = "Ali1@gmail.com", Tel="222"},
        new User {Id =1, FirstName="Ali 2", LastName = "Mohamadi 2", Email = "Ali2@gmail.com", Tel="222"},
        new User {Id =1, FirstName="Ali 3", LastName = "Mohamadi 3", Email = "Ali3@gmail.com", Tel="222"},
    };
}
