namespace Morpher
{
    public abstract class Gender
    {
        public abstract T Get<T>(IGenderParadigm<T> p);

        public class _Masculine : Gender
        {
            internal _Masculine()
            {
            }

            public override T Get<T>(IGenderParadigm<T> p)
            {
                return p.Masculine;
            }
        }

        public class _Feminine : Gender
        {
            internal _Feminine()
            {
            }

            public override T Get<T>(IGenderParadigm<T> p)
            {
                return p.Feminine;
            }
        }

        public class _Neuter : Gender
        {
            internal _Neuter()
            {
            }

            public override T Get<T>(IGenderParadigm<T> p)
            {
                return p.Neuter;
            }
        }

        public class _Plural : Gender
        {
            internal _Plural()
            {
            }

            public override T Get<T>(IGenderParadigm<T> p)
            {
                return p.Plural;
            }
        }

        public static Gender Masculine = new _Masculine();
        public static Gender Feminine = new _Feminine();
        public static Gender Neuter = new _Neuter();
        public static Gender Plural = new _Plural();
    }
}



