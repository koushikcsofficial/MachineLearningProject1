using Microsoft.ML.Data;

namespace Review.Model
{
    public class ModelInput
    {
        [ColumnName("review"), LoadColumn(0)]
        public string Review { get; set; }


        [ColumnName("sentiment"), LoadColumn(1)]
        public string Sentiment { get; set; }


    }
}
