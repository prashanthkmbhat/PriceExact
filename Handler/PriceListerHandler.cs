using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuppliesPriceLister.Models.Views;
using SuppliesPriceLister.Utilites;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SuppliesPriceLister.Handler
{
    public class PriceListerHandler: IPriceListerHandler
    {
        public PriceListerHandler() { }
        public List<SuppliesViewModel> combinepricedata()
        {
            IConfiguration configuration = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
               .Build();

            string solutionDirectory = AppDomain.CurrentDomain.BaseDirectory;


            // Read settings
            string jsonFilePath = configuration["filePath:jsonPath"];
            jsonFilePath = Path.Combine(solutionDirectory, jsonFilePath);
            string csvFilePath = configuration["filePath:csvPath"];
            csvFilePath = Path.Combine(solutionDirectory, csvFilePath); 

            float exchangeRate = float.Parse(configuration["audUsdExchangeRate"]);

            ReadCSV readCSV = new ReadCSV();
            // Your solution begins here
            List<SuppliesViewModel> CSVSupplies = readCSV.ReadCsvData(csvFilePath);

            ReadJson readJson = new ReadJson();
            List<SuppliesViewModel> JsonSupplies = readJson.ReadJsonData(jsonFilePath, exchangeRate);

            List<SuppliesViewModel> combinedSupplies = CSVSupplies.Concat(JsonSupplies).OrderByDescending(x => x.Price).ToList();

            return combinedSupplies;
        }
    }
}
