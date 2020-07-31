using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C__CRUD.Models.Entidades;
using MongoDB.Driver;

namespace C__CRUD.Services{
    // Aqui Cadastramos as pessoas imutaveis.
    public class UsuarioServices{

            private readonly IMongoDatabase mongoDatabase;
            public UsuarioServices()
            {
                var client = new MongoClient("mongodb+srv://Users_DB:linux1234@cadastrousuario.m1vhs.gcp.mongodb.net/<dbname>?retryWrites=true&w=majority");
                mongoDatabase = client.GetDatabase("CrudMongo");

            }

            public List<Usuario> ListarUsuario()
            {
                var collection = mongoDatabase.GetCollection<Usuario>("Usuario");

                var usuario = collection.AsQueryable().ToList();

                return usuario;
            }

            public Usuario ObterUsuario(int idUsuario)
            {
                var collection = mongoDatabase.GetCollection<Usuario>("Usuario");
                var item = collection.Find(c => c.IdUsuario == idUsuario);


                return item.First();
            }
        }
    }