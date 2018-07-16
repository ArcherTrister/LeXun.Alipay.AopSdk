using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// ExchangeRate Data Structure.
    /// </summary>
    [Serializable]
    public class ExchangeRate : AopObject
    {
        /// <summary>
        /// 兑换汇率的基本币种。biz_scene是LOCAL场景下，该参数返回为空。
        /// </summary>
        [XmlElement("base_currency")]
        public string BaseCurrency { get; set; }

        /// <summary>
        /// 兑换汇率对应的兑换目标币种. LOCAL场景下为空
        /// </summary>
        [XmlElement("exchange_currency")]
        public string ExchangeCurrency { get; set; }

        /// <summary>
        /// 转账币种兑换结算币种的汇率。biz_scene是LOCAL场景下，该参数返回空。
        /// </summary>
        [XmlElement("rate")]
        public long Rate { get; set; }
    }
}
