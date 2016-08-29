﻿using System.Collections.Generic;
using System.Linq;
using ApiGenerator.Domain;

namespace ApiGenerator.Overrides.Descriptors
{
	public class AnalyzeDescriptorOverrides : DescriptorOverridesBase
	{
		public override IEnumerable<string> SkipQueryStringParams => new[]
		{
			"analyzer",
			"char_filters",
			"char_filter",
			"field",
			"filters",
			"filter",
			"text",
			"tokenizer"
		};
	}

	public class IndexDescriptorOverrides : DescriptorOverridesBase
	{
		public override CsharpMethod PatchMethod(CsharpMethod method)
		{
			var part = method.Url.Params.First(p => p.Key == "refresh");
			part.Value.Description = "Refresh the shard after performing the operation";
			return method;
		}
	}
}
