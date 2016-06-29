using CsvHelper.Configuration;

namespace SecretQuestionTemplateProvider
{
    internal class ChobiAccountCsvMap: CsvClassMap<SecretQA>
    {
        public ChobiAccountCsvMap()
        {
            Map(m => m.Question).Name("秘密の質問項目");
            Map(m => m.Answer).Name("秘密の質問答え");
        }
    }
}