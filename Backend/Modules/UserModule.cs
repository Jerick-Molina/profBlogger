using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace Backend.Modules;



public class UserModule
{ 

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id {get;set;}


    public Credidentials credidentials;
    public class Credidentials 
    {
        [BsonRequired]
        public string Email {get;set;}

        [BsonRequired]
        public string Password {get;set;}
    }
    
    public string FirstName {get;set;} 

    public string LastName  {get;set;}



}