using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitApp
{
    public class Meals
    {
        private int _ID;
        private string mealName;
        private DateTime mealTime;
        private int mealKcals;

       
        public Meals()
        {

        }

        public Meals(int iD, string mealName, DateTime mealTime, int mealKcals)
        {
            _ID = iD;
            this.mealName = mealName;
            this.mealTime = mealTime;
            this.mealKcals = mealKcals;
        }
        [PrimaryKey,AutoIncrement]
        public int ID { get => _ID; set => _ID = value; }

        [NotNull]
        public string MealName { get => mealName; set => mealName = value; }

        [NotNull]
        public DateTime MealTime { get => mealTime; set => mealTime = value; }

        [NotNull]
        public int MealKcals { get => mealKcals; set => mealKcals = value; }
    }
}
