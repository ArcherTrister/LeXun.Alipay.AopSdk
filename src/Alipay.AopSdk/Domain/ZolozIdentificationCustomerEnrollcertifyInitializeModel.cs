using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerEnrollcertifyInitializeModel : AopObject
    {
        /// <summary>
        /// 商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务场景名字
        /// </summary>
        [XmlElement("biz_scene_name")]
        public string BizSceneName { get; set; }

        /// <summary>
        /// 实人信息：证件名字
        /// </summary>
        [XmlElement("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 实人信息：证件号
        /// </summary>
        [XmlElement("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 实人信息：证件类型
        /// </summary>
        [XmlElement("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 0：匿名注册  1：匿名认证   2：实名认证
        /// </summary>
        [XmlElement("face_type")]
        public long FaceType { get; set; }

        /// <summary>
        /// 人脸引导页是否显示
        /// </summary>
        [XmlElement("has_welcome_page")]
        public bool HasWelcomePage { get; set; }

        /// <summary>
        /// metainfo环境参数
        /// </summary>
        [XmlElement("metainfo")]
        public string Metainfo { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [XmlElement("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 商户的用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
