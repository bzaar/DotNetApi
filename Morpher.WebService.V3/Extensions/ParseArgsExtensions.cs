namespace Morpher.WebService.V3.Extensions
{
    using System;

    using Morpher.WebService.V3.Models;

    public static class ParseArgsExtensions
    {
        public static DeclensionFlags ToWebServiceFlags(this Morpher.Russian.ParseArgs parseArgs)
        {
            DeclensionFlags flags = default(DeclensionFlags);

            if (parseArgs.Category != null)
            {
                switch (parseArgs.Category)
                {
                    case Category.Name:
                        flags |= DeclensionFlags.FullName;
                        break;
                    case Category.Other:
                        flags |= DeclensionFlags.Common;
                        break;
                    default:
                        throw new ArgumentException("Unkown category in parseArgs", nameof(parseArgs.Category));
                }
            }

            if (parseArgs.IsAnimate != null)
            {
                if (parseArgs.IsAnimate.Value)
                {
                    flags |= DeclensionFlags.Animate;
                }
                else
                {
                    flags |= DeclensionFlags.Inanimate;
                }
            }

            if (parseArgs.Gender != null)
            {
                if (parseArgs.Gender is Gender._Masculine)
                {
                    flags |= DeclensionFlags.Masculine;
                }
                else if (parseArgs.Gender is Gender._Feminine)
                {
                    flags |= DeclensionFlags.Feminine;
                }
                else if (parseArgs.Gender is Gender._Neuter)
                {
                    flags |= DeclensionFlags.Neuter;
                }
                else if (parseArgs.Gender is Gender._Plural)
                {
                    flags |= DeclensionFlags.Plural;
                }
                else
                {
                    throw new ArgumentException("Unkown gender", nameof(parseArgs.Gender));
                }
            }

            return flags;
        }

        public static DeclensionFlags ToWebServiceFlags(this Morpher.Ukrainian.ParseArgs parseArgs)
        {
            DeclensionFlags flags = default(DeclensionFlags);

            if (parseArgs.Gender != null)
            {
                if (parseArgs.Gender is Gender._Masculine)
                {
                    flags |= DeclensionFlags.Masculine;
                }
                else if (parseArgs.Gender is Gender._Feminine)
                {
                    flags |= DeclensionFlags.Feminine;
                }
                else if (parseArgs.Gender is Gender._Neuter)
                {
                    flags |= DeclensionFlags.Neuter;
                }
                else if (parseArgs.Gender is Gender._Plural)
                {
                    flags |= DeclensionFlags.Plural;
                }
                else
                {
                    throw new ArgumentException("Unkown gender", nameof(parseArgs.Gender));
                }
            }

            return flags;
        }
    }
}
