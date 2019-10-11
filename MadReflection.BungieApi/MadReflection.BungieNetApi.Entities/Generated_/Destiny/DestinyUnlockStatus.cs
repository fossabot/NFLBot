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

namespace BungieNet.Destiny
{
	/// <summary>
	/// Indicates the status of an "Unlock Flag" on a Character or Profile.
	/// These are individual bits of state that can be either set or not set, and sometimes provide interesting human-readable information in their related DestinyUnlockDefinition.
	/// </summary>
	public partial class DestinyUnlockStatus
	{
		[JsonProperty("unlockHash")]
		public uint UnlockHash { get; set; }

		[JsonProperty("isSet")]
		public bool IsSet { get; set; }
	}
}
