namespace Morpher.WebService.V3.Russian
{
    using Morpher.Russian;
    using Morpher.WebService.V3.Models.Interfaces;

    public abstract class Paradigm : IParadigm
    {
        protected Paradigm(string lemma)
        {
            this.Nominative = lemma;
        }

        public string Nominative { get; }

        public string Genitive => this.RussianParadigm.Genitive;

        public string Dative => this.RussianParadigm.Dative;

        public string Accusative => this.RussianParadigm.Accusative;

        public string Instrumental => this.RussianParadigm.Instrumental;

        public string Prepositional => this.RussianParadigm.Prepositional;

        public string Locative => this.RussianParadigm.Locative;

        protected abstract IRussianParadigm RussianParadigm { get; }
    }
}
