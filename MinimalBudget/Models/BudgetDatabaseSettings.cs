using MinimalBudget.Models;

namespace MinimalBudget
{
    public class BudgetDatabaseSettings : IBudgetDatabaseSettings
    {
        public string ItemsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}