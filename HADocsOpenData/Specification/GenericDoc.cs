using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADocsOpenData.Specification {
    public class GenericDoc {
        public string Description = "Document description";
        public string Reference = "Document reference";
        public bool? IsExpiring; //Whether or not this document should have an Expiry date
        public DateTime? ExpiryDate; //The documents Expiry date

        public string Status = "4"; //Current status of the document as defined by the project, often 1-4 (1: "Accepted", 2: "Accepted with comments incorporated", 3: "Not accepted", 4: "For information only")
        public DateTime? DueDate;
    }
}
