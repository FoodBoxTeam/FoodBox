/*
using FoodBoxBlazorTest.Tests;
using FrontEnd.Data;
using Microsoft.AspNetCore.Identity;
using SampleAPI.DataAccessLayer.Context;
using SampleAPI.DataAccessLayer.Interface;
using SampleAPI.DataAccessLayer.Models;
using SampleAPI.DataAccessLayer.Repository;
using SampleAPI.Tests.DataAccessLayer.ContextMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodBoxBlazorTest.Tests
{
   public class DbContextMock
    {
        public static FoodBoxDB GetMock()
        {
            List<Item> listOfItems = GenerateTestItems();
            List<Restaurant> listOfResturants = GenerateTestResturants(listOfItems);
            FoodBoxDB dbContextMock = DbContextMock.GetMock<Item, FoodBoxDB>(listOfItems, x => x.Items);
            return new Db(dbContextMock);
        }

        private static List<Employee> GenerateTestData()
        {
            List<Employee> lstUser = new();
            Random rand = new Random();
            for (int index = 1; index <= 10; index++)
            {
                lstUser.Add(new Employee
                {
                    Id = index,
                    Name = "User-" + index,
                    Age = rand.Next(1, 100)

                });
            }
            return lstUser;
        }
    }
} 
*/
