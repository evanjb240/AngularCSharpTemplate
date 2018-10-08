using System;
using System.Runtime.Serialization;

namespace WebAPIClient
{
    [DataContract(Name="Binance")]
    public class Binance
    {
        [DataMember(Name="data")]
        public Data Data{get;set;}
 
        // "website_slug": "bitcoin", 
        // "rank": 1, 
        // "circulating_supply": 17008162.0, 
        // "total_supply": 17008162.0, 
        // "max_supply": 21000000.0,
    }
    public class Data{
        [DataMember(Name = "id")]
        public string Id {get; set;}

        [DataMember(Name = "name")]
        public string Name {get; set;}

        [DataMember(Name = "symbol")]
        public string Symbol {get; set;}

        [DataMember(Name = "rank")]
        public string Rank {get; set;}
    }
    


}