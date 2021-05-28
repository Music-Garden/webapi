using System;
using System.Collections.Generic;
using MusicGarden.Domain.Interfaces;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage.Repositories
{
  public class UserRepository : IRepository<User>
  {
    public bool Destroy(User entry)
    {
      throw new NotImplementedException();
    }

    public bool Insert(User entry)
    {
      throw new NotImplementedException();
    }

    public IEnumerable<User> Select(Func<User, bool> filter)
    {
      throw new NotImplementedException();
    }

    public User Upgrade()
    {
      throw new NotImplementedException();
    }
  }
}