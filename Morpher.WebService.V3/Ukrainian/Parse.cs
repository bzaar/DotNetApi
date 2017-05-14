namespace Morpher.WebService.V3.Ukrainian
{
    using System;

    using Morpher.Ukrainian;
    using Morpher.WebService.V3.Models;

    internal class Parse : Paradigm, IParse
    {
        private readonly UkrainianDeclensionResult declensionResult;

        private readonly bool paid;

        public Parse(UkrainianDeclensionResult declensionResult, string lemma, bool paid)
            : base(lemma)
        {
            this.declensionResult = declensionResult;
            this.paid = paid;
        }

        public Gender Gender
        {
            get
            {
                switch (this.declensionResult.Gender)
                {
                    case "Чоловічий": return Gender.Masculine;
                    case "Жіночий": return Gender.Feminine;
                    case "Середній": return Gender.Neuter;
                    case null: return this.paid ? Gender.Plural : null;
                    default: throw new ApplicationException($"Веб-сервис вернул неожиданное значение рода: {this.declensionResult.Gender}");
                }
            }
        }

        protected override IParadigm UkrainianParadigm => this.declensionResult;
    }
}