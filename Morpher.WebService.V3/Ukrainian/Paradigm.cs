namespace Morpher.WebService.V3.Ukrainian
{
    using Morpher.Ukrainian;
    using Morpher.WebService.V3.Models;
    using Morpher.WebService.V3.Models.Interfaces;

    public class Paradigm : IParadigm
    {
        private readonly IUkrainianParadigm ukrainianParadigm;

        public Paradigm(IUkrainianParadigm ukrainianParadigm)
        {
            this.ukrainianParadigm = ukrainianParadigm;
        }

        public string Nominative => this.ukrainianParadigm.Nominative;

        public string Genitive => this.ukrainianParadigm.Genitive;

        public string Dative => this.ukrainianParadigm.Dative;

        public string Accusative => this.ukrainianParadigm.Accusative;

        public string Instrumental => this.ukrainianParadigm.Instrumental;

        public string Prepositional => this.ukrainianParadigm.Prepositional;

        public string Vocative => this.ukrainianParadigm.Vocative;
    }
}