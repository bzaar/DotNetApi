namespace Morpher.WebService.V3
{
    using System.Collections.Specialized;
    using System.Globalization;
    using System.Net;
    using System.Text;
    using System.Xml;

    using Morpher.WebService.V3.Extensions;
    using Morpher.WebService.V3.Models;

    using Newtonsoft.Json;

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

                client.QueryString.Add("format", "json");
                client.QueryString.Add("s", s);

                var responseString = client.DownloadString($"{this.url}/russian/declension");

                RussianDeclensionResult declensionResult =
                    JsonConvert.DeserializeObject<RussianDeclensionResult>(responseString);

                return new Russian.Parse(declensionResult, s);
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

                client.QueryString.Add("format", "json");
                client.QueryString.Add("s", s);

                var responseString = client.DownloadString($"{this.url}/ukrainian/declension");

                UkrainianDeclensionResult declensionResult =
                    JsonConvert.DeserializeObject<UkrainianDeclensionResult>(responseString);

                return new Ukrainian.Parse(declensionResult, s);
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

                var responseString = client.DownloadString($"{this.url}/russian/spell");

                RussianNumberSpelling numberSpelling =
                    JsonConvert.DeserializeObject<RussianNumberSpelling>(responseString);

                unit = new Russian.UnitParadigm(numberSpelling.UnitDeclension).Get(@case);
                return new Russian.UnitParadigm(numberSpelling.NumberDeclension).Get(@case);
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

                var responseString = client.DownloadString($"{this.url}/ukrainian/spell");

                UkrainianNumberSpelling numberSpelling =
                    JsonConvert.DeserializeObject<UkrainianNumberSpelling>(responseString);

                unit = new Ukrainian.Paradigm(numberSpelling.UnitDeclension).Get(@case);
                return new Ukrainian.Paradigm(numberSpelling.NumberDeclension).Get(@case);
            }
        }
    }
}
