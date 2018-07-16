using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// ZhimaCreditEpLawsuitRecordGetResponse.
    /// </summary>
    public class ZhimaCreditEpLawsuitRecordGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业涉诉记录
        /// </summary>
        [XmlElement("lawsuit_record")]
        public LawsuitRecord LawsuitRecord { get; set; }
    }
}
