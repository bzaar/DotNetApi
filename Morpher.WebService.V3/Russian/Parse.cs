namespace Morpher.WebService.V3.Russian
{
    using System;

    using Morpher.Russian;
    using Morpher.WebService.V3.Models;
    using Morpher.WebService.V3.Models.Interfaces;

    public class Parse : Paradigm, IParse
    {
        private readonly RussianDeclensionResult declensionResult;

        public Parse(RussianDeclensionResult declensionResult, string lemma)
            : base(lemma)
        {
            this.declensionResult = declensionResult;
        }

        public IParadigm Plural => this.declensionResult.Plural;

        public Gender Gender
        {
            get
            {
                switch (this.declensionResult.Gender)
                {
                    case "Мужской": return Gender.Masculine;
                    case "Женский": return Gender.Feminine;
                    case "Средний": return Gender.Plural;
                    case "": return Gender.Plural;
                    default: throw new ApplicationException($"Веб-сервис вернул неожиданное значение рода: {this.declensionResult.Gender}");
                }
            }
        }

        public bool IsAnimate
        {
            get { throw new NotImplementedException(); }
        }

        public string Paucal
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        protected override IRussianParadigm RussianParadigm => this.declensionResult;
    }
}
