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

namespace BungieNet.Applications
{
	public partial class ApiUsage
	{
		[JsonProperty("range")]
		public Dates.DateRange Range { get; set; }

		[JsonProperty("apiCalls")]
		public Applications.Series[] ApiCalls { get; set; }

		[JsonProperty("throttledRequests")]
		public Applications.Series[] ThrottledRequests { get; set; }
	}
}
