using System.Collections.Generic;
using System.Linq;
using MeetingRoom.core.Models;

namespace MeetingRoom.Core.Repositories
{
    public class ReservationRepository
    {
        private readonly MeetingRoomDbContext _context;

        public ReservationRepository(MeetingRoomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Reservation> GetAll()
        {
            return _context.Reservations.ToList();
        }

        public Reservation GetById(int id)
        {
            return _context.Reservations.FirstOrDefault(reservation => reservation.ReservationId == id);
        }

        public void Insert(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public void Update(Reservation reservation)
        {
            _context.Reservations.Update(reservation);
            _context.SaveChanges();
        }

        public void Delete(Reservation reservation)
        {
            _context.Reservations.Remove(reservation);
            _context.SaveChanges();
        }
    }
}
