using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// InteligentMerchantPromo Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentMerchantPromo : AopObject
    {
        /// <summary>
        /// 商户自运营活动，当promo_type='GENERAL_MERCHANT',该对象不能为空，其他类型无效
        /// </summary>
        [XmlElement("general_promo")]
        public InteligentGeneralMerchantPromo GeneralPromo { get; set; }

        /// <summary>
        /// 子活动营销类型；枚举值：（GENERAL_MERCHANT：商户自运营活动）
        /// </summary>
        [XmlElement("promo_type")]
        public string PromoType { get; set; }
    }
}
