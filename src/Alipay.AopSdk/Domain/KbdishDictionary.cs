using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// KbdishDictionary Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishDictionary : AopObject
    {
        /// <summary>
        /// 商家门店的操作小二,创建数据的人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 字典的数据id
        /// </summary>
        [XmlElement("dictionary_id")]
        public string DictionaryId { get; set; }

        /// <summary>
        /// 字典的扩展json，根据不同的biz_type,设置商家的自定义字典表key以及value。如果字典类型为catetory, key：cateSort，cateType，level,parentCatetoryId ;如果字典类型为spec, key：specSort.
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得,这个是给isv点单用的必须要要明确的id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 字典名称. 商家自定义的字符串
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商户门店的操作小二,修改数据的人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
