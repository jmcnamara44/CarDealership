using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private string _brand;
    private string _model;
    private int _year;
    private int _mileage;
    private static List<Car> _carcars = new List<Car> {};

    public Car (string brand, string model, int year, int mileage)
    {
      _brand=brand;
      _model=model;
      _year=year;
      _mileage=mileage;
    }

    public string GetBrand()
    {
      return _brand;
    }
    public void SetBrand(string newBrand)
    {
      _brand=newBrand;
    }
    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model=newModel;
    }
    public int GetYear()
    {
      return _year;
    }
    public void SetYear(int newYear)
    {
      _year=newYear;
    }
    public int GetMileage()
    {
      return _mileage;
    }
    public void SetMileage(int newMileage)
    {
      _mileage=newMileage;
    }
    public static List<Car> GetAll()
    {
      return _carcars;
    }
    public void Save()
    {
      _carcars.Add(this);
    }
    public static void ClearAll()
    {
      _carcars.Clear();
    }

  }
}
