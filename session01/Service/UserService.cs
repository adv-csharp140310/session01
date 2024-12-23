using session01.DataSource;
using session01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session01.Service;
public class UserService
{
    public int UserCount { get => InMemoryDaraSource.Users.Count; }
    public User GetByIndex(int index)
    {
        return InMemoryDaraSource.Users[index];
    }

    public void Add (User user)
    {
        InMemoryDaraSource.Users.Add(user);
    }

    public void Update(User user, int index)
    {
        InMemoryDaraSource.Users[index] = user;
    }

    public void Remove(int index)
    {
        InMemoryDaraSource.Users.RemoveAt(index);
    }
}
