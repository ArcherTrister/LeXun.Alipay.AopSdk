using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// MybankCreditSceneprodVidGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodVidGetModel : AopObject
    {
        /// <summary>
        /// 支付宝版本号
        /// </summary>
        [XmlElement("alipay_version")]
        public string AlipayVersion { get; set; }

        /// <summary>
        /// 机构编码
        /// </summary>
        [XmlElement("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
