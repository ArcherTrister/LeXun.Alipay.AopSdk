using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayEcoMycarViolationVehicleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarViolationVehicleQueryModel : AopObject
    {
        /// <summary>
        /// 用户车辆ID,支付宝系统唯一
        /// </summary>
        [XmlElement("vi_id")]
        public string ViId { get; set; }
    }
}
