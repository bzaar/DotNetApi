﻿namespace Morpher.Ukrainian
{
    public class Case : ICase <IParadigm>
    {
        delegate string Func (IParadigm p);

        private readonly Func func;

        Case (Func func)
        {
            this.func = func;
        }

        public string Get (IParadigm paradigm)
        {
            return func (paradigm);
        }

        public static Case Nominative    = new Case (p => p.Nominative   );
        public static Case Genitive      = new Case (p => p.Genitive     );
        public static Case Dative        = new Case (p => p.Dative       );
        public static Case Accusative    = new Case (p => p.Accusative   );
        public static Case Instrumental  = new Case (p => p.Instrumental );
        public static Case Prepositional = new Case (p => p.Prepositional);
        public static Case Vocative      = new Case (p => p.Vocative     );
    }
}