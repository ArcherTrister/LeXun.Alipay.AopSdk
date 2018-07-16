using Alipay.AopSdk.F2FPay.Domain;
using Alipay.AopSdk.Request;

namespace Alipay.AopSdk.F2FPay.Business
{
    /// <summary>
    /// AlipayTradePayImpl 的摘要说明
    /// </summary>
    public class AlipayMonitorImpl : IAlipayMonitor
    {
        private IAopClient client = null;

        public AlipayMonitorImpl(string monitorUrl, string appId, string merchant_private_key, string format, string version,
     string sign_type, string alipay_public_key, string charset)
        {
            client = new DefaultAopClient(monitorUrl, appId, merchant_private_key, format, version,
           sign_type, alipay_public_key, charset);
        }

        #region 接口方法

        public AlipayF2FMonitorResult mcloudMonitor(AlipayMonitorContentBuilder build)
        {
            AlipayF2FMonitorResult result = new AlipayF2FMonitorResult();
            try
            {
                MonitorHeartbeatSynRequest monitorRequest = new MonitorHeartbeatSynRequest
                {
                    BizContent = build.BuildJson()
                };
                result.response = client.Execute(monitorRequest);
                return result;
            }
            catch
            {
                result.response = null;
                return result;
            }
        }

        #endregion 接口方法
    }
}