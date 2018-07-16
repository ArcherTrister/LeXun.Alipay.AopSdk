using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// KoubeiCateringCrowdgroupConditionQueryResponse.
    /// </summary>
    public class KoubeiCateringCrowdgroupConditionQueryResponse : AopResponse
    {
        /// <summary>
        /// isv创建的用户规则分组描述
        /// </summary>
        [XmlArray("condition_list")]
        [XmlArrayItem("user_crowd_conditions")]
        public List<UserCrowdConditions> ConditionList { get; set; }
    }
}
