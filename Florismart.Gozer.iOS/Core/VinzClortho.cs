using System;
using System.Collections.Generic;

namespace Florismart.Gozer.iOS.Core
{
	/// <summary>
	/// Vinz clortho, the keymaster!.
	/// </summary>
	public class VinzClortho
	{
		public Dictionary<string, string> Keys { private get; set; }

		private static VinzClortho _instance;

		public static VinzClortho Instance {
			get { 
				if (_instance == null)
					_instance = new VinzClortho ();
				return _instance;
			}
		}

		private VinzClortho ()
		{
			Keys = new Dictionary<string,string> ();
		}

		private string DefaultFor (string Key)
		{
			return string.Empty;
		}

		private bool Contains (string key)
		{
			return Keys.ContainsKey (key);
		}

		public string Get (string key)
		{
			return this.Contains (key) ? Keys [key] : this.DefaultFor (key);
		}
	}
}

