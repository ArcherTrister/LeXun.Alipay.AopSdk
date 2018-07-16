using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// ZhimaCreditEpFreedepositInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpFreedepositInitializeModel : AopObject
    {
        /// <summary>
        /// 业务场景，生活号：SHENGHUOHAO
        /// </summary>
        [XmlElement("biz_channel")]
        public string BizChannel { get; set; }

        /// <summary>
        /// 业务来源标识，由前置跳转传递给服务商系统，服务商不需要理解，在本接口传入即可
        /// </summary>
        [XmlElement("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 法人证件号码
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 法人证件类型，大陆身份证：IDENTITY_CARD
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 类目
        /// </summary>
        [XmlElement("credit_category")]
        public string CreditCategory { get; set; }

        /// <summary>
        /// 企业证件号
        /// </summary>
        [XmlElement("ep_cert_no")]
        public string EpCertNo { get; set; }

        /// <summary>
        /// 企业证件类型：  NATIONAL_LEGAL---工商注册号  NATIONAL_LEGAL_MERGE---社会统一信用代码
        /// </summary>
        [XmlElement("ep_cert_type")]
        public string EpCertType { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [XmlElement("ep_name")]
        public string EpName { get; set; }

        /// <summary>
        /// 商户传入的跳转地址，该地址由商户调用时候传入，系统不处理，在applay接口完成处理后在biz_content内容带回，由商户系统做完回跳解析后执行redirect
        /// </summary>
        [XmlElement("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 商户业务流水号，确保每次业务唯一。
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 企业免押额度申请产品码
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 请求ID，如果是企业信用页面发起的，会在前置流程里面传递给商户该请求值，商户直接在本接口传递接收到的值即可
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
