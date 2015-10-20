Xamarin.Gozer.iOS
=============

Gozer is an Open Source Xamarin iOS library that allows developers to easily create applications with custom fonts and easily works  with preloaded labels. Feel free to use it all you want in your Android apps provided that you cite this project and include the license in your app.
It extends https://github.com/Florismart/Xamarin.Fontwesome project, so you can use (or not) its setups!

![Screenshot](https://github.com/Florismart/Xamarin.Gozer.iOS/blob/master/screen-app.png)


Setup
-----
__1.__ In Xamarin, import the library as an iOS library project. Now you can build it and export as DLL.

__2.__ Then, add Fontysfaction dll as a dependency to your existing project.

__3.__ At Last quick setup your application class and you are good to go!

Or just import via nuget as Xamarin.Gozer.iOS

```C#
[Register ("AppDelegate")]
public partial class AppDelegate : UIApplicationDelegate
{

    public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			InitDictionary ();
			//...
			return true;
		}
		
		private void InitDictionary ()
		{
			//crete dictionary (download your dictionary or load from assets..)
			var keys = new Dictionary<string, string> ();
			keys.Add ("egon", "Dr. Egon Spengler");
			keys.Add ("ray", "Dr Ray Stantz");
			keys.Add ("gozer", "Gozer");
			keys.Add ("questionOne", "Are you a God?");
			keys.Add ("answerOne", "No");
			keys.Add ("answerTwo", "Then... DIE! ");

			VinzClortho.Instance.Keys = keys;
		}
		
		
}
```

Configuration
-----
Dictionary for VinzClortho (the Keymaster) is optional. But you shoud assign it if you wana see something in your app :D
```C#
VinzClortho.Instance.Keys = new Dictionary<string, string>();
```

Usage
-----
Configurations ended! Now open your storyboard or simple xibs and use our 

- ZuulButton as UIButton
- ZuulLabel as UILabel
- ZuulTextField as UITextField
- ZuulTextView as UITextView

...and set User Runtimes


![Screenshot](https://raw.githubusercontent.com/Florismart/Xamarin.Gozer.iOS/master/runtime_attrbutes.png)
