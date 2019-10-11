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

namespace BungieNet.Destiny.Perks
{
	/// <summary>
	/// The list of perks to display in an item tooltip - and whether or not they have been activated.
	/// Perks apply a variety of effects to a character, and are generally either intrinsic to the item or provided in activated talent nodes or sockets.
	/// </summary>
	public partial class DestinyPerkReference
	{
		[JsonProperty("perkHash")]
		public uint PerkHash { get; set; }

		[JsonProperty("iconPath")]
		public string IconPath { get; set; }

		[JsonProperty("isActive")]
		public bool IsActive { get; set; }

		[JsonProperty("visible")]
		public bool Visible { get; set; }
	}
}
