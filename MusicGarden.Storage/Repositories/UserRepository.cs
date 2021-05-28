using System;
using System.Collections.Generic;
using System.Linq;
using MusicGarden.Domain.Interfaces;
using MusicGarden.Domain.Models;

namespace MusicGarden.Storage.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private MusicGardenContext _con;
        public UserRepository(MusicGardenContext con)
        {
            _con = con;
        }
        public bool Destroy(User entry)
        {
            _con.Users.Remove(entry);
            return true;
        }

        public bool Insert(User entry)
        {
            _con.Users.Add(entry);
            return true;
        }

        public IEnumerable<User> Select(Func<User, bool> filter)
        {
            return _con.Users.Where(filter);
        }

        public User Upgrade()
        {
            throw new NotImplementedException();
        }
    }
}