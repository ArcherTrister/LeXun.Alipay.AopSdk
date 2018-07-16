using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiCateringOrderInfoSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringOrderInfoSyncModel : AopObject
    {
        /// <summary>
        /// 订单操作类型，RECEIPT—接单、REJECT—拒单、PREPARE—已备餐、DELIVER—已送餐、REFUND—退款、RENEW—反结、ACCEPT_REFUND 接受退款，REJECT_REFUND 拒接退款
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 操作内容信息，Map<String,String> actionInfo = new HashMap<String,String>();  actionInfo.put("NO","5100");// 取餐号  JSONObject.toJSONString(actionInfo);
        /// </summary>
        [XmlElement("action_info")]
        public string ActionInfo { get; set; }

        /// <summary>
        /// 口碑端自己的订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }
    }
}
