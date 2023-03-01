// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete;
using System;
namespace ConsoleUI
{
    class program
    {
        static void Main(string[] args)

        {
            CarManager carManager= new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("Model: "+ car.Description +" / "+"Model Yılı: "+ car.ModelYear 
                +" / "+"Günlük Kiralama Fiyatı: "+ car.DailyPrice +" / "+ "(Renk: " + car.ColorId 
                +" "+"ID: "+car.Id+" "+"BrandId: "+car.BrandId+" )");
                
            }
        }

    }

}
