﻿namespace Morpher.WebService.V3.Models
{
    using System.Runtime.Serialization;

    [DataContract(Name = "GetXmlUkrResult", Namespace = "http://schemas.datacontract.org/2004/07/Morpher.WebApi.Models")]
    internal class UkrainianDeclensionResult : UkrainianDeclensionForms
    {
        [DataMember(Name = "рід")]
        public string Gender { get; set; }
    }
}