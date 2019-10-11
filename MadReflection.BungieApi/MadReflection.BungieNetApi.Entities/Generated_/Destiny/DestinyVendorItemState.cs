﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace BungieNet.Destiny
{
	/// <summary>
	/// The possible states of Destiny Profile Records. IMPORTANT: Any given item can theoretically have many of these states simultaneously: as a result, this was altered to be a flags enumeration/bitmask for v3.2.0.
	/// </summary>
	[Flags]
	public enum DestinyVendorItemState
	{
		/// <summary>
		/// There are no augments on the item.
		/// </summary>
		None = 0x0,

		[Obsolete("Deprecated forever (probably). There was a time when Records were going to be implemented through Vendors, and this field was relevant. Now they're implemented through Presentation Nodes, and this field doesn't matter anymore.", true)]
		Incomplete = 0x1,

		[Obsolete("Deprecated forever (probably). See the description of the \"Incomplete\" value for the juicy scoop.", true)]
		RewardAvailable = 0x2,

		[Obsolete("Deprecated forever (probably). See the description of the \"Incomplete\" value for the juicy scoop.", true)]
		Complete = 0x4,

		/// <summary>
		/// This item is considered to be "newly available", and should have some UI showing how shiny it is.
		/// </summary>
		New = 0x8,

		/// <summary>
		/// This item is being "featured", and should be shiny in a different way from items that are merely new.
		/// </summary>
		Featured = 0x10,

		/// <summary>
		/// This item is only available for a limited time, and that time is approaching.
		/// </summary>
		Ending = 0x20,

		/// <summary>
		/// This item is "on sale". Get it while it's hot.
		/// </summary>
		OnSale = 0x40,

		/// <summary>
		/// This item is already owned.
		/// </summary>
		Owned = 0x80,

		/// <summary>
		/// This item should be shown with a "wide view" instead of normal icon view.
		/// </summary>
		WideView = 0x100,

		/// <summary>
		/// This indicates that you should show some kind of attention-requesting indicator on the item, in a similar manner to items in the nexus that have such notifications.
		/// </summary>
		NexusAttention = 0x200
	}
}
