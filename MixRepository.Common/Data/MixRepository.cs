using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using MixRepository.Common.Model;
using MongoDB.Driver;

namespace MixRepository.Common.Data
{
    public class MixRepository : IMixRepository
    {
        private readonly IMongoCollection<Mix> _collection;
        private static IMongoClient _client;
        private static IMongoDatabase _database;

        public MixRepository()
        {
            var url = MongoUrl.Create(ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString);
            _client = new MongoClient(url);
            _database = _client.GetDatabase("mixes");
            _collection = _database.GetCollection<Mix>("Mix");
        }

        public void Add(IEnumerable<Mix> mixes)
        {         
            _collection.InsertMany(mixes);
        }

        public void Delete(int mixId)
        {
            throw new NotImplementedException();
        }

        public void GetById(int mixId)
        {
            throw new NotImplementedException();
        }

        public void Update(Mix mix)
        {
            throw new NotImplementedException();
        }
    }
}
