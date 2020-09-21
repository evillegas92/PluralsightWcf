using System.Runtime.Serialization;

namespace PluralsightWcf.Business.Models
{
    [DataContract]
    public class OrderResponse
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public int OrderId { get; set; }

        [DataMember]
        public string ErrorMessage { get; set; }
    }
}
