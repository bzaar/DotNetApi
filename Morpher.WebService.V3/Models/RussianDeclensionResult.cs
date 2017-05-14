﻿namespace Morpher.WebService.V3.Models
{
    using System.Runtime.Serialization;

    [DataContract(Name = "xml", Namespace = "http://schemas.datacontract.org/2004/07/Morpher.WebApi.Models")]
    internal class RussianDeclensionResult : RussianDeclensionForms
    {
        [DataMember(Name = "род")]
        public string Gender { get; set; }

        [DataMember(Name = "множественное")]
        public RussianDeclensionForms Plural { get; set; }

        [DataMember(Name = "ФИО")]
        public FullName FullName { get; set; }

        [DataMember(Name = "где")]
        public string Where { get; set; }

        [DataMember(Name = "куда")]
        public string To { get; set; }

        [DataMember(Name = "откуда")]
        public string From { get; set; }
    }
}