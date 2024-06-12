using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EnergyDashboardApp.Models;

namespace EnergyDashboardApp.Repository
{
    public class EnergyRepository : IEnergyRepository
    {
        private readonly AppDbContext _dbContext;

        public EnergyRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<EnergyData> GetAll()
        {
            // Implement logic to fetch all energy data from the database
            // Example:
             return _dbContext.EnergyData.ToList();
        }

        public EnergyData GetById(int id)
        {
            // Implement logic to fetch energy data by id from the database
            // Example:
             return _dbContext.EnergyData.FirstOrDefault(e => e.UserID == id);
        }

        public void Create(EnergyData energyData)
        {
            // Implement logic to add energy data to the database
            // Example:
             _dbContext.EnergyData.Add(energyData);
             _dbContext.SaveChanges();
        }

        public void Update(EnergyData energyData)
        {
            // Implement logic to update energy data in the database
            // Example:
             _dbContext.EnergyData.Update(energyData);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            // Implement logic to delete energy data from the database
            // Example:
            var energyData = _dbContext.EnergyData.FirstOrDefault(e => e.UserID == id);
            if (energyData != null)
            {
                _dbContext.EnergyData.Remove(energyData);
               _dbContext.SaveChanges();
             }
        }
    }
}
