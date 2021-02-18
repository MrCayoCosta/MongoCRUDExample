using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroApi.Models.DbSettings
{
    public class FinanceiroDataBaseSettings : IFinanceiroDataBaseSettings
    {
        public string FinanceiroCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DataBaseName { get; set; }
    }
}
