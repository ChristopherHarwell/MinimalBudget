using System;
namespace MinimalBudget.Models
{
    public interface IBudgetDatabaseSettings
    {
            string ItemsCollectionName { get; set; }
            string ConnectionString { get; set; }
            string DatabaseName { get; set; }
    }
}
