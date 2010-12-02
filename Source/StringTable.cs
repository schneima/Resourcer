// ---------------------------------------------------------
// Lutz Roeder's .NET Resourcer, August 2000.
// Copyright (C) 2000-2003 Lutz Roeder. All rights reserved.
// http://www.lutzroeder.com/dotnet
// --------------------------------------------------------- 
namespace Resourcer
{
	using System;
	using System.IO;
	using System.Drawing;

	internal sealed class StringTable
	{
		private StringTable()
		{
		}

		public static string GetString(string name)
		{
			switch (name)
			{
				case "ApplicationName":
					return ".NET Resourcer";

				case "Homepage":
					return "http://www.lutzroeder.com";

				case "Ok":
					return "OK";

				case "Cancel":
					return "Cancel";
			}
			
			throw new NotSupportedException();	
		}
	}
}
