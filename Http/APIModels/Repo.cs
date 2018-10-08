using System;
using System.Runtime.Serialization;

namespace WebAPIClient
{
    [DataContract(Name="Repo")]
    public class Repository
    {
        private string _name;

        [DataMember(Name="name")]
        public string Name 
        { 
            get { return this._name; }
            set { this._name = value; }
        }
    }
}