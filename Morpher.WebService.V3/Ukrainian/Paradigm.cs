using Morpher.Ukrainian;

namespace Morpher.WebService.V3.Ukrainian
{
    internal class Paradigm : IParadigm
    {
        private readonly DeclensionForms _forms;

        public Paradigm(DeclensionForms forms)
        {
            _forms = forms;
        }

        public string Nominative => _forms.Nominative;
        public string Genitive => _forms.Genitive;
        public string Dative => _forms.Dative;
        public string Accusative => _forms.Accusative;
        public string Instrumental => _forms.Instrumental;
        public string Prepositional => _forms.Prepositional;
        public string Vocative => _forms.Vocative;
    }
}
