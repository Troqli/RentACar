
using RentACar.Models;

namespace RentACar.Repository;

public class FuelRepository : IFuelRepository
{
    private List<Fuel> _fuels = new List<Fuel>
    {
        new Fuel {Id = 1, Name = "Benzin"},
        new Fuel {Id = 2, Name = "Dizel"},
        new Fuel {Id = 3, Name = "Elektrik"},
    };

    public List<Fuel> GetAll()
    {
        return _fuels;
    }

    public Fuel GetById(int id)
    {
        return _fuels.FirstOrDefault(f => f.Id == id);
    }

    public void Add(Fuel fuel)
    {
        _fuels.Add(fuel);
    }
    public void Update(Fuel fuel)
    {
        var existingFuel = GetById(fuel.Id);
        if (existingFuel != null)
        {
            existingFuel.Name = fuel.Name;
        }
    }
    public void Delete(int id)
    {
        var fuel = GetById(id);
        if (fuel != null)
        {
            _fuels.Remove(fuel);
        }
    }
}
