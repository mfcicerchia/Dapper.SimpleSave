﻿using System;
using System.Runtime.Serialization;
using PS.Mothership.Core.Common.Template.Dial;

namespace PS.Mothership.Core.Common.Dto.Dialler
{
    [DataContract]
    public class NewDiallerCallDto
    {
        [DataMember]
        public Guid SipCallGuid { get; set; }
        [DataMember]
        public DialCallTypeEnum CallType { get; set; }
        [DataMember]
        public Guid SessionModeGuid { get; set; }
        [DataMember]
        public DateTimeOffset StartDateTime { get; set; }
        [DataMember]
        public string DialledNumber { get; set; }
        [DataMember]
        public string DisplayNumber { get; set; }
        [DataMember]
        public Guid UserSipPhoneGuid { get; set; }
        [DataMember]
        public string CIDNumber { get; set; }
        [DataMember]
        public Guid MerchantGuid { get; set; }
        [DataMember]
        public Guid ProspectingCampaignCallGuid { get; set; }
        [DataMember]
        public Guid CampaignGuid { get; set; }
        [DataMember]
        public Guid ConsultOriginSipCallGuid { get; set; }
        [DataMember]
        public Guid ResponseTapTrnGuid { get; set; }
        [DataMember]
        public DialCallDispositionEnum CallDisposition { get; set; }
        [DataMember]
        public string Keyword { get; set; }
        [DataMember]
        public string ReferrerUrl { get; set; }
    }
}
