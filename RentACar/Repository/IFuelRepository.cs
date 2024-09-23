
using RentACar.Models;

namespace RentACar.Repository;

public interface IFuelRepository
{
    List<Fuel> GetAll();
    Fuel GetById(int id);
    void Add (Fuel fuel);
    void Update(Fuel fuel);
    void Delete(int id);
 }
