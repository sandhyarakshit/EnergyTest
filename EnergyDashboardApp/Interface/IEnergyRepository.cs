using System.Collections.Generic;
using EnergyDashboardApp.Models;


public interface IEnergyRepository
{
    IEnumerable<EnergyData> GetAll();
    EnergyData GetById(int id);
    void Create(EnergyData energyData);
    void Update(EnergyData energyData);
    void Delete(int id);
}