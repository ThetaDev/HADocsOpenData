using System.Collections.Generic;

namespace HADocsOpenData.Specification {
    public class BatchTestDataSet {
        public string TestReportIssuerName;
        public BatchTestDataSetType TestType;
        public string Description;
        public int? PageNo;

        public IList<BatchTestDataValue> TestValues = new List<BatchTestDataValue>();

        public void AddTestValue(string qual, decimal value, string unit = "%", string notes = null) {
            TestValues.Add(new BatchTestDataValue {
                Qualifier = qual,
                Value = value,
                Unit = unit,
                Notes = notes,
            });
        }
    }

    public enum BatchTestDataSetType {
        LadleCast = 1,
        Product = 2,
        Mechanical = 3,
        PMI = 4,
    }

    public class BatchTestDataValue {
        public string Qualifier;// = "The qualifier for what was measured. E.g.: Chemical: Fe, F, C; Mechanical: Hardness, Elongation";
        public decimal? Value;// = 42;
        public string Unit;// = "Unit of measurement, e.g.: Mpa, %";
        public string Notes;// = "Optional notes about this value.";
    }

    public class BatchTestDataChecklistValue {
        public string Name;// = "A short name used as the shown value in checklists.";
        public string Description;// = "A more comprehensive/complete description of this checklist value.";
    }
}
