using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// PosDeviceInfoVO Data Structure.
    /// </summary>
    [Serializable]
    public class PosDeviceInfoVO : AopObject
    {
        /// <summary>
        /// 设备对应的软件方公司名称，比如：美味不用等；银盒子；二维火；云纵；雅座；辰森；
        /// </summary>
        [XmlElement("decive_software_name")]
        public string DeciveSoftwareName { get; set; }

        /// <summary>
        /// 设备安装的应用数
        /// </summary>
        [XmlElement("device_app_cnt")]
        public string DeviceAppCnt { get; set; }

        /// <summary>
        /// 设备安装的应用列表对应的流量,单位KB
        /// </summary>
        [XmlElement("device_app_flow")]
        public string DeviceAppFlow { get; set; }

        /// <summary>
        /// 设备安装的应用列表
        /// </summary>
        [XmlElement("device_app_list")]
        public string DeviceAppList { get; set; }

        /// <summary>
        /// 设备出厂公司；比如：商米；新大陆；荣焱；
        /// </summary>
        [XmlElement("device_company_name")]
        public string DeviceCompanyName { get; set; }

        /// <summary>
        /// 设备总使用流量,单位KB
        /// </summary>
        [XmlElement("device_flow")]
        public string DeviceFlow { get; set; }

        /// <summary>
        /// pos机设备ip值
        /// </summary>
        [XmlElement("device_ip")]
        public string DeviceIp { get; set; }

        /// <summary>
        /// pos机设备MAC地址
        /// </summary>
        [XmlElement("device_mac")]
        public string DeviceMac { get; set; }

        /// <summary>
        /// 设备运行的操作系统版本
        /// </summary>
        [XmlElement("device_os_version")]
        public string DeviceOsVersion { get; set; }

        /// <summary>
        /// pos机设备状态值，枚举值为：已出厂(1)，已入仓(2)，已出售(3)，已报单(4)，已发货(5)，已收货(6)，已激活(7)、已绑定(8)、运行中(9)、设备失联(10)、已解绑(11)
        /// </summary>
        [XmlElement("device_status")]
        public string DeviceStatus { get; set; }

        /// <summary>
        /// pos机设备类型，枚举值为: 旗舰(FLAG_SHIP),高端(HIGH_END),标准(STANDARD),手持(IN_HAND)
        /// </summary>
        [XmlElement("device_type")]
        public string DeviceType { get; set; }

        /// <summary>
        /// 设备型号，如荣焱P10CC、商米D1、荣焱P10S、商米P1、荣焱HD01、商米V1、商米M1、荣焱P8K、商米T1、商米T2lite、荣焱P8G、商米T1、商米T2Lite等
        /// </summary>
        [XmlElement("device_version")]
        public string DeviceVersion { get; set; }

        /// <summary>
        /// 设备激活时间
        /// </summary>
        [XmlElement("gmt_activate")]
        public string GmtActivate { get; set; }

        /// <summary>
        /// 最后登录时间:设备处于登陆状态的最后时间
        /// </summary>
        [XmlElement("gmt_login")]
        public string GmtLogin { get; set; }

        /// <summary>
        /// 设备解绑时间
        /// </summary>
        [XmlElement("gmt_production")]
        public string GmtProduction { get; set; }

        /// <summary>
        /// 最后发送信息时间:设备最后发送信息的时间，发给服务端的最后时间
        /// </summary>
        [XmlElement("gmt_send")]
        public string GmtSend { get; set; }

        /// <summary>
        /// 设备出厂时间
        /// </summary>
        [XmlElement("gmt_unbundling")]
        public string GmtUnbundling { get; set; }

        /// <summary>
        /// 最后更新时间:设备上软件的最后更新时间
        /// </summary>
        [XmlElement("gmt_update")]
        public string GmtUpdate { get; set; }

        /// <summary>
        /// 数据回流设备对应的ISV名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// 数据回流设备对应的ISV_PID
        /// </summary>
        [XmlElement("isv_pid")]
        public string IsvPid { get; set; }

        /// <summary>
        /// 口碑门店id，激活设备才有口碑门店id
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 设备id，唯一标识设备的ID,SN号
        /// </summary>
        [XmlElement("sn_no")]
        public string SnNo { get; set; }
    }
}
