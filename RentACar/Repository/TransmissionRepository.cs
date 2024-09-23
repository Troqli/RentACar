
using RentACar.Models;

namespace RentACar.Repository;

public class TransmissionRepository : ITransmissionRepository
{
 private List<Transmission> _transmisson = new List<Transmission>()
 {
     new Transmission {Id = 1, Name = "Manuel"},
     new Transmission {Id = 2, Name = "Otomatik"}
 };
    public List<Transmission> GetAll()
    {
        return _transmisson;
    }
    public Transmission GetById(int id)
    {
        return _transmisson.FirstOrDefault(t => t.Id == id);
    }
    public void Add(Transmission transmission)
    {
        _transmisson.Add(transmission);
    }
    public void Update(Transmission transmission)
    {
        var existingTransmission = GetById((int)transmission.Id);
        if (existingTransmission != null)
        {
            existingTransmission.Name = transmission.Name;
        }
    }
    public void Delete(int id)
    {
        var transmission = GetById(id);
        if (transmission != null)
        {
            _transmisson.Remove(transmission);
        }
    }

}
