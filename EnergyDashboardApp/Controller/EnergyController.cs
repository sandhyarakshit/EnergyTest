using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using EnergyDashboardApp.Models;

namespace EnergyDashboardBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnergyController : ControllerBase
    {
         private readonly IEnergyService _energyService;

    public EnergyController(IEnergyService energyService)
    {
        _energyService = energyService;
    }

        // GET: api/Energy
        [HttpGet]
        public ActionResult<IEnumerable<EnergyData>> GetEnergyData()
        {
            return Ok(_energyService.GetAllEnergyData());
        }

        // GET: api/Energy/5
        [HttpGet("{id}")]
        public ActionResult<EnergyData> GetEnergyData(int id)
        {
            var energyData = _energyService.GetEnergyDataById(id);

            if (energyData == null)
            {
                return NotFound();
            }

            return Ok(energyData);
        }

        // POST: api/Energy
        [HttpPost]
        public ActionResult<EnergyData> PostEnergyData(EnergyData energyData)
        {
            _energyService.CreateEnergyData(energyData);

            return CreatedAtAction(nameof(GetEnergyData), new { id = energyData.UserID }, energyData);
        }

        // PUT: api/Energy/5
        [HttpPut("{id}")]
        public IActionResult PutEnergyData(int id, EnergyData energyData)
        {
            if (id != energyData.UserID)
            {
                return BadRequest();
            }

            _energyService.UpdateEnergyData(energyData);

            return NoContent();
        }

        // DELETE: api/Energy/5
        [HttpDelete("{id}")]
        public IActionResult DeleteEnergyData(EnergyData energyData)
        {
            var existingEnergyData = _energyService.GetEnergyDataById(energyData.UserID);

            if (existingEnergyData == null)
            {
                return NotFound();
            }

            //_energyService.DeleteEnergyData(existingEnergyData);

            return NoContent();
        }
    }
}