namespace Morpher.WebService.V3.Ukrainian
{
    using Morpher.Ukrainian;

    internal abstract class Paradigm : IParadigm
    {
        protected Paradigm(string lemma)
        {
            this.Nominative = lemma;
        }

        public string Nominative { get; }

        public string Genitive => this.UkrainianParadigm.Genitive;

        public string Dative => this.UkrainianParadigm.Dative;

        public string Accusative => this.UkrainianParadigm.Accusative;

        public string Instrumental => this.UkrainianParadigm.Instrumental;

        public string Prepositional => this.UkrainianParadigm.Prepositional;

        public string Vocative => this.UkrainianParadigm.Vocative;

        protected abstract IParadigm UkrainianParadigm { get; }
    }
}