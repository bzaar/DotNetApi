namespace Morpher.WebService.V3.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    internal class ServiceErrorMessage
    {
        [DataMember(Name = "code")]
        public int Code { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
