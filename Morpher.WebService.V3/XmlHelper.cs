using System.Xml;

namespace Morpher.WebService.V3
{
    static class XmlHelper
    {
        public static string GetAttributeOrNull(
            this XmlNode parameters,
            string name) => parameters?.Attributes?[name]?.Value;
    }
}
