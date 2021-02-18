using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroApi.Models
{
    public class BaseModel
    {
        [BsonId]
        public string Id { get; set; }
        [BsonElement("Data")]
        [BsonRequired()]
        public DateTime Data { get; set; }
        [BsonElement("Valor")]
        [BsonRequired()]
        public decimal Valor { get; set; }
        [BsonElement("Descricao")]
        public string Descricao { get; set; }
    }
}
