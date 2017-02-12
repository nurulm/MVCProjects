using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;


namespace MVC6TagHelpersApp.Models
{
    public class UserModel
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;

        [Required(ErrorMessage ="Please Enter User Name")]
        public string UserName { get; set; }

        public string Password { get; set; }

        [Range(25,40,ErrorMessage ="Invalid Age")]
        public int Age { get; set; }

        public string Gender { get; set; }

        public string SkillSet { get; set; }

        public string Country { get; set; }

        public bool TermsAccepted { get; set; }

        public void MongoConnect()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("sample");
        }
    }
}
