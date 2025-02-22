﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager efCarManager = new CarManager(new EfCarDal());
            BrandManager efBrandManager = new BrandManager(new EfBrandDal());
            ColorManager efColorManager = new ColorManager(new EfColorDal());
            //ICarDal inMemoryCarDal = new InMemoryCarDal();

            //CarManager carManager = new CarManager(inMemoryCarDal);
            //inMemoryCarDal.Add(new Car { Id = 6, BrandId = 5, ColorId = 2, DailyPrice = 999000, ModelYear = "2021", Description = "White Tesle Model S" }); // Added Tesla
            //Console.WriteLine("Number Of Cars: {0}", carManager.GetAll().Count);


            //foreach (var x in carManager.GetAll())
            //{
            //    Console.WriteLine($"Car Brand: {x.BrandId} -- Model: {x.ModelYear} -- Price: {x.DailyPrice} -- Color Code: {x.ColorId} -- Description: {x.Description}");
            //}


            //Console.WriteLine("------------------");

            //inMemoryCarDal.Delete(new Car{ Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 20000, ModelYear = "2010", Description = "Black Ford Focus" }); // Deleted Ford Focus (Id 1)
            //Console.WriteLine("Number of Cars : {0}",carManager.GetAll().Count);
            //foreach (var x in carManager.GetAll())
            //{
            //    Console.WriteLine($"Car Brand: {x.BrandId} -- Model: {x.ModelYear} -- Price: {x.DailyPrice} -- Color Code: {x.ColorId} -- Description: {x.Description}");
            //}




            //efCarDal.Update(carornek);
            //foreach (var x in efCarManager.GetAll())
            //{
            //    Console.WriteLine(x.Details+" "+x.CarId);

            //}

            //Console.WriteLine("---------");

            ////efCarManager.Delete(1011); // It deletes the car for Carid Number




            //Console.WriteLine("-------");

            //Color colorOrnek = new Color();
            //colorOrnek.ColorId = 6;
            //colorOrnek.ColorName = "Lacivert";
            //var result = efColorManager.Get(4);
            //Console.WriteLine(result.ColorName);
            //Console.WriteLine("-----");
            //foreach (var x in efColorManager.GetAll())
            //{
            //    Console.WriteLine(x.ColorId+"-"+x.ColorName);
            //}
            Console.WriteLine("-----------");
            var result = efCarManager.GetCarDetails(); // Car Dto class'ını Listele ve Mesajını Göster
            if (result.Success == true)
            {
                foreach (var x in result.Data)
                {
                    Console.WriteLine(x.CarId + "---" + x.ColorName + "----" + x.Details + "----" + x.BrandName);
                }

                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }



            Console.WriteLine("------------");
            var result2 = efColorManager.GetAll(); // Color class'ını Listele ve Mesajını Göster
            if (result2.Success == true)
            {
                foreach (var x in result2.Data)
                {
                    Console.WriteLine(x.ColorName + "--" + x.ColorId);
                }

                Console.WriteLine(result2.Message);
            }
            else
            {
                Console.WriteLine(result2.Message);
            }

            Console.WriteLine("-----------");

            var result3 = efBrandManager.GetAll(); // Brand class'ını Listele ve Mesajını Göster
            if (result3.Success == true)
            {
                foreach (var x in result3.Data)
                {
                    Console.WriteLine(x.BrandId + "--" + x.BrandName);
                }

                Console.WriteLine(result3.Message);
            }
            else
            {
                Console.WriteLine(result3.Message);
            }



            Console.WriteLine("-----------");



            //var result5 = efCarManager.Get(6); // Id Numarası 6 olan Car'ı getir ve ekrana mesajını yazdır
            //Console.WriteLine(result5.Data.Details);
            //Console.WriteLine(result5.Message);


            Console.WriteLine("--------");


            //var result6 = efCarManager.Add(new Car
            //{ BrandId = 1, ColorId = 1, DailyPrice = 34000, ModelYear = "2020", Details = "Black Ford Mustang" });// Yeni bir car ekle ve eklendiğinin mesajını göster
            //Console.WriteLine(result6.Message);

            Console.WriteLine("------");

            UserManager efUserManager = new UserManager(new EfUserDal());

            // efUserManager.Add(new User { FirstName = "Engin", LastName = "Demiroğ", UserPassword = "123456", Email = "engindemirog@gmail.com" }); // Yeni bir User Ekliyorum
            //foreach (var x in efUserManager.GetAll().Data)
            //{
            //    Console.WriteLine(x.UserId + "--" + x.FirstName + "--" + x.LastName + "--" + x.UserPassword + "--" + x.Email);
            //}

            Console.WriteLine("------");
            CustomerManager efCustomerManager = new CustomerManager(new EfCustomerDal());
            // efCustomerManager.Add(new Customer { CompanyName = "Ford", UserId = 4 });
            foreach (var x in efCustomerManager.GetAll().Data)
            {
                Console.WriteLine(x.UserId + "---" + x.CustomerId + "---" + x.CompanyName);
            }


            Console.WriteLine("----");
            //foreach (var x in efCustomerManager.GetAll().Data)
            //{
            //    Console.WriteLine(x.UserId + "--", x.CustomerId + "--" + x.CompanyName);
            //}


            //foreach (var x in efUserManager.GetAll().Data)
            //{
            //    Console.WriteLine(x.UserId + "--" + x.FirstName + "--" + x.LastName + "--" + x.UserPassword + "--" + x.Email);
            //}

            var time2 = "10 / 1 / 2008";
            DateTime RentalDate = DateTime.Parse(time2);


            var time = "1 / 1 / 2008";
            DateTime ReturntDate = DateTime.Parse(time);


            Console.WriteLine("------------");
            RentalManager efRentalManager = new RentalManager(new EfRentalDal());
            var result8 = efRentalManager.Add(new Rental { CarId = 3, CustomerId = 7, RentDate = RentalDate, ReturnDate = ReturntDate });


            //Console.WriteLine(result8.Message);
            Console.WriteLine("------------");

            foreach (var x in efRentalManager.GetAll().Data)
            {
                Console.WriteLine("RentalID: "+x.RentalId + "--"+"CarID: " + x.CarId + "-- " + "CustomerID: " + x.CustomerId + "--" + " RentDate: "+x.RentDate + "--" +"ReturnDate:  "+ x.ReturnDate);

            }
        }
    }
}
