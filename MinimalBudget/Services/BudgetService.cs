using MinimalBudget.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BooksApi.Services
{
    public class BudgetService
    {
        private readonly IMongoCollection<ItemPurchased> _items;

        public BudgetService(IBudgetDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _items = database.GetCollection<ItemPurchased>(settings.BudgetCollectionName);
        }

        public List<ItemPurchased> Get() =>
            _items.Find(ItemPurchased => true).ToList();

        public ItemPurchased Get(string id) =>
            _items.Find(ItemPurchased => ItemPurchased.Id == id).FirstOrDefault();

        public ItemPurchased Create(ItemPurchased ItemPurchased)
        {
            _items.InsertOne(ItemPurchased);
            return ItemPurchased;
        }

        public void Update(string id, ItemPurchased item) =>
            _items.ReplaceOne(ItemPurchased => ItemPurchased.Id == id, item);

        public void Remove(ItemPurchased item) =>
            _items.DeleteOne(ItemPurchased => ItemPurchased.Id == item.Id);

        public void Remove(string id) =>
            _items.DeleteOne(ItemPurchased => ItemPurchased.Id == id);
    }
}