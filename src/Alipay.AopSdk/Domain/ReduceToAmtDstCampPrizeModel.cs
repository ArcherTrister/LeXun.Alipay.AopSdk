using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// ReduceToAmtDstCampPrizeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ReduceToAmtDstCampPrizeModel : AopObject
    {
        /// <summary>
        /// 优惠后价格
        /// </summary>
        [XmlElement("reduct_to_amt")]
        public string ReductToAmt { get; set; }
    }
}
