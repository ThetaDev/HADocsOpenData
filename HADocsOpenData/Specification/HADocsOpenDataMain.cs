using System;
using System.Collections.Generic;

namespace HADocsOpenData.Specification {
    /// <summary>
    /// 
    /// Please note that all fields not specified otherwise should be populated
    /// from your customers view-point.
    /// 
    /// Any dates may be supplied formatted as "YYYY-MM-DD" or using the full ISO 8601 standard (http://en.wikipedia.org/wiki/ISO_8601): "2012-03-19T07:22Z"/"2016-01-23T09:49:09.0829697+01:00"(default in Json.Net).
    /// </summary>
    public class HADocsOpenDataMain {
        public string Version = "HADocsOpenData-2";

        public DateTime CreateTime = DateTime.Now;
        public string PackageDescription = "Name or short description of this document package. E.g. \"MRB-01\", \"Transmittal 4\"";

        public string Recipient = "The name of the company receiving this document. Typically your customer.";
        public EntityType? RecipientIs; //enum -> Supplier, Customer, ThirdParty
        public string Sender = "Your company name";
        public EntityType? SenderIs; //enum -> Supplier, Customer, ThirdParty

        public string ProjectNo = "Customers internal project number";
        public string ProjectName = "Customers internal project name";
        public string ProjectEmail = "Email specified for customers internal project";

        public string PoNo = "Purchase Order No";
        public string CustomersRef = "Customers ref";

        public string SupplierSoNo = "Your (as supplier) sales order number";
        public string SupplierOrderContactPerson = "Contact person stated on order";
        public string SupplierRef = "Your (as supplier) ref";

        public List<DocDefinition> Docs = new List<DocDefinition>();

        public HADocsOpenDataMain() {}

        public HADocsOpenDataMain(int noForTesting) {
            for (int i = 0; i < noForTesting; i++) {
                Docs.Add(new DocDefinition{BatchData = new BatchDoc(noForTesting)});
            }
        }
    }

    public enum EntityType {
        Customer = 1,
        Supplier = 2,
        ThirdParty = 3,
    }
}
