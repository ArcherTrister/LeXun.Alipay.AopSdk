using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KoubeiCateringPosOrderUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosOrderUploadModel : AopObject
    {
        /// <summary>
        /// 设备商回流的设备信息列表
        /// </summary>
        [XmlArray("pos_device_infos")]
        [XmlArrayItem("pos_device_info_v_o")]
        public List<PosDeviceInfoVO> PosDeviceInfos { get; set; }

        /// <summary>
        /// 回流pos订单信息列表
        /// </summary>
        [XmlArray("pos_order_infos")]
        [XmlArrayItem("pos_order_info_v_o")]
        public List<PosOrderInfoVO> PosOrderInfos { get; set; }

        /// <summary>
        /// source_type+pos订单设备信息来源类型枚举+(isv回流数据: ISV, 设备商数据: MEMA)
        /// </summary>
        [XmlElement("source_type")]
        public string SourceType { get; set; }
    }
}
