using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherStockCreateModel : AopObject
    {
        /// <summary>
        /// 券码列表，商户体系内可兑换使用的券码
        /// </summary>
        [XmlArray("entity_list")]
        [XmlArrayItem("string")]
        public List<string> EntityList { get; set; }

        /// <summary>
        /// 外部单据号, 请保持唯一, 如果重复则认为重复请求, 可以使用uuid生成或使用商户自己的单据号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 库存ID, 首次创建请填写空, 追加库存请填原始库存ID
        /// </summary>
        [XmlElement("stock_id")]
        public string StockId { get; set; }
    }
}
