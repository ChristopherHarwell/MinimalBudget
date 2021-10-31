using BudgetsApi.Models;
using MinimalBudget.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace BudgetsApi.Services
{
    public class BudgetService
    {
        private readonly IMongoCollection<Budget> _Budgets;

        public BudgetService(IBudgetDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _Budgets = database.GetCollection<Budget>(settings.BudgetsCollectionName);
        }

        public List<Budget> Get() =>
            _Budgets.Find(Budget => true).ToList();

        public Budget Get(string id) =>
            _Budgets.Find<Budget>(Budget => Budget.Id == id).FirstOrDefault();

        public Budget Create(Budget Budget)
        {
            _Budgets.InsertOne(Budget);
            return Budget;
        }

        public void Update(string id, Budget BudgetIn) =>
            _Budgets.ReplaceOne(Budget => Budget.Id == id, BudgetIn);

        public void Remove(Budget BudgetIn) =>
            _Budgets.DeleteOne(Budget => Budget.Id == BudgetIn.Id);

        public void Remove(string id) =>
            _Budgets.DeleteOne(Budget => Budget.Id == id);
    }
}