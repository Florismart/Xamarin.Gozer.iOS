using System;
using Foundation;
using Florismart.Fontwesome.iOS.View;
using Florismart.Gozer.iOS.Core;

namespace Florismart.Gozer.iOS.Views
{
	[Register ("ZuulTextField")]
	public class ZuulTextField: FontwesomeTextField
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

		public ZuulTextField (IntPtr handle) : base (handle)
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
				Placeholder = value;
		}
	}
}

