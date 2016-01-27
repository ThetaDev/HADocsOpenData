using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HADocsOpenData.SampleAddToPdf_iTextSharp;
using HADocsOpenData.Sample_Json.Net;
using HADocsOpenData.Specification;

namespace HADocsOpenData {
    class Program {
        static void Main(string[] args) {
            var obj = new HADocsOpenDataMain(1);
            string json = JsonNetSerDeser.Serialize(obj, @"R:\HADocsOpenDataBatchSample.json");

            //var obj = JsonNetSerDeser.Deserialize(@"R:\HADocsOpenDataBatchSample.json");

            PdfManipulation.AddMetadataToExistingPdfFile(@"R:\2013.pdf", json);

            string readJson = PdfManipulation.ReadJsonFromPdf(@"R:\2013.pdfoutput.pdf");
            bool equal = json.Equals(readJson);
        }
    }
}
