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

namespace BungieNet.Destiny.Responses
{
	public partial class DestinyProfileUserInfoCard
	{
		[JsonProperty("dateLastPlayed")]
		public DateTime DateLastPlayed { get; set; }

		[JsonProperty("applicableMembershipTypes")]
		public BungieMembershipType[] ApplicableMembershipTypes { get; set; }

		[JsonProperty("isOverridden")]
		public bool IsOverridden { get; set; }

		[JsonProperty("isCrossSavePrimary")]
		public bool IsCrossSavePrimary { get; set; }

		[JsonProperty("supplementalDisplayName")]
		public string SupplementalDisplayName { get; set; }

		[JsonProperty("iconPath")]
		public string IconPath { get; set; }

		[JsonProperty("membershipType")]
		public BungieMembershipType MembershipType { get; set; }

		[JsonProperty("membershipId")]
		public long MembershipId { get; set; }

		[JsonProperty("displayName")]
		public string DisplayName { get; set; }
	}
}
