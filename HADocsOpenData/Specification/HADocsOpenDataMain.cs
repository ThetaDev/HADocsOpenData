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
        public string Version = "HADocsOpenData-1";

        public DateTime CreateTime = DateTime.Now;
        public string Recipient = "The name of the company receiving this document. Typically your customer.";
        public string SupplierName = "Your company name";

        public List<BatchDoc> BatchDocs = new List<BatchDoc>();

        public HADocsOpenDataMain() {}

        public HADocsOpenDataMain(int noForTesting) {
            for (int i = 0; i < noForTesting; i++) {
                BatchDocs.Add(new BatchDoc(noForTesting));
            }
        }
    }
}
