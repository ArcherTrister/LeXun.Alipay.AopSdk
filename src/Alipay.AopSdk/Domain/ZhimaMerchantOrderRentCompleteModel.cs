using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// ZhimaMerchantOrderRentCompleteModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantOrderRentCompleteModel : AopObject
    {
        /// <summary>
        /// 扩展信息。商户发起借用服务时的扩展信息字段，格式：json，注意，如果字符串对应的json对象包含中文字符，需要对包含中文的字段进行编码
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 信用借还订单号
        /// </summary>
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额
        /// </summary>
        [XmlElement("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 金额类型：  RENT:租金  DAMAGE:赔偿金
        /// </summary>
        [XmlElement("pay_amount_type")]
        public string PayAmountType { get; set; }

        /// <summary>
        /// 信用借还的产品码:w1010100000000002858
        /// </summary>
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 物品归还门店名称
        /// </summary>
        [XmlElement("restore_shop_name")]
        public string RestoreShopName { get; set; }

        /// <summary>
        /// 物品实际归还时间，borrow_time<restore_time<当前时间+24小时，即该时间不能早于借还订单创建时的borrow_time，且最晚不能晚于当前时间后24小时。
        /// </summary>
        [XmlElement("restore_time")]
        public string RestoreTime { get; set; }
    }
}
