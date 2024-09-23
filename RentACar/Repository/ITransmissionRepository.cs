
using RentACar.Models;

namespace RentACar.Repository;

public interface ITransmissionRepository 
{
    List<Transmission> GetAll();
    Transmission GetById(int id);
    void Add(Transmission transmission);
    void Update(Transmission transmission);
    void Delete(int id);

}
