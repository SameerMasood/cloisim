/*
 * Copyright (c) 2020 LG Electronics Inc.
 *
 * SPDX-License-Identifier: MIT
 */

using System.Xml;

namespace SDF
{
	public class Plugins : Entities<Plugin>
	{
		private const string TARGET_TAG = "plugin";
		public Plugins() : base(TARGET_TAG) { }
		public Plugins(XmlNode _node) : base(_node, TARGET_TAG) { }
	}

	public class Plugin : Entity
	{
		private string filename;

		public string FileName => filename;

		public XmlNode GetNode()
		{
			return GetNode(".");
		}

		public Plugin(XmlNode _node)
			: base(_node)
		{
			if (root != null)
			{
				ParseElements();
			}
		}

		protected override void ParseElements()
		{
			filename = GetAttribute<string>("filename");
		}

		public string ClassName()
		{
			var pluginName = filename;
			if (pluginName.StartsWith("lib"))
			{
				pluginName = pluginName.Substring(3);
			}

			if (pluginName.EndsWith(".so"))
			{
				var foundIndex = pluginName.IndexOf(".so");
				pluginName = pluginName.Remove(foundIndex);
			}

			return pluginName;
		}
	}
}