namespace Morpher.WebService.V3
{
    using System.Collections.Specialized;
    using System.Globalization;
    using System.Net;
    using System.Text;
    using System.Xml;

    using Morpher.WebService.V3.Extensions;
    using Morpher.WebService.V3.Models;
    using Morpher.WebService.V3.Models.Exceptions;

    public class Client :
        Morpher.Russian.IDeclension,
        Morpher.Ukrainian.IDeclension,
        Morpher.Russian.INumberSpelling,
        Morpher.Ukrainian.INumberSpelling
    {
        private readonly string url;

        private readonly string token;

        public Client() : this((Parameters)null)
        {
        }

        public Client(Parameters parameters)
        {
            parameters = parameters ?? new Parameters();

            this.token = parameters.Token;
            this.url = parameters.Url ?? "http://api3.moprher.ru";
        }

        public Client(XmlNode node)
            : this(new Parameters()
            {
                Token = node.GetAttributeOrNull("token"),
                Url = node.GetAttributeOrNull("url")
            })
        {
        }

        public Morpher.Russian.IParse Parse(string s, Morpher.Russian.ParseArgs args = null)
        {
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                if (this.token != null)
                {
                    client.QueryString.Add("token", this.token);
                }

                if (args != null)
                {
                    client.QueryString.Add("flags", ((int)args.ToWebServiceFlags()).ToString());
                }

                client.QueryString.Add("format", "json");
                client.QueryString.Add("s", s);

                object result = client.GetObject(typeof(RussianDeclensionResult), $"{this.url}/russian/declension");

                var declensionResult = result as RussianDeclensionResult;
                if (declensionResult != null)
                {
                    return new Russian.Parse(declensionResult, s, this.token != null);
                }
                else
                {
                    ServiceErrorMessage errorMessage = (ServiceErrorMessage)result;
                    throw new MorpherWebServiceException(errorMessage.Message, errorMessage.Code);
                }
            }
        }

        public Morpher.Ukrainian.IParse Parse(string s, Morpher.Ukrainian.ParseArgs args = null)
        {
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                if (this.token != null)
                {
                    client.QueryString.Add("token", this.token);
                }

                if (args != null)
                {
                    client.QueryString.Add("flags", ((int)args.ToWebServiceFlags()).ToString());
                }


                client.QueryString.Add("format", "json");
                client.QueryString.Add("s", s);

                object result = client.GetObject(typeof(UkrainianDeclensionResult), $"{this.url}/ukrainian/declension");

                var declensionResult = result as UkrainianDeclensionResult;
                if (declensionResult != null)
                {
                    return new Ukrainian.Parse(declensionResult, s, this.token != null);
                }
                else
                {
                    ServiceErrorMessage errorMessage = (ServiceErrorMessage)result;
                    throw new MorpherWebServiceException(errorMessage.Message, errorMessage.Code);
                }
            }
        }

        public string Spell(decimal n, ref string unit, ICase<Morpher.Russian.IParadigm> @case)
        {
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                if (this.token != null)
                {
                    client.QueryString.Add("token", this.token);
                }

                client.QueryString.Add("format", "json");
                client.QueryString.Add("n", n.ToString(CultureInfo.InvariantCulture));
                client.QueryString.Add("unit", unit);

                object result = client.GetObject(typeof(RussianNumberSpelling), $"{this.url}/russian/spell");

                RussianNumberSpelling numberSpelling = result as RussianNumberSpelling;
                if (numberSpelling != null)
                {
                    unit = new Russian.UnitParadigm(numberSpelling.UnitDeclension).Get(@case);
                    return new Russian.UnitParadigm(numberSpelling.NumberDeclension).Get(@case);
                }
                else
                {
                    ServiceErrorMessage errorMessage = (ServiceErrorMessage)result;
                    throw new MorpherWebServiceException(errorMessage.Message, errorMessage.Code);
                }
            }
        }

        public string Spell(decimal n, ref string unit, ICase<Morpher.Ukrainian.IParadigm> @case)
        {
            using (WebClient client = new WebClient() { Encoding = Encoding.UTF8 })
            {
                NameValueCollection values = new NameValueCollection();

                if (this.token != null)
                {
                    client.QueryString.Add("token", this.token);
                }

                client.QueryString.Add("format", "json");
                client.QueryString.Add("n", n.ToString(CultureInfo.InvariantCulture));
                client.QueryString.Add("unit", unit);

                object result = client.GetObject(typeof(UkrainianNumberSpelling), $"{this.url}/ukrainian/spell");

                UkrainianNumberSpelling numberSpelling = result as UkrainianNumberSpelling;
                if (numberSpelling != null)
                {
                    unit = new Ukrainian.UnitParadigm(numberSpelling.UnitDeclension).Get(@case);
                    return new Ukrainian.UnitParadigm(numberSpelling.NumberDeclension).Get(@case);
                }
                else
                {
                    ServiceErrorMessage errorMessage = (ServiceErrorMessage)result;
                    throw new MorpherWebServiceException(errorMessage.Message, errorMessage.Code);
                }
            }
        }
    }
}
