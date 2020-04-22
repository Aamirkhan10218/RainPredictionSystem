using System;
using RainPredictionML.Model;
using System.Text;
namespace RainPrediction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Add input data
            var input = new ModelInput();
            input.Date = DateTime.Now.ToShortDateString();
            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
        }
    }
}
