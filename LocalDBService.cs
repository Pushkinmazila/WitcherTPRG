using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp7
{
    public class LocalDbService
    {
        private const string DB_NAME = "demo_local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Player>();


        }

        //public async IEnumerable<Customer> Find<Customer>(Func<Customer, bool> expr) where Customer : new()
        //{
        //    return _connection.Table<Customer>().Where(expr);
        //}



        public async Task<List<Player>> GetCustomers()
        {
            
            return await _connection.Table<Player>().ToListAsync();
        }

        public async Task<Player> GetById(int id)
        {
            return await _connection.Table<Player>().Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task Create(Player Player)
        {
            await _connection.InsertAsync(Player);
        }

        public async Task Update(Player Player)
        {
            await _connection.UpdateAsync(Player);
        }

        public async Task Delete(Player Player)
        {
            await _connection.DeleteAsync(Player);
        }
    }
}
