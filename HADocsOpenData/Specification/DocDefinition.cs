using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HADocsOpenData.Specification {
    public class DocDefinition {
        public BatchDoc BatchData;
        public GenericDoc DocData;

        public string CommonDescription = "A optional description currently used when visualizing Open Data.";

        public bool? IsPartOfIndex; //Optional indicator that can be used when splitting a package into its separate documents.

        //Generated id's from the respective companies systems
        public string ProjectDocNo = "P-01";
        public string SenderDocNo = "001";
        public string RecipientDocNo = "001";

        //As stated on the document
        public string Issuer = "Usually name of Manufacturer or Classification society";
        public string IssuedDocNo = "E.g. Manufacturers certificate number";

        public string DocRevision = "Revision name of the document (1,2,3/a,b,c/etc)";
        public DateTime? DocRevisionDate = DateTime.Now;

        public int PageNo = 1;
        public int PageCount = 1;
        public string DocType = "Common name of the document type";
        public string DocTypeCode = "Shorter codes, defined by the project";
        public string DocTypeDescription = "A more extensive description of the document type. Mainly used for mapping to the recipients document types, if they use different common names.";
    }
}
