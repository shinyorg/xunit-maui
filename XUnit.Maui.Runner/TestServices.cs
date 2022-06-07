//using Microsoft.Maui.TestUtils.DeviceTests.Runners.HeadlessRunner;

namespace Microsoft.Maui.TestUtils.DeviceTests.Runners
{
	public static class TestServices
	{
		static IServiceProvider? s_services = null;

		internal static void Init(IServiceProvider services) => s_services = services;

		public static IServiceProvider Services
		{
			get
			{
				if (s_services is null)
					throw new InvalidOperationException($"Test app could not find services.");

				return s_services;
			}
		}
	}
}