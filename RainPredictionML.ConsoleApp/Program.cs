// This file was auto-generated by ML.NET Model Builder. 

using System;
using System.IO;
using System.Linq;
using Microsoft.ML;
using RainPredictionML.Model;

namespace RainPredictionML.ConsoleApp
{
    class Program
    {
        //Dataset to use for predictions 
        private const string DATA_FILEPATH = @"D:\Dataset\Islamabad Data.csv";

        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = CreateSingleDataSample(DATA_FILEPATH);

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Col2009 with predicted Col2009 from sample data...\n\n");
            Console.WriteLine($"Date: {sampleData.Date}");
            Console.WriteLine($"1998: {sampleData.Col1998}");
            Console.WriteLine($"1999: {sampleData.Col1999}");
            Console.WriteLine($"2000: {sampleData.Col2000}");
            Console.WriteLine($"2001: {sampleData.Col2001}");
            Console.WriteLine($"2002: {sampleData.Col2002}");
            Console.WriteLine($"2003: {sampleData.Col2003}");
            Console.WriteLine($"2004: {sampleData.Col2004}");
            Console.WriteLine($"2005: {sampleData.Col2005}");
            Console.WriteLine($"2006: {sampleData.Col2006}");
            Console.WriteLine($"2007: {sampleData.Col2007}");
            Console.WriteLine($"2008: {sampleData.Col2008}");
            Console.WriteLine($"2010: {sampleData.Col2010}");
            Console.WriteLine($"2011: {sampleData.Col2011}");
            Console.WriteLine($"2012: {sampleData.Col2012}");
            Console.WriteLine($"2013: {sampleData.Col2013}");
            Console.WriteLine($"2014: {sampleData.Col2014}");
            Console.WriteLine($"2015: {sampleData.Col2015}");
            Console.WriteLine($"2016: {sampleData.Col2016}");
            Console.WriteLine($"2017: {sampleData.Col2017}");
            Console.WriteLine($"\n\nActual Col2009: {sampleData.Col2009} \nPredicted Col2009: {predictionResult.Score}\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }

        // Change this code to create your own sample data
        #region CreateSingleDataSample
        // Method to load single row of dataset to try a single prediction
        private static ModelInput CreateSingleDataSample(string dataFilePath)
        {
            // Create MLContext
            MLContext mlContext = new MLContext();

            // Load dataset
            IDataView dataView = mlContext.Data.LoadFromTextFile<ModelInput>(
                                            path: dataFilePath,
                                            hasHeader: true,
                                            separatorChar: ',',
                                            allowQuoting: true,
                                            allowSparse: false);

            // Use first line of dataset as model input
            // You can replace this with new test data (hardcoded or from end-user application)
            ModelInput sampleForPrediction = mlContext.Data.CreateEnumerable<ModelInput>(dataView, false)
                                                                        .First();
            return sampleForPrediction;
        }
        #endregion
    }
}
