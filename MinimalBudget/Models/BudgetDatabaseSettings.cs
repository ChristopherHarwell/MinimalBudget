using MinimalBudget.Models;

namespace MinimalBudget
{
    public class BudgetDatabaseSettings : IBudgetDatabaseSettings
    {
        public string ItemsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string BudgetCollectionName { get; }

    }

    public interface IBudgetDatabaseSettings
    {
        string ItemsCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string BudgetCollectionName { get; }
    }
}