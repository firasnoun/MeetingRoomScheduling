using MeetingRoom.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;


namespace MeetingRoom.core.Repositories
{
    public class CompanyRepository
    {
        private readonly MeetingRoomDbContext _context;

        public CompanyRepository(MeetingRoomDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Company> GetAll()
        {
            return _context.Companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.Companies.FirstOrDefault(company => company.CompanyId == id);
        }

        public void Insert(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public void Update(Company company)
        {
            _context.Companies.Update(company);
            _context.SaveChanges();
        }

        public void Delete(Company company)
        {
            _context.Companies.Remove(company);
            _context.SaveChanges();
        }
    }
}
