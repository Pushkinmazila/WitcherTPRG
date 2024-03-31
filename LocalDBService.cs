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
            _connection.CreateTableAsync<Weapon>();


        }

        //public async IEnumerable<Customer> Find<Customer>(Func<Customer, bool> expr) where Customer : new()
        //{
        //    return _connection.Table<Customer>().Where(expr);
        //}

        public async Task<List<Player>> ExecuteRawQueryAsync(string query)
        {
            return await _connection.QueryAsync<Player>(query);
        }

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

        #region [Weapon]
        public async Task<List<Weapon>> ExecuteRawQueryAsync_Weapon(string query)
        {
            int rowing1 = 0;
            return await _connection.QueryAsync<Weapon>(query);
            int rowing = 0;
        }
        public async Task Create_Weapon(Weapon Weapon)
        {
            await _connection.InsertAsync(Weapon);
        }
        public async Task<List<Weapon>> GetWeapon()
        {

            return await _connection.Table<Weapon>().ToListAsync();
        }

        public async Task Update_Weapon(Weapon Weapon)
        {
            await _connection.UpdateAsync(Weapon);
        }

        public async Task Delete_Weapon(Weapon Weapon)
        {
            await _connection.DeleteAsync(Weapon);
        }

        #endregion



    }
}
