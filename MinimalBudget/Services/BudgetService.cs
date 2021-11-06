using System.Collections.Generic;
using MinimalBudget.Models;
using MongoDB.Driver;

namespace MinimalBudget.Services
{
    public class BudgetService
    {
        private readonly IMongoCollection<ItemPurchased> _itemsPurchased;

        public BudgetService(IBudgetDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _itemsPurchased = database.GetCollection<ItemPurchased>(settings.ItemsCollectionName);
        }

        public List<ItemPurchased> Get() =>
            _itemsPurchased.Find(item => true).ToList();

        public ItemPurchased Get(string id) =>
            _itemsPurchased.Find<ItemPurchased>(item => item.Id == id).FirstOrDefault();

        public ItemPurchased Create(ItemPurchased item)
        {
            _itemsPurchased.InsertOne(item);
            return item;
        }

        public void Update(string id, ItemPurchased budgetIn) =>
            _itemsPurchased.ReplaceOne(item => item.Id == id, budgetIn);

        public void Remove(ItemPurchased budgetIn) =>
            _itemsPurchased.DeleteOne(item => item.Id == budgetIn.Id);

        public void Remove(string id) =>
            _itemsPurchased.DeleteOne(item => item.Id == id);
    }
}