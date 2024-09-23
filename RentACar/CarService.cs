using RentACar.Repository;
using RentACar;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IFuelRepository _fuelRepository;
    private readonly ITransmissionRepository _transmissionRepository;
    private readonly IColorRepository _colorRepository;

    public CarService(ICarRepository carRepository, IFuelRepository fuelRepository,
        ITransmissionRepository transmissionRepository, IColorRepository colorRepository)
    {
        _carRepository = carRepository;
        _fuelRepository = fuelRepository;
        _transmissionRepository = transmissionRepository;
        _colorRepository = colorRepository;
    }

    public List<CarDetailDto> GetAllDetails()
    {
        var cars = _carRepository.GetAll();
        return cars.Select(c => new CarDetailDto
        {
            Id = c.Id,
            FuelName = _fuelRepository.GetById(c.FuelId).Name,
            TransmissionName = _transmissionRepository.GetById(c.TransmissionId).Name,
            ColorName = _colorRepository.GetById(c.ColorId).Name,
            CarState = c.CarState,
            KiloMeter = c.KiloMeter,
            ModelYear = c.ModelYear,
            Plate = c.Plate,
            BrandName = c.BrandName,
            ModelName = c.ModelName,
            DailyPrice = c.DailyPrice
        }).ToList();
    }

    public List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName)
    {
        var cars = _carRepository.GetAll()
            .Where(c => c.BrandName != null && c.BrandName.Contains(brandName, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return cars.Select(c => new CarDetailDto
        {
            Id = c.Id,
            FuelName = _fuelRepository.GetById(c.FuelId).Name,
            TransmissionName = _transmissionRepository.GetById(c.TransmissionId).Name,
            ColorName = _colorRepository.GetById(c.ColorId).Name,
            CarState = c.CarState,
            KiloMeter = c.KiloMeter,
            ModelYear = c.ModelYear,
            Plate = c.Plate,
            BrandName = c.BrandName,
            ModelName = c.ModelName,
            DailyPrice = c.DailyPrice
        }).ToList();
    }

    public List<CarDetailDto> GetAllDetailsByColorId(int colorId)
    {
        throw new NotImplementedException();
    }

    public List<CarDetailDto> GetAllDetailsByFuelId(int fuelId)
    {
        throw new NotImplementedException();
    }

    public List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max)
    {
        throw new NotImplementedException();
    }

    public List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName)
    {
        var cars = _carRepository.GetAll()
            .Where(c => c.ModelName != null && c.ModelName.Contains(modelName, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return cars.Select(c => new CarDetailDto
        {
            Id = c.Id,
            FuelName = _fuelRepository.GetById(c.FuelId).Name,
            TransmissionName = _transmissionRepository.GetById(c.TransmissionId).Name,
            ColorName = _colorRepository.GetById(c.ColorId).Name,
            CarState = c.CarState,
            KiloMeter = c.KiloMeter,
            ModelYear = c.ModelYear,
            Plate = c.Plate,
            BrandName = c.BrandName,
            ModelName = c.ModelName,
            DailyPrice = c.DailyPrice
        }).ToList();
    }

    public List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max)
    {
        throw new NotImplementedException();
    }

    public CarDetailDto? GetDetailById(int id)
    {
        throw new NotImplementedException();
    }
}
