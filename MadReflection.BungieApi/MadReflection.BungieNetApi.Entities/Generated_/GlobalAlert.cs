﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Newtonsoft.Json;

namespace BungieNet
{
	public partial class GlobalAlert
	{
		[JsonProperty("AlertKey")]
		public string AlertKey { get; set; }

		[JsonProperty("AlertHtml")]
		public string AlertHtml { get; set; }

		[JsonProperty("AlertTimestamp")]
		public DateTime AlertTimestamp { get; set; }

		[JsonProperty("AlertLink")]
		public string AlertLink { get; set; }

		[JsonProperty("AlertLevel")]
		public GlobalAlertLevel AlertLevel { get; set; }

		[JsonProperty("AlertType")]
		public GlobalAlertType AlertType { get; set; }

		[JsonProperty("StreamInfo")]
		public StreamInfo StreamInfo { get; set; }
	}
}
