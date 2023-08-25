using System.Collections.Generic;
using System.Linq;
using MeetingRoom.core.Models;


namespace MeetingRoom.Core.Repositories
{
    public class UserRepository
    {
        private readonly MeetingRoomDbContext _context;

        public UserRepository(MeetingRoomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(user => user.UserId == id);
        }

        public void Insert(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
