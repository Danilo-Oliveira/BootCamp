using System;
using MongoDB.Bson.Serialization.Attributes;

namespace C__CRUD.Models.Entidades
{
    public class Usuario
    {  
        public object Id { get; set; }

        [BsonElement("IdUsuario")]
        public int IdUsuario { get; set; }

        [BsonElement("NomeUsuario")]
        public string NomeUsuario { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Senha")]
        public string Senha { get; set; }
    }
    }
