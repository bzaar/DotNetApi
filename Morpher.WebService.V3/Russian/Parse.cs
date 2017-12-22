using System;
using Morpher.Russian;

namespace Morpher.WebService.V3.Russian
{
    internal class Parse : Paradigm, IParse
    {
        private readonly DeclensionResult _declensionResult;

        public Parse(DeclensionResult declensionResult) : base(declensionResult)
        {
            _declensionResult = declensionResult;
            if (declensionResult.Plural != null) Plural = new Paradigm(declensionResult.Plural);
        }

        public IParadigm Plural { get; }

        public Morpher.Gender Gender
        {
            get
            {
                switch (_declensionResult.Gender)
                {
                    case Russian.Gender.Masculine: return Morpher.Gender.Masculine;
                    case Russian.Gender.Feminine: return Morpher.Gender.Feminine;
                    case Russian.Gender.Neuter: return Morpher.Gender.Feminine;
                    case Russian.Gender.Plural: return Morpher.Gender.Plural;
                    case null: return null;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }

        // TODO: Not implemented in WS3
        public bool IsAnimate => throw new NotImplementedException();

        // TODO: Not implemented in WS3
        public string Paucal => throw new NotImplementedException();
    }
}
