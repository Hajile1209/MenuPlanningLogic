using MenuPlanning;
using System;
using System.Collections.Generic;

namespace MenuPlanningBL
{
    public class BusinessLogic
    {
        public string name;
        public List<Menu> menus = new List<Menu>();

        public void AddMenu(Menu menu)
        {
            menus.Add(menu);
        }

        public static void DisplayMenus(Menu menu)
        {
            Console.WriteLine("You Selected: " + menu.meal);
            Console.WriteLine("Dish: " + menu.dish);
            Console.WriteLine("Beverage: " + menu.beverage);
            Console.WriteLine("Preference: " + menu.preference);
            Console.WriteLine("Nutrition: " + menu.nutrition);
            Console.WriteLine("Time: " + menu.time);
        }

    }
}
