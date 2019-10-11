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

namespace BungieNet.Destiny.Definitions.Milestones
{
	/// <summary>
	/// If rewards are given in a quest - as opposed to overall in the entire Milestone - there's way less to track. We're going to simplify this contract as a result. However, this also gives us the opportunity to potentially put more than just item information into the reward data if we're able to mine it out in the future. Remember this if you come back and ask "why are quest reward items nested inside of their own class?"
	/// </summary>
	public partial class DestinyMilestoneQuestRewardsDefinition
	{
		[JsonProperty("items")]
		public Destiny.Definitions.Milestones.DestinyMilestoneQuestRewardItem[] Items { get; set; }
	}
}