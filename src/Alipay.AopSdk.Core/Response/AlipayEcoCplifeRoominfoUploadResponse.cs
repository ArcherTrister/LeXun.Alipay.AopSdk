using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoCplifeRoominfoUploadResponse.
	/// </summary>
	public class AlipayEcoCplifeRoominfoUploadResponse : AopResponse
	{
		/// <summary>
		///     业主所在物业小区ID(支付宝平台唯一小区ID标示)
		/// </summary>
		[JsonProperty("community_id")]
		public string CommunityId { get; set; }

		/// <summary>
		///     已经成功上传的房屋信息列表.
		/// </summary>
		[JsonProperty("room_info_set")]
		
		public List<CplifeRoomInfoResp> RoomInfoSet { get; set; }
	}
}