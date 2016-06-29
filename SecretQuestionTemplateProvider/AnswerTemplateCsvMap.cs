using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretQuestionTemplateProvider
{
    class AnswerTemplateCsvMap : CsvClassMap<AnswerTemplate>
    {
        public AnswerTemplateCsvMap()
        {
//            Map(m => m.Id).Name(AnswerTemplate.Columns["Id"]);
//            Map(m => m.Respondent).Name(AnswerTemplate.Columns["Respondent"]);
//            Map(m => m.RespondentUrl).Name(AnswerTemplate.Columns["RespondentUrl"]);
//            Map(m => m.Date).Name(AnswerTemplate.Columns["Date"]);
            Map(m => m.PreFamilyNameOfMother).Name(AnswerTemplate.Columns["PreFamilyNameOfMother"]);
            Map(m => m.FavoriteFood).Name(AnswerTemplate.Columns["FavoriteFood"]);
//            Map(m => m.NickNameInChildhood).Name(AnswerTemplate.Columns["NickNameInChildhood"]);
//            Map(m => m.FirstSong).Name(AnswerTemplate.Columns["FirstSong"]);
//            Map(m => m.FirstLover).Name(AnswerTemplate.Columns["FirstLover"]);
//            Map(m => m.DreamInChildhood).Name(AnswerTemplate.Columns["DreamInChildhood"]);
            Map(m => m.FirstNameOfGrandfather).Name(AnswerTemplate.Columns["FirstNameOfGrandfather"]);
//            Map(m => m.FirstMovie).Name(AnswerTemplate.Columns["FirstMovie"]);
        }
    }
}
