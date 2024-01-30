using Sailing.Core.Repositoies;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailing.Data.Repositories
{
    public class BoatDriverRepository : IBoatDravierRepository
    {
        private readonly DataContext _context;

        public BoatDriverRepository(DataContext context)
        {
            _context = context;
        }

        public List<BoatDriver> GetBoatDrivers()
        {
            return _context.boatDrivers.ToList();
        }

        public BoatDriver GetByIdBoatDriver(int id)
        {
           return _context.boatDrivers.Find(id);
        }

        public BoatDriver AddBoatDriver(BoatDriver boatDriver)
        {
            _context.boatDrivers.Add(boatDriver);
            _context.SaveChanges();
            return boatDriver;
        }

        public BoatDriver UpdateBoatDriver(int id, BoatDriver boatDriver)
        {
            var updateBoatDriver=GetByIdBoatDriver(id);

            updateBoatDriver.FirstName=boatDriver.FirstName;
            updateBoatDriver.LastName=boatDriver.LastName;
            updateBoatDriver.Age=boatDriver.Age;
            updateBoatDriver.Salary = boatDriver.Salary;
            updateBoatDriver.Seniority=boatDriver.Seniority;
            updateBoatDriver.Experience=boatDriver.Experience;

            return updateBoatDriver;
        }

        public void DeleteBoatDriver(int id)
        {
            _context.boatDrivers.Remove(_context.boatDrivers.Find(id));
            _context.SaveChanges();
        }

    }
}
