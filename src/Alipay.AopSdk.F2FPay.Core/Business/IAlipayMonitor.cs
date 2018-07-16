﻿using Alipay.AopSdk.F2FPay.Core.Domain;

namespace Alipay.AopSdk.F2FPay.Core.Business
{
    /// <summary>
    /// IAlipayMonitor 的摘要说明
    /// </summary>
    public interface IAlipayMonitor
    {

        //云监控接口
        AlipayF2FMonitorResult mcloudMonitor(AlipayMonitorContentBuilder builder);
    }

}