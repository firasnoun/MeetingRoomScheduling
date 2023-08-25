using System.Collections.Generic;
using System.Linq;
using MeetingRoom.core.Models;


namespace MeetingRoom.Core.Repositories
{
    public class RoomRepository
    {
        private readonly MeetingRoomDbContext _context;

        public RoomRepository(MeetingRoomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Room> GetAll()
        {
            return _context.Rooms.ToList();
        }

        public Room GetById(int id)
        {
            return _context.Rooms.FirstOrDefault(room => room.RoomId == id);
        }

        public void Insert(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void Update(Room room)
        {
            _context.Rooms.Update(room);
            _context.SaveChanges();
        }

        public void Delete(Room room)
        {
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }
    }
}
