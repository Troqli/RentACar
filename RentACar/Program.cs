using RentACar.Models;
using RentACar.Repository;
using RentACar;
using System.ComponentModel.Design;

var carRepository = new CarRepository();
var fuelRepository = new FuelRepository();
var transmissionRepository = new TransmissionRepository();
var colorRepository = new ColorRepository();

// 1.Yönetim
carRepository.Add(new Car
{
    Id = 1,
    FuelId = 1,
    TransmissionId = 1,
    ColorId = 1,
    CarState = "Müsait",
    KiloMeter = 50000,
    ModelYear = 2020,
    Plate = "34 ABC 123",
    BrandName = "Toyota",
    ModelName = "Corolla",
    DailyPrice = 300
});
carRepository.Add(new Car
{
    Id = 2,
    FuelId = 2,
    TransmissionId = 2,
    ColorId = 3,
    CarState = "Dolu",
    KiloMeter = 150000,
    ModelYear = 2024,
    Plate = "34 ABS 323",
    BrandName = "Ford",
    ModelName = "Raptor",
    DailyPrice = 950
});
carRepository.Add(new Car
{
    Id = 3,
    FuelId = 3,
    TransmissionId = 2,
    ColorId = 1,
    CarState = "Dolu",
    KiloMeter = 50080,
    ModelYear = 2021,
    Plate = "34 ABZ 323",
    BrandName = "Ford",
    ModelName = "Tourner",
    DailyPrice = 670
});


//var carService = new CarService(carRepository, fuelRepository, transmissionRepository, colorRepository);

//var allCars = carService.GetAllDetails();
//foreach (var car in allCars)
//{
//    Console.WriteLine($"Marka: {car.BrandName}, Model: {car.ModelName}, Plaka: {car.Plate}, Kilometresi: {car.KiloMeter} Günlük Fiyatı: {car.DailyPrice}, Yakıt: {car.FuelName}, Vites Tipi: {car.TransmissionName}, Araç Durumu: {car.CarState}");
//}


// 2.Yönetim

var carService = new CarService(carRepository, fuelRepository, transmissionRepository, colorRepository);

Console.WriteLine("Araç arama: Marka veya model giriniz (Marka için 'Marka', Model için 'model' yazın): ");
string searchOption = Console.ReadLine();

if (searchOption == "Marka")
{
    Console.WriteLine("Aramak istediğiniz marka ismini girin: ");
    string brandName = Console.ReadLine();

    var carsByBrand = carService.GetAllDetailsByBrandNameContains(brandName);

    if (carsByBrand.Count > 0)
    {
        Console.WriteLine("Aradığınız markaya uygun araçlar:");
        foreach (var car in carsByBrand)
        {
            Console.WriteLine($"Marka: {car.BrandName}, Model: {car.ModelName}, Plaka: {car.Plate}, Kilometresi: {car.KiloMeter} Günlük Fiyatı: {car.DailyPrice}, Yakıt: {car.FuelName}, Vites Tipi: {car.TransmissionName}, Araç Durumu: {car.CarState}");
        }
    }
    else
    {
        Console.WriteLine("Bu marka ile eşleşen araç bulunamadı.");
    }
}
else if (searchOption == "Model")
{
    Console.WriteLine("Aramak istediğiniz model ismini girin: ");
    string modelName = Console.ReadLine();

    var carsByModel = carService.GetAllDetailsByModelNameContains(modelName);

    if (carsByModel.Count > 0)
    {
        Console.WriteLine("Aradığınız modele uygun araçlar:");
        foreach (var car in carsByModel)
        {
            Console.WriteLine($"Marka: {car.BrandName}, Model: {car.ModelName}, Plaka: {car.Plate}, Kilometresi: {car.KiloMeter} Günlük Fiyatı: {car.DailyPrice}, Yakıt: {car.FuelName}, Vites Tipi: {car.TransmissionName}, Araç Durumu: {car.CarState}");
        }
    }
    else
    {
        Console.WriteLine("Bu model ile eşleşen araç bulunamadı.");
    }
}
else
{
    Console.WriteLine("Geçersiz seçim. Lütfen 'brand' veya 'model' yazın.");
}

