namespace Morpher.WebService.V3.Russian
{
    internal class UnitParadigm : Paradigm
    {
        private readonly DeclensionForms _forms;

        public UnitParadigm(DeclensionForms forms) : base(forms)
        {
            _forms = forms;
        }

        public override string Locative => _forms.Prepositional;
    }
}
