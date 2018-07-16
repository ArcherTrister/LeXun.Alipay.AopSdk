using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// SettleDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SettleDetailInfo : AopObject
    {
        /// <summary>
        /// 结算的金额，单位为元。目前必须和交易金额相同
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 结算汇总维度，按照这个维度汇总成批次结算，由商户指定。    目前需要和结算收款方账户类型为cardSerialNo配合使用
        /// </summary>
        [XmlElement("summary_dimension")]
        public string SummaryDimension { get; set; }

        /// <summary>
        /// 结算收款方。当结算收款方类型是cardSerialNo时，本参数为用户在支付宝绑定的卡编号
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 结算收款方的账户类型。    cardSerialNo：结算收款方的银行卡编号。    目前只支持cardSerialNo账户类型
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }
    }
}
