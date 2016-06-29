using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretQuestionTemplateProvider
{
    class AnswerTemplate
    {
        public static readonly IReadOnlyDictionary<string, string> Columns =
            new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()
            {
                { "Id", "作業ID" },
                {"Respondent", "作業者" },
                {"RespondentUrl", "作業者ページURL" },
                {"Date", "承認日時" },
                {"PreFamilyNameOfMother", "1. 母親の旧姓" },
                {"FavoriteFood", "2. 好きな食べ物" },
                {"NickNameInChildhood", "3. 子供のころのあだ名" },
                {"FirstSong", "4. 初めて買った曲のタイトル" },
                {"FirstLover", "5. 初恋の人の名前" },
                {"DreamInChildhood", "6. 子どものころの夢" },
                {"FirstNameOfGrandfather", "7. 祖父の下の名前" },
                {"FirstMovie", "8. 初めて見た映画" }
            });
        public int Id { get; set; }
        public string Respondent { get; set; }
        public string RespondentUrl { get; set; }
        public DateTime Date { get; set; }
        public string PreFamilyNameOfMother { get; set; }
        public string FavoriteFood { get; set; }
        public string NickNameInChildhood { get; set; }
        public string FirstSong { get; set; }
        public string FirstLover { get; set; }
        public string DreamInChildhood { get; set; }
        public string FirstNameOfGrandfather { get; set; }
        public string FirstMovie { get; set; }
    }
}
