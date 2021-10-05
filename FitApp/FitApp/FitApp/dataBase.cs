using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FitApp
{
    public class dataBase
    {
        readonly SQLiteAsyncConnection _database;

        public dataBase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Meals>().Wait();
        }

        public Task<List<Meals>> GetMealAsync()
        {
            return _database.Table<Meals>().ToListAsync();
        }

        public Task<int> SaveMealAsync(Meals meal)
        {
            return _database.InsertAsync(meal);
        }

        public Task<int> DeleteMealAsync(Meals meal)
        {
            return _database.DeleteAsync<Meals>(meal.ID);
        }

        public Task<int> UpdateMealAsync(Meals meal)
        {
            return _database.UpdateAsync(meal);
        }
    }
}
