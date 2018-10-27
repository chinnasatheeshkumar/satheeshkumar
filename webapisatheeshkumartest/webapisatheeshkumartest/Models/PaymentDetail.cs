using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace webapisatheeshkumartest.Models
{
    [DataContract]
    public class PaymentDetail
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public long ApplicationId { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Summary { get; set; }
        [DataMember]
        public DateTime PostingDate { get; set; }
        [DataMember]
        public bool IsCleared { get; set; }
        [DataMember]
        public DateTime? ClearedDate { get; set; }
        [DataMember]
        public decimal Amount { get; internal set; }
    }
}