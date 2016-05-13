using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractor
{
    class PersonDocument
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string email { get; set; }

        public string name { get; set; }

        public IList<SurveyDocument> surveys { get; set; }
    }
}
