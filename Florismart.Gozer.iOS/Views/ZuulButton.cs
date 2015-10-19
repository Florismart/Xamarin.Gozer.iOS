using System;
using Foundation;
using Florismart.Gozer.iOS.Core;
using Florismart.Fontwesome.iOS.View;

namespace Florismart.Gozer.iOS.Views
{
	[Register ("ZuulButton")]
	public class ZuulButton: FontwesomeButton
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

		public ZuulButton (IntPtr handle) : base (handle)
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
				SetTitle (value, UIKit.UIControlState.Normal);
		}
	}
}

