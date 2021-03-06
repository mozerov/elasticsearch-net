﻿using System.Collections.Generic;
using Elasticsearch.Net;
using System.Runtime.Serialization;

namespace Nest
{
	public class GraphExploreResponse : ResponseBase
	{
		[DataMember(Name ="connections")]
		public IReadOnlyCollection<GraphConnection> Connections { get; internal set; } = EmptyReadOnly<GraphConnection>.Collection;

		[DataMember(Name ="failures")]
		public IReadOnlyCollection<ShardFailure> Failures { get; internal set; } = EmptyReadOnly<ShardFailure>.Collection;

		[DataMember(Name ="timed_out")]
		public bool TimedOut { get; internal set; }

		[DataMember(Name ="took")]
		public long Took { get; internal set; }

		[DataMember(Name ="vertices")]
		public IReadOnlyCollection<GraphVertex> Vertices { get; internal set; } = EmptyReadOnly<GraphVertex>.Collection;
	}
}
