using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataExtractor
{
    class SurveyDocument
    {
        public double quarter { get; set; }

        public double year { get; set; }

        public IList<ResponseDocument> responses { get; set; }
    }
}
