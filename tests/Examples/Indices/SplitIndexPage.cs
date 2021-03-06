using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.Indices
{
	public class SplitIndexPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line10()
		{
			// tag::1a19b7db5485cd814e1f76f7cd7d2923[]
			var response0 = new SearchResponse<object>();
			// end::1a19b7db5485cd814e1f76f7cd7d2923[]

			response0.MatchesExample(@"POST /twitter/_split/split-twitter-index
			{
			  ""settings"": {
			    ""index.number_of_shards"": 2
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line42()
		{
			// tag::01c0e302f4fd5118faf5e34f4a010ebf[]
			var response0 = new SearchResponse<object>();
			// end::01c0e302f4fd5118faf5e34f4a010ebf[]

			response0.MatchesExample(@"PUT /my_source_index/_settings
			{
			  ""settings"": {
			    ""index.blocks.write"": true \<1>
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line147()
		{
			// tag::2e796e5ca59768d4426abbf9a049db3e[]
			var response0 = new SearchResponse<object>();
			// end::2e796e5ca59768d4426abbf9a049db3e[]

			response0.MatchesExample(@"POST /my_source_index/_split/my_target_index
			{
			  ""settings"": {
			    ""index.number_of_shards"": 2
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line181()
		{
			// tag::f2f1cae094855a45fd8f73478bec8e70[]
			var response0 = new SearchResponse<object>();
			// end::f2f1cae094855a45fd8f73478bec8e70[]

			response0.MatchesExample(@"POST /my_source_index/_split/my_target_index
			{
			  ""settings"": {
			    ""index.number_of_shards"": 5 <1>
			  },
			  ""aliases"": {
			    ""my_search_indices"": {}
			  }
			}");
		}
	}
}