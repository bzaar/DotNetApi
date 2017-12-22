using System;
using Morpher.Ukrainian;

namespace Morpher.WebService.V3.Ukrainian
{
    internal class Parse : Paradigm, IParse
    {
        private readonly DeclensionResult _declensionResult;

        public Parse(DeclensionResult declensionResult) : base(declensionResult)
        {
            _declensionResult = declensionResult;
        }

        public Morpher.Gender Gender
        {
            get
            {
                switch (_declensionResult.Gender)
                {
                    case Ukrainian.Gender.Masculine: return Morpher.Gender.Masculine;
                    case Ukrainian.Gender.Feminine: return Morpher.Gender.Feminine;
                    case Ukrainian.Gender.Neuter: return Morpher.Gender.Neuter;
                    case Ukrainian.Gender.Plural: return Morpher.Gender.Plural;
                    case null: return null;
                    default: throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
