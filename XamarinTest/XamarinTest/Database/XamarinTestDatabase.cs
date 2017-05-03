using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinTest.Model;

namespace XamarinTest.Database
{
    public class XamarinTestDatabase
    {
        readonly SQLiteAsyncConnection database;

        public XamarinTestDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Campaign>();
        }

        public Task<List<Campaign>> GetAllCampaignsAsync()
        {
            return database.QueryAsync<Campaign>("SELECT * FROM [Campaign]");
        }
    }
}
