using RentACar.Models;
using RentACar.Repository;

public class CarRepository : ICarRepository
{
    private List<Car> _cars = new List<Car>(); 

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car GetById(int id)
    {
        return _cars.FirstOrDefault(c => c.Id == id);
    }

    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Update(Car car)
    {
        var existingCar = GetById(car.Id);
        if (existingCar != null)
        {
            existingCar.ColorId = car.ColorId;
            existingCar.FuelId = car.FuelId;
        }
    }

    public void Delete(int id)
    {
        var car = GetById(id);
        if (car != null)
        {
            _cars.Remove(car);
        }
    }
}

