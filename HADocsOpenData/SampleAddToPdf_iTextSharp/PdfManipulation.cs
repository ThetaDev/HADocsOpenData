using System.IO;
using iTextSharp.text.pdf;

namespace HADocsOpenData.SampleAddToPdf_iTextSharp {
    public class PdfManipulation {
        public static void AddMetadataToPdfWriter(PdfWriter writer, string json) {
            writer.Info.Put(new PdfName("HADocsOpenData"), new PdfString(json));
        }

        public static void AddMetadataToExistingPdfFile(string filename, string json) {
            var reader = new PdfReader(filename);
            using (var outputFs = new FileStream(filename + "output.pdf", FileMode.Create)) {
                var stamper = new PdfStamper(reader, outputFs);
                var info = reader.Info;
                info.Add("HADocsOpenData", json);
                stamper.MoreInfo = info;
                stamper.Close();
            }
            reader.Close();
        }

        public static string ReadJsonFromPdf(string filename) {
            var reader = new PdfReader(filename);
            object jsonText = reader.Info["HADocsOpenData"];
            reader.Close();
            if (jsonText == null)
                return null; //data was not found in PDF
            return jsonText.ToString();
        }
    }
}
