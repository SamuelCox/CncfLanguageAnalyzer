using CsvHelper;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace CncfLanguageAnalyzer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var inputFilePath = args[0];
            var outputFilePath = args[1];
            var token = args[2];

            var github = new Github(token);

            var records = await ReadCsv(github, inputFilePath);
            WriteCsv(records, outputFilePath);
        }

        private static async Task<IEnumerable<CncfRecordWithLanguage>> ReadCsv(Github github, string inputFilePath)
        {
            var transformedRecords = new List<CncfRecordWithLanguage>();
            using (var reader = new StreamReader(inputFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CncfRecord>();
                foreach (var record in records)
                {
                    var transformedRecord = CncfRecordWithLanguage.Create(record);
                    if (!string.IsNullOrEmpty(record.GithubRepo))
                    {                        
                        transformedRecord.Languages = await github.GetMostUsedLanguageForRepo(transformedRecord.GithubRepo);                        
                    }
                    transformedRecords.Add(transformedRecord);
                }
                return transformedRecords;
            }
        }

        private static void WriteCsv(IEnumerable<CncfRecordWithLanguage> records, string outputFilePath)
        {
            using (var writer = new StreamWriter(outputFilePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }

    
}
