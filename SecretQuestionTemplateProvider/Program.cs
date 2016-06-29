using CsvHelper;
using Google.GData.Spreadsheets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretQuestionTemplateProvider
{
    static class Program
    {
        static void Main(string[] args)
        {
            int count = 100;
            string csvFileName = args[0];
            string chobiFileName = args[1];

            //chobi 読み込み
            List<SecretQA> existingQAs;
            using (TextReader chobiReader = new StreamReader(chobiFileName))
            using (CsvReader chobiCsvReader = new CsvReader(chobiReader))
            {
                chobiCsvReader.Configuration.RegisterClassMap<ChobiAccountCsvMap>();
                chobiCsvReader.Configuration.HasHeaderRecord = true;
                existingQAs = chobiCsvReader.GetRecords<SecretQA>().ToList();
            }

            //templateCSV 読み込み
            List<SecretQA> templates;
            using (TextReader reader = new StreamReader(csvFileName))
            using (CsvReader csvReader = new CsvReader(reader))
            {
                csvReader.Configuration.RegisterClassMap<AnswerTemplateCsvMap>();
                csvReader.Configuration.HasHeaderRecord = true;
                var records = csvReader.GetRecords<AnswerTemplate>();
                templates = records.Aggregate(new List<SecretQA>(), (l, r) =>
                 {
                     l.Add(new SecretQA("母親の旧姓は？", r.PreFamilyNameOfMother));
                     l.Add(new SecretQA("好きな食べ物は？", r.FavoriteFood));
                     l.Add(new SecretQA("祖父の下の名前は？", r.FirstNameOfGrandfather));
                     return l;
                 }).Distinct().Where(t => !existingQAs.Contains(t)).ToList();
            }

            //shuffle
            var random = new Random();
            for(int i = 0, c = templates.Count(); i < c; i++)
            {
                int r = random.Next(i, c);
                var swap = templates[r];
                templates[r] = templates[i];
                templates[i] = swap;
            }

            //標準出力
            for(int i = 0; i < count; i++)
            {
                Console.Write(templates[i].Question);
                Console.Write("\t");
                Console.Write(templates[i].Answer);
                Console.WriteLine();
            }

            //入力待ち
            Console.ReadKey();
        }
    }
}
