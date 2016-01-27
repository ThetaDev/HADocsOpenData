using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using HADocsOpenData.Specification;
using Newtonsoft.Json;

namespace HADocsOpenData.Sample_Json.Net {
    public class JsonNetSerDeser {
        public static JsonSerializerSettings TypicalSettings = new JsonSerializerSettings {
            Formatting = Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
            PreserveReferencesHandling = PreserveReferencesHandling.Objects,
            NullValueHandling = NullValueHandling.Ignore,
        };

        public static string Serialize(HADocsOpenDataMain data, string filename) {
            string json = JsonConvert.SerializeObject(data, TypicalSettings);
            File.WriteAllText(filename, json);
            return json; //for testing/development purposes
        }

        public static HADocsOpenDataMain Deserialize(string filename) {
            string json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<HADocsOpenDataMain>(json, TypicalSettings);
        }
    }
}
