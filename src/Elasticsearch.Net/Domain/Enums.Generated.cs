
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

///This file contains all the typed enums that the client rest api spec exposes.
///This file is automatically generated from https://github.com/elastic/elasticsearch/tree/5.x/rest-api-spec
///Generated of commit 5.x
namespace Elasticsearch.Net
{
	
	public enum Refresh 
	{
		[EnumMember(Value = "true")]
		True,
		[EnumMember(Value = "false")]
		False,
		[EnumMember(Value = "wait_for")]
		WaitFor
	}
	
	
	public enum Bytes 
	{
		[EnumMember(Value = "b")]
		B,
		[EnumMember(Value = "k")]
		K,
		[EnumMember(Value = "kb")]
		Kb,
		[EnumMember(Value = "m")]
		M,
		[EnumMember(Value = "mb")]
		Mb,
		[EnumMember(Value = "g")]
		G,
		[EnumMember(Value = "gb")]
		Gb,
		[EnumMember(Value = "t")]
		T,
		[EnumMember(Value = "tb")]
		Tb,
		[EnumMember(Value = "p")]
		P,
		[EnumMember(Value = "pb")]
		Pb
	}
	
	
	public enum Health 
	{
		[EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red
	}
	
	
	public enum Size 
	{
		[EnumMember(Value = "")]
		Raw,
		[EnumMember(Value = "k")]
		K,
		[EnumMember(Value = "m")]
		M,
		[EnumMember(Value = "g")]
		G,
		[EnumMember(Value = "t")]
		T,
		[EnumMember(Value = "p")]
		P
	}
	
	
	public enum Level 
	{
		[EnumMember(Value = "cluster")]
		Cluster,
		[EnumMember(Value = "indices")]
		Indices,
		[EnumMember(Value = "shards")]
		Shards
	}
	
	
	public enum WaitForEvents 
	{
		[EnumMember(Value = "immediate")]
		Immediate,
		[EnumMember(Value = "urgent")]
		Urgent,
		[EnumMember(Value = "high")]
		High,
		[EnumMember(Value = "normal")]
		Normal,
		[EnumMember(Value = "low")]
		Low,
		[EnumMember(Value = "languid")]
		Languid
	}
	
	
	public enum WaitForStatus 
	{
		[EnumMember(Value = "green")]
		Green,
		[EnumMember(Value = "yellow")]
		Yellow,
		[EnumMember(Value = "red")]
		Red
	}
	
	
	public enum ExpandWildcards 
	{
		[EnumMember(Value = "open")]
		Open,
		[EnumMember(Value = "closed")]
		Closed,
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "all")]
		All
	}
	
	
	public enum DefaultOperator 
	{
		[EnumMember(Value = "AND")]
		And,
		[EnumMember(Value = "OR")]
		Or
	}
	
	
	public enum VersionType 
	{
		[EnumMember(Value = "internal")]
		Internal,
		[EnumMember(Value = "external")]
		External,
		[EnumMember(Value = "external_gte")]
		ExternalGte,
		[EnumMember(Value = "force")]
		Force
	}
	
	
	public enum Conflicts 
	{
		[EnumMember(Value = "abort")]
		Abort,
		[EnumMember(Value = "proceed")]
		Proceed
	}
	
	
	public enum SearchType 
	{
		[EnumMember(Value = "query_then_fetch")]
		QueryThenFetch,
		[EnumMember(Value = "dfs_query_then_fetch")]
		DfsQueryThenFetch
	}
	
	
	public enum OpType 
	{
		[EnumMember(Value = "index")]
		Index,
		[EnumMember(Value = "create")]
		Create
	}
	
	
	public enum Format 
	{
		[EnumMember(Value = "detailed")]
		Detailed,
		[EnumMember(Value = "text")]
		Text
	}
	
	
	public enum ThreadType 
	{
		[EnumMember(Value = "cpu")]
		Cpu,
		[EnumMember(Value = "wait")]
		Wait,
		[EnumMember(Value = "block")]
		Block
	}
	
	
	public enum PercolateFormat 
	{
		[EnumMember(Value = "ids")]
		Ids
	}
	
	
	public enum SuggestMode 
	{
		[EnumMember(Value = "missing")]
		Missing,
		[EnumMember(Value = "popular")]
		Popular,
		[EnumMember(Value = "always")]
		Always
	}
	
	
	public enum GroupBy 
	{
		[EnumMember(Value = "nodes")]
		Nodes,
		[EnumMember(Value = "parents")]
		Parents
	}
	
	
	[Flags]public enum ClusterStateMetric 
	{
		[EnumMember(Value = "blocks")]
		Blocks = 1 << 0,
		[EnumMember(Value = "metadata")]
		Metadata = 1 << 1,
		[EnumMember(Value = "nodes")]
		Nodes = 1 << 2,
		[EnumMember(Value = "routing_table")]
		RoutingTable = 1 << 3,
		[EnumMember(Value = "routing_nodes")]
		RoutingNodes = 1 << 4,
		[EnumMember(Value = "master_node")]
		MasterNode = 1 << 5,
		[EnumMember(Value = "version")]
		Version = 1 << 6,
		[EnumMember(Value = "_all")]
		All = 1 << 7
	}
	
	
	[Flags]public enum Feature 
	{
		[EnumMember(Value = "_settings")]
		Settings = 1 << 0,
		[EnumMember(Value = "_mappings")]
		Mappings = 1 << 1,
		[EnumMember(Value = "_aliases")]
		Aliases = 1 << 2
	}
	
	
	[Flags]public enum IndicesStatsMetric 
	{
		[EnumMember(Value = "completion")]
		Completion = 1 << 0,
		[EnumMember(Value = "docs")]
		Docs = 1 << 1,
		[EnumMember(Value = "fielddata")]
		Fielddata = 1 << 2,
		[EnumMember(Value = "query_cache")]
		QueryCache = 1 << 3,
		[EnumMember(Value = "flush")]
		Flush = 1 << 4,
		[EnumMember(Value = "get")]
		Get = 1 << 5,
		[EnumMember(Value = "indexing")]
		Indexing = 1 << 6,
		[EnumMember(Value = "merge")]
		Merge = 1 << 7,
		[EnumMember(Value = "percolate")]
		Percolate = 1 << 8,
		[EnumMember(Value = "request_cache")]
		RequestCache = 1 << 9,
		[EnumMember(Value = "refresh")]
		Refresh = 1 << 10,
		[EnumMember(Value = "search")]
		Search = 1 << 11,
		[EnumMember(Value = "segments")]
		Segments = 1 << 12,
		[EnumMember(Value = "store")]
		Store = 1 << 13,
		[EnumMember(Value = "warmer")]
		Warmer = 1 << 14,
		[EnumMember(Value = "suggest")]
		Suggest = 1 << 15,
		[EnumMember(Value = "_all")]
		All = 1 << 16
	}
	
	
	[Flags]public enum NodesInfoMetric 
	{
		[EnumMember(Value = "settings")]
		Settings = 1 << 0,
		[EnumMember(Value = "os")]
		Os = 1 << 1,
		[EnumMember(Value = "process")]
		Process = 1 << 2,
		[EnumMember(Value = "jvm")]
		Jvm = 1 << 3,
		[EnumMember(Value = "thread_pool")]
		ThreadPool = 1 << 4,
		[EnumMember(Value = "transport")]
		Transport = 1 << 5,
		[EnumMember(Value = "http")]
		Http = 1 << 6,
		[EnumMember(Value = "plugins")]
		Plugins = 1 << 7,
		[EnumMember(Value = "ingest")]
		Ingest = 1 << 8
	}
	
	
	[Flags]public enum NodesStatsMetric 
	{
		[EnumMember(Value = "breaker")]
		Breaker = 1 << 0,
		[EnumMember(Value = "fs")]
		Fs = 1 << 1,
		[EnumMember(Value = "http")]
		Http = 1 << 2,
		[EnumMember(Value = "indices")]
		Indices = 1 << 3,
		[EnumMember(Value = "jvm")]
		Jvm = 1 << 4,
		[EnumMember(Value = "os")]
		Os = 1 << 5,
		[EnumMember(Value = "process")]
		Process = 1 << 6,
		[EnumMember(Value = "thread_pool")]
		ThreadPool = 1 << 7,
		[EnumMember(Value = "transport")]
		Transport = 1 << 8,
		[EnumMember(Value = "discovery")]
		Discovery = 1 << 9,
		[EnumMember(Value = "_all")]
		All = 1 << 10
	}
	
	
	[Flags]public enum NodesStatsIndexMetric 
	{
		[EnumMember(Value = "completion")]
		Completion = 1 << 0,
		[EnumMember(Value = "docs")]
		Docs = 1 << 1,
		[EnumMember(Value = "fielddata")]
		Fielddata = 1 << 2,
		[EnumMember(Value = "query_cache")]
		QueryCache = 1 << 3,
		[EnumMember(Value = "flush")]
		Flush = 1 << 4,
		[EnumMember(Value = "get")]
		Get = 1 << 5,
		[EnumMember(Value = "indexing")]
		Indexing = 1 << 6,
		[EnumMember(Value = "merge")]
		Merge = 1 << 7,
		[EnumMember(Value = "percolate")]
		Percolate = 1 << 8,
		[EnumMember(Value = "request_cache")]
		RequestCache = 1 << 9,
		[EnumMember(Value = "refresh")]
		Refresh = 1 << 10,
		[EnumMember(Value = "search")]
		Search = 1 << 11,
		[EnumMember(Value = "segments")]
		Segments = 1 << 12,
		[EnumMember(Value = "store")]
		Store = 1 << 13,
		[EnumMember(Value = "warmer")]
		Warmer = 1 << 14,
		[EnumMember(Value = "suggest")]
		Suggest = 1 << 15,
		[EnumMember(Value = "_all")]
		All = 1 << 16
	}
	
	
	[Flags]public enum WatcherStatsMetric 
	{
		[EnumMember(Value = "queued_watches")]
		QueuedWatches = 1 << 0,
		[EnumMember(Value = "pending_watches")]
		PendingWatches = 1 << 1,
		[EnumMember(Value = "_all")]
		All = 1 << 2
	}
	

	public static class KnownEnums
	{
		public static string UnknownEnum { get; } = "_UNKNOWN_ENUM_";
		public static string Resolve(Enum e)
		{
			if (e is Refresh)
			{ 
				switch((Refresh)e)
				{
					case Refresh.True: return "true";
					case Refresh.False: return "false";
					case Refresh.WaitFor: return "wait_for";
				}
			
			}
			
			if (e is Bytes)
			{ 
				switch((Bytes)e)
				{
					case Bytes.B: return "b";
					case Bytes.K: return "k";
					case Bytes.Kb: return "kb";
					case Bytes.M: return "m";
					case Bytes.Mb: return "mb";
					case Bytes.G: return "g";
					case Bytes.Gb: return "gb";
					case Bytes.T: return "t";
					case Bytes.Tb: return "tb";
					case Bytes.P: return "p";
					case Bytes.Pb: return "pb";
				}
			
			}
			
			if (e is Health)
			{ 
				switch((Health)e)
				{
					case Health.Green: return "green";
					case Health.Yellow: return "yellow";
					case Health.Red: return "red";
				}
			
			}
			
			if (e is Size)
			{ 
				switch((Size)e)
				{
					case Size.Raw: return "";
					case Size.K: return "k";
					case Size.M: return "m";
					case Size.G: return "g";
					case Size.T: return "t";
					case Size.P: return "p";
				}
			
			}
			
			if (e is Level)
			{ 
				switch((Level)e)
				{
					case Level.Cluster: return "cluster";
					case Level.Indices: return "indices";
					case Level.Shards: return "shards";
				}
			
			}
			
			if (e is WaitForEvents)
			{ 
				switch((WaitForEvents)e)
				{
					case WaitForEvents.Immediate: return "immediate";
					case WaitForEvents.Urgent: return "urgent";
					case WaitForEvents.High: return "high";
					case WaitForEvents.Normal: return "normal";
					case WaitForEvents.Low: return "low";
					case WaitForEvents.Languid: return "languid";
				}
			
			}
			
			if (e is WaitForStatus)
			{ 
				switch((WaitForStatus)e)
				{
					case WaitForStatus.Green: return "green";
					case WaitForStatus.Yellow: return "yellow";
					case WaitForStatus.Red: return "red";
				}
			
			}
			
			if (e is ExpandWildcards)
			{ 
				switch((ExpandWildcards)e)
				{
					case ExpandWildcards.Open: return "open";
					case ExpandWildcards.Closed: return "closed";
					case ExpandWildcards.None: return "none";
					case ExpandWildcards.All: return "all";
				}
			
			}
			
			if (e is DefaultOperator)
			{ 
				switch((DefaultOperator)e)
				{
					case DefaultOperator.And: return "AND";
					case DefaultOperator.Or: return "OR";
				}
			
			}
			
			if (e is VersionType)
			{ 
				switch((VersionType)e)
				{
					case VersionType.Internal: return "internal";
					case VersionType.External: return "external";
					case VersionType.ExternalGte: return "external_gte";
					case VersionType.Force: return "force";
				}
			
			}
			
			if (e is Conflicts)
			{ 
				switch((Conflicts)e)
				{
					case Conflicts.Abort: return "abort";
					case Conflicts.Proceed: return "proceed";
				}
			
			}
			
			if (e is SearchType)
			{ 
				switch((SearchType)e)
				{
					case SearchType.QueryThenFetch: return "query_then_fetch";
					case SearchType.DfsQueryThenFetch: return "dfs_query_then_fetch";
				}
			
			}
			
			if (e is OpType)
			{ 
				switch((OpType)e)
				{
					case OpType.Index: return "index";
					case OpType.Create: return "create";
				}
			
			}
			
			if (e is Format)
			{ 
				switch((Format)e)
				{
					case Format.Detailed: return "detailed";
					case Format.Text: return "text";
				}
			
			}
			
			if (e is ThreadType)
			{ 
				switch((ThreadType)e)
				{
					case ThreadType.Cpu: return "cpu";
					case ThreadType.Wait: return "wait";
					case ThreadType.Block: return "block";
				}
			
			}
			
			if (e is PercolateFormat)
			{ 
				switch((PercolateFormat)e)
				{
					case PercolateFormat.Ids: return "ids";
				}
			
			}
			
			if (e is SuggestMode)
			{ 
				switch((SuggestMode)e)
				{
					case SuggestMode.Missing: return "missing";
					case SuggestMode.Popular: return "popular";
					case SuggestMode.Always: return "always";
				}
			
			}
			
			if (e is GroupBy)
			{ 
				switch((GroupBy)e)
				{
					case GroupBy.Nodes: return "nodes";
					case GroupBy.Parents: return "parents";
				}
			
			}
			
			if (e is ClusterStateMetric)
			{ 
				var list = new List<string>();
				if (e.HasFlag(ClusterStateMetric.Blocks)) list.Add("blocks");
				if (e.HasFlag(ClusterStateMetric.Metadata)) list.Add("metadata");
				if (e.HasFlag(ClusterStateMetric.Nodes)) list.Add("nodes");
				if (e.HasFlag(ClusterStateMetric.RoutingTable)) list.Add("routing_table");
				if (e.HasFlag(ClusterStateMetric.RoutingNodes)) list.Add("routing_nodes");
				if (e.HasFlag(ClusterStateMetric.MasterNode)) list.Add("master_node");
				if (e.HasFlag(ClusterStateMetric.Version)) list.Add("version");
				if (e.HasFlag(ClusterStateMetric.All)) return "_all";
				return string.Join(",", list);
			
			}
			
			if (e is Feature)
			{ 
				var list = new List<string>();
				if (e.HasFlag(Feature.Settings)) list.Add("_settings");
				if (e.HasFlag(Feature.Mappings)) list.Add("_mappings");
				if (e.HasFlag(Feature.Aliases)) list.Add("_aliases");
				return string.Join(",", list);
			
			}
			
			if (e is IndicesStatsMetric)
			{ 
				var list = new List<string>();
				if (e.HasFlag(IndicesStatsMetric.Completion)) list.Add("completion");
				if (e.HasFlag(IndicesStatsMetric.Docs)) list.Add("docs");
				if (e.HasFlag(IndicesStatsMetric.Fielddata)) list.Add("fielddata");
				if (e.HasFlag(IndicesStatsMetric.QueryCache)) list.Add("query_cache");
				if (e.HasFlag(IndicesStatsMetric.Flush)) list.Add("flush");
				if (e.HasFlag(IndicesStatsMetric.Get)) list.Add("get");
				if (e.HasFlag(IndicesStatsMetric.Indexing)) list.Add("indexing");
				if (e.HasFlag(IndicesStatsMetric.Merge)) list.Add("merge");
				if (e.HasFlag(IndicesStatsMetric.Percolate)) list.Add("percolate");
				if (e.HasFlag(IndicesStatsMetric.RequestCache)) list.Add("request_cache");
				if (e.HasFlag(IndicesStatsMetric.Refresh)) list.Add("refresh");
				if (e.HasFlag(IndicesStatsMetric.Search)) list.Add("search");
				if (e.HasFlag(IndicesStatsMetric.Segments)) list.Add("segments");
				if (e.HasFlag(IndicesStatsMetric.Store)) list.Add("store");
				if (e.HasFlag(IndicesStatsMetric.Warmer)) list.Add("warmer");
				if (e.HasFlag(IndicesStatsMetric.Suggest)) list.Add("suggest");
				if (e.HasFlag(IndicesStatsMetric.All)) return "_all";
				return string.Join(",", list);
			
			}
			
			if (e is NodesInfoMetric)
			{ 
				var list = new List<string>();
				if (e.HasFlag(NodesInfoMetric.Settings)) list.Add("settings");
				if (e.HasFlag(NodesInfoMetric.Os)) list.Add("os");
				if (e.HasFlag(NodesInfoMetric.Process)) list.Add("process");
				if (e.HasFlag(NodesInfoMetric.Jvm)) list.Add("jvm");
				if (e.HasFlag(NodesInfoMetric.ThreadPool)) list.Add("thread_pool");
				if (e.HasFlag(NodesInfoMetric.Transport)) list.Add("transport");
				if (e.HasFlag(NodesInfoMetric.Http)) list.Add("http");
				if (e.HasFlag(NodesInfoMetric.Plugins)) list.Add("plugins");
				if (e.HasFlag(NodesInfoMetric.Ingest)) list.Add("ingest");
				return string.Join(",", list);
			
			}
			
			if (e is NodesStatsMetric)
			{ 
				var list = new List<string>();
				if (e.HasFlag(NodesStatsMetric.Breaker)) list.Add("breaker");
				if (e.HasFlag(NodesStatsMetric.Fs)) list.Add("fs");
				if (e.HasFlag(NodesStatsMetric.Http)) list.Add("http");
				if (e.HasFlag(NodesStatsMetric.Indices)) list.Add("indices");
				if (e.HasFlag(NodesStatsMetric.Jvm)) list.Add("jvm");
				if (e.HasFlag(NodesStatsMetric.Os)) list.Add("os");
				if (e.HasFlag(NodesStatsMetric.Process)) list.Add("process");
				if (e.HasFlag(NodesStatsMetric.ThreadPool)) list.Add("thread_pool");
				if (e.HasFlag(NodesStatsMetric.Transport)) list.Add("transport");
				if (e.HasFlag(NodesStatsMetric.Discovery)) list.Add("discovery");
				if (e.HasFlag(NodesStatsMetric.All)) return "_all";
				return string.Join(",", list);
			
			}
			
			if (e is NodesStatsIndexMetric)
			{ 
				var list = new List<string>();
				if (e.HasFlag(NodesStatsIndexMetric.Completion)) list.Add("completion");
				if (e.HasFlag(NodesStatsIndexMetric.Docs)) list.Add("docs");
				if (e.HasFlag(NodesStatsIndexMetric.Fielddata)) list.Add("fielddata");
				if (e.HasFlag(NodesStatsIndexMetric.QueryCache)) list.Add("query_cache");
				if (e.HasFlag(NodesStatsIndexMetric.Flush)) list.Add("flush");
				if (e.HasFlag(NodesStatsIndexMetric.Get)) list.Add("get");
				if (e.HasFlag(NodesStatsIndexMetric.Indexing)) list.Add("indexing");
				if (e.HasFlag(NodesStatsIndexMetric.Merge)) list.Add("merge");
				if (e.HasFlag(NodesStatsIndexMetric.Percolate)) list.Add("percolate");
				if (e.HasFlag(NodesStatsIndexMetric.RequestCache)) list.Add("request_cache");
				if (e.HasFlag(NodesStatsIndexMetric.Refresh)) list.Add("refresh");
				if (e.HasFlag(NodesStatsIndexMetric.Search)) list.Add("search");
				if (e.HasFlag(NodesStatsIndexMetric.Segments)) list.Add("segments");
				if (e.HasFlag(NodesStatsIndexMetric.Store)) list.Add("store");
				if (e.HasFlag(NodesStatsIndexMetric.Warmer)) list.Add("warmer");
				if (e.HasFlag(NodesStatsIndexMetric.Suggest)) list.Add("suggest");
				if (e.HasFlag(NodesStatsIndexMetric.All)) return "_all";
				return string.Join(",", list);
			
			}
			
			if (e is WatcherStatsMetric)
			{ 
				var list = new List<string>();
				if (e.HasFlag(WatcherStatsMetric.QueuedWatches)) list.Add("queued_watches");
				if (e.HasFlag(WatcherStatsMetric.PendingWatches)) list.Add("pending_watches");
				if (e.HasFlag(WatcherStatsMetric.All)) return "_all";
				return string.Join(",", list);
			
			}
			
			return UnknownEnum;
		}
	}
}
 