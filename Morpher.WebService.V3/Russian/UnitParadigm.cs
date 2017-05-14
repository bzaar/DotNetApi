namespace Morpher.WebService.V3.Russian
{
    using Morpher.Russian;
    using Morpher.WebService.V3.Models;

    internal class UnitParadigm : Paradigm
    {
        private readonly RussianDeclensionForms declensionForms;

        public UnitParadigm(RussianDeclensionForms declensionForms)
            : base(declensionForms.Nominative)
        {
            this.declensionForms = declensionForms;
        }

        protected override IParadigm RussianParadigm => this.declensionForms;

        // В версии 2 тут находится override Locative
        // В версии 3 по идее он не нужен.
    }
}
