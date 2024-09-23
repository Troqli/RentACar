
namespace RentACar;

public interface ICarService
{
    List<CarDetailDto> GetAllDetails();
    List<CarDetailDto> GetAllDetailsByFuelId(int fuelId);
    List<CarDetailDto> GetAllDetailsByColorId(int colorId);
    List<CarDetailDto> GetAllDetailsByPriceRange(double min, double max);
    List<CarDetailDto> GetAllDetailsByBrandNameContains(string brandName);
    List<CarDetailDto> GetAllDetailsByModelNameContains(string modelName);
    CarDetailDto? GetDetailById(int id);
    List<CarDetailDto> GetAllDetailsByKilometerRange(int min, int max);
}
