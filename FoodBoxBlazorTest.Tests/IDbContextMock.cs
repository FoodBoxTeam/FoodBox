/*using FoodBoxBlazorTest.Tests;
using FrontEnd.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
            //List<Restaurant> listOfResturants = GenerateTestResturants(listOfItems);
            DbContextOptions<FoodBoxDB> contextOptions = new();
            //FoodBoxDB dbContextMock = DbContextMock.GetMock<Item, FoodBoxDB>(listOfItems, x => x.Items);
            return new FoodBoxDB(contextOptions);
        }

        private static List<Item> GenerateTestItems()
        {
            List<Item> listItems = new();
            Random rand = new Random();
            for (int index = 1; index <= 10; index++)
            {
                listItems.Add(new Item
                {
                    Id = index,
                    ItemName = "Item-" + index,
                    Description = "Description of item: " + index,
                    Image = "default.png"

                });
            }
            return listItems;
        }
    }
} 
*/