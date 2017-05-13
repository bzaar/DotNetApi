namespace Morpher.WebService.V3.Russian
{
    using Morpher.WebService.V3.Models;
    using Morpher.WebService.V3.Models.Interfaces;

    public class UnitParadigm : Paradigm
    {
        private readonly RussianDeclensionForms declensionForms;

        public UnitParadigm(RussianDeclensionForms declensionForms)
            : base(declensionForms.Nominative)
        {
            this.declensionForms = declensionForms;
        }

        protected override IRussianParadigm RussianParadigm => this.declensionForms;

        // В версии 2 тут находится override Locative
        // В версии 3 по идее он не нужен.
    }
}
