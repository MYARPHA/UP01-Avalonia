using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork9
{
    public class UserService
    {
        private readonly AppDbContext _context;

        public UserService()
        {
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
        }

        public List<User> GetUsers() => _context.Users.ToList();

        public void AddUser(string login, string password)
        {
            var user = new User { Login = login, Password = password };
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            var user = _context.Users.Find(userId);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public void UpdateUser(int id, string login, string password)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                user.Login = login;
                user.Password = password;
                _context.SaveChanges();
            }
        }
    }
}
