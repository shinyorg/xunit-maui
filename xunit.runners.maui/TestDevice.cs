﻿//#nullable enable
//using System;
//using System.Globalization;
//using Microsoft.DotNet.XHarness.TestRunners.Common;
//using Microsoft.Maui.ApplicationModel;
//using Microsoft.Maui.Devices;

//namespace Xunit.Runners.Maui.HeadlessRunner
//{
//	class TestDevice : IDevice
//	{
//		public string BundleIdentifier => AppInfo.PackageName;

//		public string UniqueIdentifier => Guid.NewGuid().ToString("N");

//		public string Name => DeviceInfo.Name;

//		public string Model => DeviceInfo.Model;

//		public string SystemName => DeviceInfo.Platform.ToString();

//		public string SystemVersion => DeviceInfo.VersionString;

//		public string Locale => CultureInfo.CurrentCulture.Name;
//	}
//}