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

namespace BungieNet.Forum
{
	public partial class PollResult
	{
		[JsonProperty("answerText")]
		public string AnswerText { get; set; }

		[JsonProperty("answerSlot")]
		public int AnswerSlot { get; set; }

		[JsonProperty("lastVoteDate")]
		public DateTime LastVoteDate { get; set; }

		[JsonProperty("votes")]
		public int Votes { get; set; }

		[JsonProperty("requestingUserVoted")]
		public bool RequestingUserVoted { get; set; }
	}
}
