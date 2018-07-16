using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KbPosOrderDishDetail Data Structure.
    /// </summary>
    [Serializable]
    public class KbPosOrderDishDetail : AopObject
    {
        /// <summary>
        /// 改价（单价），以元为单位，精度到分
        /// </summary>
        [XmlElement("change_price")]
        public string ChangePrice { get; set; }

        /// <summary>
        /// 改价原因
        /// </summary>
        [XmlElement("change_reason")]
        public string ChangeReason { get; set; }

        /// <summary>
        /// 菜谱ID
        /// </summary>
        [XmlElement("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜谱版本号，用时间戳实现（示例：date.getTime()）
        /// </summary>
        [XmlElement("cook_version")]
        public string CookVersion { get; set; }

        /// <summary>
        /// 是否可以享受优惠
        /// </summary>
        [XmlElement("discountable")]
        public bool Discountable { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [XmlElement("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [XmlElement("dish_name")]
        public string DishName { get; set; }

        /// <summary>
        /// 菜品数量，≥1
        /// </summary>
        [XmlElement("dish_num")]
        public long DishNum { get; set; }

        /// <summary>
        /// 菜品单位
        /// </summary>
        [XmlElement("dish_unit")]
        public string DishUnit { get; set; }

        /// <summary>
        /// 菜品明细版本号
        /// </summary>
        [XmlElement("dish_version")]
        public long DishVersion { get; set; }

        /// <summary>
        /// 扩展信息，json对象格式，key和value都为字符串
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 是否改价
        /// </summary>
        [XmlElement("has_change")]
        public bool HasChange { get; set; }

        /// <summary>
        /// 是否是主明细，默认都是主明细。除了点套餐的时候，套餐本身这个菜作为主明细设置，套餐下的菜明细作为非主明细设置。
        /// </summary>
        [XmlElement("main_flag")]
        public bool MainFlag { get; set; }

        /// <summary>
        /// 主明细id，套餐下的菜品对应的主明细id
        /// </summary>
        [XmlElement("main_out_detail_no")]
        public string MainOutDetailNo { get; set; }

        /// <summary>
        /// 制作状态，取值约定：INIT-未制作，MAKE-已制作，SERVE-已上菜，REFUND-已退菜
        /// </summary>
        [XmlElement("make_status")]
        public string MakeStatus { get; set; }

        /// <summary>
        /// 会员价（单价），以元为单位，精度到分
        /// </summary>
        [XmlElement("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 下单操作员ID
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 下单时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("order_time")]
        public string OrderTime { get; set; }

        /// <summary>
        /// pos本地订单菜明细流水号
        /// </summary>
        [XmlElement("out_detail_no")]
        public string OutDetailNo { get; set; }

        /// <summary>
        /// 做法信息，格式按照：做法=做法加价（单价）。价格以元为单位，精度到分
        /// </summary>
        [XmlElement("practice_info")]
        public string PracticeInfo { get; set; }

        /// <summary>
        /// 做法合计加价（单价），以元为单位，精度到分
        /// </summary>
        [XmlElement("practice_price")]
        public string PracticePrice { get; set; }

        /// <summary>
        /// 退菜原因
        /// </summary>
        [XmlElement("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退菜时间，格式yyyy-mm-dd hh:mm:ss
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 催菜次数
        /// </summary>
        [XmlElement("remind_time")]
        public long RemindTime { get; set; }

        /// <summary>
        /// 售价（单价），以元为单位，精度到分
        /// </summary>
        [XmlElement("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 菜品skuId
        /// </summary>
        [XmlElement("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// 菜品点菜序号
        /// </summary>
        [XmlElement("sort")]
        public long Sort { get; set; }

        /// <summary>
        /// 规格中文名，没有规格时不需要填写
        /// </summary>
        [XmlElement("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 用户身份标识：手机号码、userId等等。如果是支付宝扫码点菜的，就是用户userId
        /// </summary>
        [XmlElement("user_identity")]
        public string UserIdentity { get; set; }

        /// <summary>
        /// 叫起状态，取值约定：WAIT-等待叫起，UP-已叫起
        /// </summary>
        [XmlElement("wake_status")]
        public string WakeStatus { get; set; }
    }
}
