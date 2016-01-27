using System;
using System.Collections.Generic;

namespace HADocsOpenData.Specification {
    /// <summary>
    /// A data class showing an sample of metadata used with Batch Documents.
    /// These are the fields common for a complete order.
    /// Common Batch Documents: Material Certificates
    /// </summary>
    public class BatchDoc {
        public string PoNo = "Purchase Order No";

        public string ManufacturerName = "As stated on document";
        public string ManufacturerDocNo = "As stated on document; E.g. CertificateNo";
        public string CountryOfOrigin = "As stated on document";

        public string RecipientDocNo = "Recipients document number. E.g. for when sending a new revision.";
        
        public string SupplierDocNo = "Your document number";
        public string SupplierSoNo = "Your sales order number";
        public DateTime? SupplierOrderDate = DateTime.Now.Date;
        public string SupplierDelNo = "Your Delivery number";
        public DateTime? SupplierDelDate = DateTime.Now.Date;
        public string SupplierOrderContactPerson = "Contact person stated on order";
        public string SupplierRef = "Your (as supplier) ref";

        public string OurRef = "Customers ref";
        public string ProjectNo = "Customers internal project number";
        public string ProjectName = "Customers internal project name";
        public string ProjectEmail = "Email specified for customers internal project";

        public string DocRevision = "Revision name of the document (1,2,3/a,b,c/etc)";
        public DateTime? DocCreatedDate = DateTime.Now;
        public DateTime? DocLastChanged = DateTime.Now;

        public List<BatchDocLineSpec> Lines = new List<BatchDocLineSpec>();

        public BatchDoc() {}

        public BatchDoc(int noForTesting) {
            for (int i = 0; i < noForTesting; i++) {
                Lines.Add(new BatchDocLineSpec());
            }
        }
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
        public string NrfNo = "NRF number";
        public string ArticleDescription = "A description of the purchased article";
        public string Dimension = "A specification of the dimensions of the purchased article";
        public string Quality = "Some form of description of the articles quality. E.g. UNS-number";
        public double? Quantity = 100;
        public string QuantityUnit = "m";

        public string BatchId = "Manufacturers Batch identificator: HeatNo / ChargeNo / Schmelz / BatchNo";
        public string LotNo = "Manufacturers Batch sub identifier";
        public string SerialNo = "Other typical form of identification of complex parts. E.g. Serial number";
        public string CodeNo = "Secondary form of identification of complex parts.";
        public string Tag = "A specialized tag provided by the customer for the orderline related to this.";
    }
}
