using Microsoft.EntityFrameworkCore;
using Sailing.Core.Repository;
using SAILING_BEACH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sailing.Data.Repository
{
    public class BoatDriverRepository : IBoatDriveRepository
    {

        private readonly Context _context;
        public BoatDriverRepository(Context context)
        {
            _context = context;
        }
        public  List<BoatDriver> GetBoatDrivers()
        {
            return  _context.BoatDrivers.ToList();
        }

        public async Task<BoatDriver> GetBoatDriverById(int id)
        {
           var boatDriver = _context.BoatDrivers.Find(id);
            await _context.SaveChangesAsync();
            return boatDriver;
        }


        public async Task<BoatDriver> AddBoatDriver(BoatDriver boatDriver)
        {
            _context.BoatDrivers.Add(boatDriver);
            await _context.SaveChangesAsync();
            return  boatDriver;
        }

        public async Task<BoatDriver> UpdateBoatDriver(int id, BoatDriver boatDriver)
        {
            var boatDrive = _context.BoatDrivers.Find(id);
            boatDrive.FirstName = boatDriver.FirstName;
            boatDrive.LastName = boatDriver.LastName;
            boatDrive.Age = boatDriver.Age;
            boatDrive.Salary = boatDriver.Salary;
            boatDrive.Seniority = boatDriver.Seniority;
            await _context.SaveChangesAsync();
            return  boatDrive;
        }

        public void DeleteBoatDriver(int id)
        {
            _context.BoatDrivers.Remove(_context.BoatDrivers.Find(id));
             _context.SaveChanges();
        }
    }

}
