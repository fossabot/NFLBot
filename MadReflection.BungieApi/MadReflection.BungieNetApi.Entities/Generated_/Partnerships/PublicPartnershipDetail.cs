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

namespace BungieNet.Partnerships
{
	/// <summary>
	/// All the partnership info that's fit to expose externally, if we care to do so.
	/// </summary>
	public partial class PublicPartnershipDetail
	{
		[JsonProperty("partnerType")]
		public Partnerships.PartnershipType PartnerType { get; set; }

		[JsonProperty("identifier")]
		public string Identifier { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("icon")]
		public string Icon { get; set; }
	}
}
