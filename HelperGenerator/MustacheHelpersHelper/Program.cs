using Handlebars.Net.Helpers;
using Handlebars.Net.Helpers.Library.Models;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace MustacheHelpersHelper {
	internal class Program {
		private static void Main() {
			var handlebars = HandlebarsDotNet.Handlebars.Create();
			var registerHelpers = new RegisterHelpers(handlebars);
			registerHelpers.Register();

			var markdownOutput = new StringBuilder();

			var docs = registerHelpers.HelperDocumentation.OrderBy(p => p.Key);
			foreach (var item in docs) {
				var key = item.Key;
				var doc = item.Value;
				markdownOutput.AppendLine(ToMarkdown(key, doc));
			}

			var outString = markdownOutput.ToString();
			const string markdownFile = @"..\..\..\..\docs\helpers.md";
			var file = new FileInfo(markdownFile);
			// ReSharper disable once AssignNullToNotNullAttribute - basically a hard-coded string; we definitely want an exception if this doesn't exist
			Directory.CreateDirectory(file.DirectoryName);
			File.WriteAllText(markdownFile, outString);
		}

		private static string ToMarkdown(string function, Documentation doc) {
			var output = new StringBuilder();

			output.AppendLine($"## {function}");
			AddIfNotEmpty("Summary", doc.Summary);
			AddIfNotEmpty("Returns", doc.Returns);
			AddIfNotEmpty("Example", doc.Example);

			if (doc.Parameters.Any()) {
				output.AppendLine("### Parameters");
				foreach (var parm in doc.Parameters) {
					output.AppendLine($"* {parm.Key}: {parm.Value}");
				}
			}

			return output.ToString();

			void AddIfNotEmpty(string name, string value) {
				if (!String.IsNullOrWhiteSpace(value)) {
					output.AppendLine($"### {name}{Environment.NewLine}{value}");
				}
			}
		}
	}
}
