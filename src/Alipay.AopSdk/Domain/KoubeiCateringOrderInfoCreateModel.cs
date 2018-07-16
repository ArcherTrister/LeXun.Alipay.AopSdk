using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoCreateModel : AopObject
    {
        /// <summary>
        /// 商户业务类型：DINNER-正餐、SNACK-快餐
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 订单渠道：ISV，ElEME
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 就餐类型：FOR_HERE—堂食、TAKE_OUT-外卖、TO_GO-外带
        /// </summary>
        [XmlElement("dinner_type")]
        public string DinnerType { get; set; }

        /// <summary>
        /// 订单菜明细列表
        /// </summary>
        [XmlArray("dish_details")]
        [XmlArrayItem("kb_pos_order_dish_detail")]
        public List<KbPosOrderDishDetail> DishDetails { get; set; }

        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 开台操作员ID
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 点餐方式：POS-pos点餐、SCAN-扫码点菜、PLATFORM-平台(外卖类的)
        /// </summary>
        [XmlElement("order_style")]
        public string OrderStyle { get; set; }

        /// <summary>
        /// 下单时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// 原反结订单的设备号
        /// </summary>
        [XmlElement("org_dv_sn")]
        public string OrgDvSn { get; set; }

        /// <summary>
        /// 原反结订单的pos本地订单号
        /// </summary>
        [XmlElement("org_out_biz_no")]
        public string OrgOutBizNo { get; set; }

        /// <summary>
        /// 其他杂费，以元为单位，精确到分
        /// </summary>
        [XmlElement("other_amount")]
        public string OtherAmount { get; set; }

        /// <summary>
        /// 打包费，以元为单位，精确到分
        /// </summary>
        [XmlElement("packing_amount")]
        public string PackingAmount { get; set; }

        /// <summary>
        /// 用餐人数
        /// </summary>
        [XmlElement("people_num")]
        public long PeopleNum { get; set; }

        /// <summary>
        /// pos业务订单外部主键信息
        /// </summary>
        [XmlElement("pos_order_key")]
        public PosOrderKey PosOrderKey { get; set; }

        /// <summary>
        /// 服务费，以元为单位，精确到分
        /// </summary>
        [XmlElement("service_amount")]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 口碑体系内的门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 开台时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("table_time")]
        public string TableTime { get; set; }

        /// <summary>
        /// 取餐号码，示例：  桌号：04，令牌：13，取餐号：5100，配送：2018012912312312321（比如饿了么订单号）
        /// </summary>
        [XmlElement("take_no")]
        public string TakeNo { get; set; }

        /// <summary>
        /// 取餐类型：TABLE-桌号，TOKEN-令牌，NO-取餐号，DISPATCH-配送（仅针对外卖）
        /// </summary>
        [XmlElement("take_style")]
        public string TakeStyle { get; set; }
    }
}
