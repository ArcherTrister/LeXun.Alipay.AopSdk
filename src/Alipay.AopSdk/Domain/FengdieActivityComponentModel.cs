using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// FengdieActivityComponentModel Data Structure.
    /// </summary>
    [Serializable]
    public class FengdieActivityComponentModel : AopObject
    {
        /// <summary>
        /// 指定组件数据，默认为 schema 默认数据
        /// </summary>
        [XmlArray("component_data")]
        [XmlArrayItem("fengdie_activity_schema_model")]
        public List<FengdieActivitySchemaModel> ComponentData { get; set; }

        /// <summary>
        /// 组件名称，即组件目录下 package.json 文件的 fengdie.name 字段（极少个别模板包fengdie.name和组件文件夹名称不一致，请联系模板开发者修改为一致）
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
