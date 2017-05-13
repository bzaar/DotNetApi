namespace Morpher.WebService.V3.Ukrainian
{
    using System;

    using Morpher.Ukrainian;
    using Morpher.WebService.V3.Models;

    public class Parse : IParse
    {
        private readonly UkrainianDeclensionResult declensionResult;

        public Parse(UkrainianDeclensionResult declensionResult, string lemma)
        {
            this.declensionResult = declensionResult;
        }

        public Gender Gender
        {
            // TODO: Do this!
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Nominative => this.declensionResult.Nominative;

        public string Genitive => this.declensionResult.Genitive;

        public string Dative => this.declensionResult.Dative;

        public string Accusative => this.declensionResult.Accusative;

        public string Instrumental => this.declensionResult.Instrumental;

        public string Prepositional => this.declensionResult.Prepositional;

        public string Vocative => this.declensionResult.Vocative;
    }
}