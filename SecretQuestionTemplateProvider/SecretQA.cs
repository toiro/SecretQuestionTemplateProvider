using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretQuestionTemplateProvider
{
    class SecretQA
    {
        public SecretQA() { }
        public SecretQA(string question, string answer)
        {
            this.Question = question;
            this.Answer = answer;
        }
        public string Question { get; set; }
        public string Answer { get; set; }

        public override bool Equals(Object obj)
        {
            SecretQA that = obj as SecretQA;
            if (that == null) return false;

            return this.Question == that.Question && this.Answer == that.Answer;
        }

        public override int GetHashCode()
        {
            return this.Question.GetHashCode() | this.Answer.GetHashCode();
        }
    }

}
