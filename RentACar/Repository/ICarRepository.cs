﻿using RentACar.Models;

namespace RentACar.Repository;

public interface ICarRepository
{
    List<Car> GetAll();
    Car GetById(int id);
    void Add(Car car);
    void Update(Car car);
    void Delete(int id);
}
