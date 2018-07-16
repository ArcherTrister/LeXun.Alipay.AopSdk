using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiRetailWmsGoodsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsGoodsQueryModel : AopObject
    {
        /// <summary>
        /// 根据状态查询货品  EFFECTIVE：生效  INVALID ：无效
        /// </summary>
        [XmlElement("biz_status")]
        public string BizStatus { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 根据货品前缀名称查询
        /// </summary>
        [XmlElement("goods_name")]
        public string GoodsName { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [XmlElement("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 页码，分页参数，当以 goods_code为查询条件时不用传，默认1
        /// </summary>
        [XmlElement("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 页面大小，分页参数，当以goods_code为查询条件时不用传，默认20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 生产厂商ID
        /// </summary>
        [XmlElement("producer_id")]
        public string ProducerId { get; set; }

        /// <summary>
        /// 供应商ID
        /// </summary>
        [XmlElement("supplier_id")]
        public string SupplierId { get; set; }
    }
}
