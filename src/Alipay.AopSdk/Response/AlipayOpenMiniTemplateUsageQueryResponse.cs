using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayOpenMiniTemplateUsageQueryResponse.
    /// </summary>
    public class AlipayOpenMiniTemplateUsageQueryResponse : AopResponse
    {
        /// <summary>
        /// 小程序appId列表
        /// </summary>
        [XmlArray("app_ids")]
        [XmlArrayItem("string")]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 模板使用信息
        /// </summary>
        [XmlArray("template_usage_info_list")]
        [XmlArrayItem("template_usage_info")]
        public List<TemplateUsageInfo> TemplateUsageInfoList { get; set; }
    }
}
