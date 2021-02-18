using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroApi.Models.DbSettings
{
    public interface IFinanceiroDataBaseSettings
    {
        string FinanceiroCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DataBaseName { get; set; }

    }
}
