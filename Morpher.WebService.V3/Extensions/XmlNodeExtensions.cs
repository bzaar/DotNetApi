namespace Morpher.WebService.V3.Extensions
{
    using System;
    using System.Xml;

    public static class XmlNodeExtensions
    {
        public static string GetAttributeOrNull(this XmlNode parameters, string name)
        {
            var attribute = parameters?.Attributes?[name];
            return attribute?.Value;
        }

        public static string GetAttribute(this XmlNode parameters, string name)
        {
            var param = parameters.GetAttributeOrNull("key");

            if (param == null)
            {
                throw new Exception("Parameter '" + name + "' is required.");
            }

            return param;
        }
    }
}
