using System;
using Florismart.Fontwesome.iOS.View;
using Florismart.Gozer.iOS.Core;
using Foundation;

namespace Florismart.Gozer.iOS.Views
{
	[Register ("ZuulLabel")]
	public class ZuulLabel: FontwesomeLabel
	{
		[Export ("keyName")]
		private string _keyName { get; set; }

		public string KeyName {
			get { 
				return _keyName;
			}
			set {
				_keyName = value;
				if (CheckKey ()) {
					SetKeyName ();
				}
			}
		}

		public ZuulLabel (IntPtr handle) : base (handle)
		{
		}

		public override void AwakeFromNib ()
		{
			base.AwakeFromNib ();
			if (CheckKey ())
				SetKeyName ();
		}

		private bool CheckKey ()
		{
			return !string.IsNullOrEmpty (_keyName);
		}

		private void SetKeyName ()
		{
			var value = VinzClortho.Instance.Get (_keyName);

			if (!string.IsNullOrEmpty (value))
				Text = value;
		}
	}
}

