using FinanceiroApi.Models;
using FinanceiroApi.Models.DbSettings;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinanceiroApi.Service
{
    public class EntradaService
    {
        private readonly IMongoCollection<Entrada> _entradas;

        public EntradaService(IFinanceiroDataBaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DataBaseName);

            _entradas = database.GetCollection<Entrada>(settings.FinanceiroCollectionName);
        }

        public List<Entrada> Get() => _entradas.Find(Entrada => true).ToList();

        public Entrada GetById(string id) => _entradas.Find<Entrada>(Entrada => Entrada.Id == id).FirstOrDefault();

        public Entrada Create(Entrada Entrada)
        {
            _entradas.InsertOne(Entrada);
            return Entrada;
        }

        public void Update(string id, Entrada entradain) => _entradas.ReplaceOne(Entrada => Entrada.Id == id, entradain);

        public void Remove(Entrada entradain) => _entradas.DeleteOne(Entrada => Entrada.Id == entradain.Id);

        public void Remove(string id) => _entradas.DeleteOne(Entrada => Entrada.Id == id);
    }
}

