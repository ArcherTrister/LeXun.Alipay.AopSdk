using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayEcoMycarParkingParkinglotinfoUpdateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoMycarParkingParkinglotinfoUpdateModel : AopObject
    {
        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("city_id")]
        public string CityId { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_alipay")]
        public string ContactAlipay { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_mobile")]
        public string ContactMobile { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_tel")]
        public string ContactTel { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("contact_weixin")]
        public string ContactWeixin { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("equipment_name")]
        public string EquipmentName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("out_parking_id")]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        [XmlElement("parking_address")]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_end_time")]
        public string ParkingEndTime { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        [XmlElement("parking_fee_description")]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 支付宝返回停车场id，系统唯一
        /// </summary>
        [XmlElement("parking_id")]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场类型，1为小区停车场、2为商圈停车场、3为路面停车场、4为园区停车场、5为写字楼停车场、6为私人停车场
        /// </summary>
        [XmlElement("parking_lot_type")]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场客服电话
        /// </summary>
        [XmlElement("parking_mobile")]
        public string ParkingMobile { get; set; }

        /// <summary>
        /// 停车场名称，由ISV定义，尽量与高德地图上的一致
        /// </summary>
        [XmlElement("parking_name")]
        public string ParkingName { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_number")]
        public string ParkingNumber { get; set; }

        /// <summary>
        /// 高德地图唯一标识
        /// </summary>
        [XmlElement("parking_poiid")]
        public string ParkingPoiid { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_start_time")]
        public string ParkingStartTime { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("parking_type")]
        public string ParkingType { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以','进行间隔
        /// </summary>
        [XmlElement("pay_type")]
        public string PayType { get; set; }

        /// <summary>
        /// 该参数废弃
        /// </summary>
        [XmlElement("payment_mode")]
        public string PaymentMode { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [XmlElement("shopingmall_id")]
        public string ShopingmallId { get; set; }

        /// <summary>
        /// 用户支付未离场的超时时间(以分钟为单位)
        /// </summary>
        [XmlElement("time_out")]
        public string TimeOut { get; set; }
    }
}
