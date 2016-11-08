using System;
using System.Collections.Generic;

namespace HADocsOpenData.Specification {
    /// <summary>
    /// A data class showing an sample of metadata used with Batch Documents.
    /// These are the fields common for a complete order.
    /// Common Batch Documents: Material Certificates
    /// </summary>
    public class BatchDoc {
        public string PoNo = "Override: Purchase Order No";
        public string CustomersRef = "Override: Customers ref";

        public string CountryOfOrigin = "As stated on document";
        public DateTime? ManufacturingDate = DateTime.Now;

        public DateTime? SupplierOrderDate = DateTime.Now.Date;
        public string SupplierDelNo = "Your Delivery number";
        public DateTime? SupplierDelDate = DateTime.Now.Date;

        public List<BatchDocLineSpec> Lines = new List<BatchDocLineSpec>();

        //possible overloads from base json-data in HADocsOpenDataMain
        public string ProjectNo = "Override: Customers internal project number";
        public string ProjectName = "Override: Customers internal project name";
        public string ProjectEmail = "Override: Email specified for customers internal project";

        public string SupplierSoNo = "Override: Your (as supplier) sales order number";
        public string SupplierOrderContactPerson = "Override: Contact person stated on order";
        public string SupplierRef = "Override: Your (as supplier) ref";

        public BatchDoc() {}

        public BatchDoc(int noForTesting) {
            for (int i = 0; i < noForTesting; i++) {
                Lines.Add(new BatchDocLineSpec());
            }
        }

        //deprecated fields from version 1
        public string ManufacturerName;
        public string ManufacturerDocNo;

        public string OurRef;

        public string RecipientDocNo;
        public string SupplierDocNo;

        public string DocRevision;
        public DateTime? DocCreatedDate;
        public DateTime? DocLastChanged;
    }

    /// <summary>
    /// A data class showing an sample of metadata used with Batch Documents.
    /// These fields are specifications for each picking list line.
    /// </summary>
    public class BatchDocLineSpec {
        public int SpecificationPage = 1;
        public string RelatedPages = "1-2,4-6,7,10"; //if empty it is assumed all pages of file are related to this line
        public string PoLineNo = "010";
        public string ArticleNo = "Customers article no";
        public string SupplierArticleNo = "Suppliers article no";
        public string PublicRegisterArticleNo = "An article number from a public register. Prefixed with a short-name for the public register. E.g. NRF-xxx, NOBB-xxx";
        public string ArticleDescription = "A description of the purchased article";
        public string Dimension = "A specification of the dimensions of the purchased article";
        public string Quality = "Some form of description of the articles quality. E.g. UNS-number";
        public double? Quantity = 100;
        public string QuantityUnit = "m";

        public string BatchId = "Manufacturers Batch identificator: HeatNo / ChargeNo / Schmelz / BatchNo";
        public string LotNo = "Manufacturers Batch sub identifier";
        public string SerialNo = "Other typical form of identification of complex parts. E.g. Serial number or PartNo";
        public string CodeNo = "Secondary form of identification of complex parts.";
        public string Tag = "A specialized tag provided by the customer for the orderline related to this.";
        public IList<string> Specifications; //A list of the specifications this product has been produced to fullfill. E.g.: UNS S32550, ASTM A928, Norsok D52 rev. 6 and TR2000 DP204 rev. C
        public IList<BatchTestDataSet> TestDataSets; //A list of numerical test data sets, including test issuer.
        public IList<BatchTestDataChecklistValue> CheckListValues; //A list of text statements about the product and batch document, usually according to checks specified in the specifications.
    }
}
