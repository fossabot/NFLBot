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

namespace BungieNet.Destiny.Definitions.Items
{
	/// <summary>
	/// This is a reference to, and summary data for, a specific item that you can get as a result of Using or Acquiring some other Item (For example, this could be summary information for an Emote that you can get by opening an an Eververse Box) See DestinyDerivedItemCategoryDefinition for more information.
	/// </summary>
	public partial class DestinyDerivedItemDefinition
	{
		[JsonProperty("itemHash")]
		public uint? ItemHash { get; set; }

		[JsonProperty("itemName")]
		public string ItemName { get; set; }

		[JsonProperty("itemDetail")]
		public string ItemDetail { get; set; }

		[JsonProperty("itemDescription")]
		public string ItemDescription { get; set; }

		[JsonProperty("iconPath")]
		public string IconPath { get; set; }

		[JsonProperty("vendorItemIndex")]
		public int VendorItemIndex { get; set; }
	}
}