using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipaySecurityProdFacerepoSearchResponse.
	/// </summary>
	public class AlipaySecurityProdFacerepoSearchResponse : AopResponse
	{
		/// <summary>
		///     扩展参数
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     从入参指定的人脸库分组中搜索出来的相似度最高的人脸id
		/// </summary>
		[JsonProperty("face_id")]
		public string FaceId { get; set; }
	}
}