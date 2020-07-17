using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.ML;
using Microsoft.ML.Data;
using Review.Model;

namespace Review.Model
{
    public class ConsumeModel
    {
        private static Lazy<PredictionEngine<ModelInput, ModelOutput>> PredictionEngine = new Lazy<PredictionEngine<ModelInput, ModelOutput>>(CreatePredictionEngine);

        // Method for consuming model in your app
        public static ModelOutput Predict(ModelInput input)
        {
            ModelOutput result = PredictionEngine.Value.Predict(input);
            return result;
        }

        public static PredictionEngine<ModelInput, ModelOutput> CreatePredictionEngine()
        {
            // Create new MLContext
            MLContext mlContext = new MLContext();

            // Load model & create prediction engine
            //string modelPath = @"D:\c# projects\Web\MachineLearningProject1\Review.Model\MLModel.zip";
            string modelPath = @"d:\DZHosts\LocalUser\deeplearning1\www.reviewanalysis.somee.com\MLModel.zip";
            ITransformer mlModel = mlContext.Model.Load(modelPath, out var modelInputSchema);
            var predEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel);

            return predEngine;
        }
    }
}
