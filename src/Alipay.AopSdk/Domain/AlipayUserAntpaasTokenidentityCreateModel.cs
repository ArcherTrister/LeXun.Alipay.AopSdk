using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayUserAntpaasTokenidentityCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasTokenidentityCreateModel : AopObject
    {
        /// <summary>
        /// 业务Id，如新零售场景下创建匿名淘宝账户时的品牌商Id。  如果该值为空，则底层创建匿名账户时以 biz_scene + mobile 进行幂等  如果该值非空，则底层创建匿名账户Id时以 biz_scene + mobile + biz_id 进行幂等。
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务域场景
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 附加信息Id，如淘宝虚拟账号Id
        /// </summary>
        [XmlElement("ext_info_id")]
        public string ExtInfoId { get; set; }

        /// <summary>
        /// 手机号码，1864234324324
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 1-企业 2-个人
        /// </summary>
        [XmlElement("user_type")]
        public string UserType { get; set; }
    }
}
