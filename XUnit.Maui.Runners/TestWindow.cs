#nullable enable
using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
//using XUnit.Maui.Runners.HeadlessRunner;

#if __IOS__ || MACCATALYST
using PlatformView = UIKit.UIWindow;
#elif MONOANDROID
using PlatformView = Android.App.Activity;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.Window;
#elif (NETSTANDARD || !PLATFORM) || (NET6_0 && !IOS && !ANDROID)
using PlatformView = System.Object;
#endif

namespace XUnit.Maui.Runners
{
	public static class TestWindow
	{
		static PlatformView? s_platformWindow;

		public static PlatformView PlatformWindow
		{
			get
			{
//				if (s_platformWindow is null)
//				{
//#if ANDROID
//					s_platformWindow = MauiTestInstrumentation.Current?.CurrentExecutionContext as PlatformView;
//#elif IOS
//					s_platformWindow = MauiTestApplicationDelegate.Current?.Window;
//#endif
//				}

				if (s_platformWindow is null)
				{
					var application = TestServices.Services.GetService<IApplication>();
					s_platformWindow = application?.Windows.FirstOrDefault()?.Handler?.PlatformView as PlatformView;
				}

				if (s_platformWindow is null)
					throw new InvalidOperationException($"Test app did not provide a window.");

				return s_platformWindow;
			}
		}
	}
}