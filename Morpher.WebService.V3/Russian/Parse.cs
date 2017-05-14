namespace Morpher.WebService.V3.Russian
{
    using System;

    using Morpher.Russian;
    using Morpher.WebService.V3.Models;

    internal class Parse : Paradigm, IParse
    {
        private readonly RussianDeclensionResult declensionResult;

        private readonly bool paid;

        public Parse(RussianDeclensionResult declensionResult, string lemma, bool paid)
            : base(lemma)
        {
            this.declensionResult = declensionResult;
            this.paid = paid;
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
                    case "Средний": return Gender.Neuter;
                    case null: return this.paid ? Gender.Plural : null;
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

        protected override IParadigm RussianParadigm => this.declensionResult;
    }
}
