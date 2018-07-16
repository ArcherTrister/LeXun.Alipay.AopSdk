using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplatemessageUsertemplateApplyResponse.
    /// </summary>
    public class AlipayOpenMiniTemplatemessageUsertemplateApplyResponse : AopResponse
    {
        /// <summary>
        /// 开发者申请的模板id号，使用该模板id号，开发者可以调用alipay.open.app.mini.templatemessage.send接口进行模板消息发送
        /// </summary>
        [XmlElement("user_template_id")]
        public string UserTemplateId { get; set; }
    }
}
