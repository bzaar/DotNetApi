namespace Morpher.WebService.V3.Ukrainian
{
    using Morpher.Ukrainian;
    using Morpher.WebService.V3.Models;

    internal class UnitParadigm : Paradigm
    {
        private readonly UkrainianDeclensionForms declensionForms;

        public UnitParadigm(UkrainianDeclensionForms declensionForms)
            : base(declensionForms.Nominative)
        {
            this.declensionForms = declensionForms;
        }

        protected override IParadigm UkrainianParadigm => this.declensionForms;
    }
}
