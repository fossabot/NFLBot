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

namespace BungieNet.Destiny.Definitions.Director
{
	/// <summary>
	/// The actual activity to be redirected to when you click on the node. Note that a node can have many Activities attached to it: but only one will be active at any given time. The list of Node Activities will be traversed, and the first one found to be active will be displayed. This way, a node can layer multiple variants of an activity on top of each other. For instance, one node can control the weekly Crucible Playlist. There are multiple possible playlists, but only one is active for the week.
	/// </summary>
	public partial class DestinyActivityGraphNodeActivityDefinition
	{
		[JsonProperty("nodeActivityId")]
		public uint NodeActivityId { get; set; }

		[JsonProperty("activityHash")]
		public uint ActivityHash { get; set; }
	}
}
