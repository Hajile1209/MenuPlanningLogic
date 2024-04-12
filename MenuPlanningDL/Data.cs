using MenuPlanning;
using MenuPlanningBL;
using System;
using System.Collections.Generic;

namespace MenuPlanningDL
{
    public class Data
    {
        public static List<Menu> menus = new List<Menu>();

        public static void Dishes()
        {

            Menu menu1 = new Menu();
            menu1.meal = "Breakfast";
            menu1.dish = "1 Cup of Rice \n1 Large Egg \n1 Standard Hotdog";
            menu1.beverage = "Coffee, Tea, Juice(Orange Juice or Apple Juice), Milk";
            menu1.preference = "Hotdog (Grilled, Pan-fried, or Boiled) \nEgg (Fried Sunny-side up, Scrambled, or Boiled) with ketchup";
            menu1.nutrition = "Total Nutrition Information (Per Serving) \nCalories: Approximately 420 kcal \nCarbohydrates: Approximately 48g \nProtein: Approximately 16g \nFat: Approximately 18.5g";
            menu1.time = "7:00AM - 8:00AM";
            menus.Add(menu1);


            Menu menu2 = new Menu();
            menu2.meal = "Lunch";
            menu2.dish = "1 Cup of Rice \n1 Medium-sized Porkchop \n1 Large Egg";
            menu2.beverage = "Water, Tea, Juice(Orange Juice or Apple Juice)";
            menu2.preference = "Porkchop with Gravy or Soy Sauce \nEgg (Fried Sunny-side up, Scrambled, or Boiled) with ketchup";
            menu2.nutrition = "Total Nutrition Information (Per Serving) \nCalories: Approximately 520 kcal \nCarbohydrates: Approximately 46g \nProtein: Approximately 40g \nFat: Approximately 19.5g";
            menu2.time = "11:00AM - 12:00PM";
            menus.Add(menu2);


            Menu menu3 = new Menu();
            menu3.meal = "Dinner";
            menu3.dish = "1 Cup of Rice \n1 Grilled Chicken Breast";
            menu3.beverage = "Water, Sparkling water";
            menu3.preference = "Sauce for Chicken (Teriyaki or Gravy)";
            menu3.nutrition = "Total Nutrition Information (Per Serving) \nCalories: Approximately 430 kcal \nCarbohydrates: Approximately 55g \nProtein: Approximately 46g \nFat: Approximately 4.5g";
            menu3.time = "5:00PM - 6:00PM";
            menus.Add(menu3);

            Menu menu4 = new Menu();
            menu4.meal = "Breakfast";
            menu4.dish = "1/2 Cup of Oatmeal \n1/2 cup mixed berries (e.g., Strawberries, Blueberries, Raspberries \n1 Tablespoon Chopped Nuts (e.g., Almonds, Walnuts)) ";
            menu4.beverage = "Water, Milk";
            menu4.preference = "Optional: Honey or Maple Syrup for Sweetness";
            menu4.nutrition = "Total Nutritional Information (Per Serving):\nCalories: Approximately 240 kcal\nCarbohydrates: Approximately 39g\nProtein: Approximately 7.5g\nFat: Approximately 7.5g";
            menu4.time = "7:30AM - 8:30AM";
            menus.Add(menu4);

            Menu menu5 = new Menu();
            menu5.meal = "Lunch";
            menu5.dish = "2 Sliced Bread (Whole Wheat, White, or Your Preference \n 2 Luncheon Meat Slices \n 2 Corned Beef Slices \n 1 Large Hard-boiled Eggs, Sliced)";
            menu5.beverage = "Water, Juice(Orange Juice or Apple Juice), Iced Tea) ";
            menu5.preference = "Optional: Lettuce, Tomato, Cheese slices, Ketchup, Mayonnaise, Mustard";
            menu5.nutrition = "Total Nutritional Information (Per Serving): \nCalories: Approximately 400 kcal \nCarbohydrates: Approximately 32g \nProtein: Approximately 21g \nFat: Approximately 21g";
            menu5.time = "11:30AM - 12:30PM";
            menus.Add(menu5);

            Menu menu6 = new Menu();
            menu6.meal = "Dinner";
            menu6.dish = "1 Cup of Rice, \n1 Medium-size Corned Tuna \n1 Medium-size Canned Chili Con Carne";
            menu6.beverage = "Water \nIced tea \nLemonade \nFruit juice (Orange juice or Pineapple juice)";
            menu6.preference = "Guacamole or Salsa For Topping The Chili Con Carne \nSour Cream or Shredded Cheese For Topping The Chili Con Carne";
            menu6.nutrition = "Total Nutritional Information (Per Serving): \n Calories: Approximately 550 kcal \nCarbohydrates: Approximately 60g \nProtein: Approximately 46g \nFat: Approximately 11g";
            menu6.time = "5:30PM - 6:30PM";
            menus.Add(menu6);

        }

        public static void SelectDay()
        {
            Console.WriteLine("Select Day: ");
            Console.WriteLine("1. Day 1");
            Console.WriteLine("2. Day 2");
            Console.WriteLine("Please Enter Which Day");
            string select = Console.ReadLine();

            switch (select)
            {
                case "1":
                    MenuListDay1();
                    break;

                case "2":
                    MenuListDay2();
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public static void MenuListDay1()
        {
            Dishes();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BusinessLogic.DisplayMenus(menus[0]);
                    break;

                case "2":
                    BusinessLogic.DisplayMenus(menus[1]);
                    break;

                case "3":
                    BusinessLogic.DisplayMenus(menus[2]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        public static void MenuListDay2()
        {
            Dishes();

            Console.WriteLine("\nSelect Meal Option:");
            Console.WriteLine("1. Breakfast");
            Console.WriteLine("2. Lunch");
            Console.WriteLine("3. Dinner");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    BusinessLogic.DisplayMenus(menus[3]);
                    break;

                case "2":
                    BusinessLogic.DisplayMenus(menus[4]);
                    break;

                case "3":
                    BusinessLogic.DisplayMenus(menus[5]);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
