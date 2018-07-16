using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiTradeVoucherItemTemplete Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiTradeVoucherItemTemplete : AopObject
    {
        /// <summary>
        /// 购买须知，列表类型，最多10项
        /// </summary>
        [XmlArray("buyer_notes")]
        [XmlArrayItem("koubei_item_description")]
        public List<KoubeiItemDescription> BuyerNotes { get; set; }

        /// <summary>
        /// 表示是否支持预定，支持“T”, 不支持“F”
        /// </summary>
        [XmlElement("support_book")]
        public string SupportBook { get; set; }

        /// <summary>
        /// 购买有效期：商品自购买起多长时间内有效，取值范围 7-360，单位天。举例，如果是7的话，是到第七天晚上23:59:59失效。商品购买后，没有在有效期内核销，则自动退款给用户。举例：买了一个高级造型师洗剪吹的商品，有效期一个月，如果一个月之后，用户没有使用商品来进行洗剪吹的服务，则自动退款给用户。
        /// </summary>
        [XmlElement("validity_period")]
        public string ValidityPeriod { get; set; }

        /// <summary>
        /// 核销绝对有效期开始时间。自该时间点起，商品可被核销。  注意：商品售卖时段开始时间（gmt_start）不能晚于该时间。
        /// </summary>
        [XmlElement("validity_period_range_from")]
        public string ValidityPeriodRangeFrom { get; set; }

        /// <summary>
        /// 核销绝对有效期结束时间。自改时间点起，商品无法继续被核销，且自动过期退款。  注意：售卖时段结束时间(gmt_end)不能晚于该时间。
        /// </summary>
        [XmlElement("validity_period_range_to")]
        public string ValidityPeriodRangeTo { get; set; }

        /// <summary>
        /// 核销有效期类型。支持相对有效期及绝对有效期两种方式，对应RELATIVE或FIXED。相对有效期指自购买之日起XX天有效，绝对有效期指某一端固定时间内有效。  注意：绝对有效期不允许超过360天，否则无法成功创建。
        /// </summary>
        [XmlElement("validity_period_type")]
        public string ValidityPeriodType { get; set; }

        /// <summary>
        /// 份数，单次核销只可赋值为1，表示多次核销商品最多支持核销的份数，需为整数且在[2,50]范围内。备注：多次核销商品的价格为包含所有份数的整体价格，如洗剪吹3次卡300元，则每次核销消耗100元。
        /// </summary>
        [XmlElement("verify_enable_times")]
        public long VerifyEnableTimes { get; set; }

        /// <summary>
        /// 核销类型，single为单次核销商品（即普通商品），multi为多次核销商品（即次卡商品）
        /// </summary>
        [XmlElement("verify_frequency")]
        public string VerifyFrequency { get; set; }
    }
}
