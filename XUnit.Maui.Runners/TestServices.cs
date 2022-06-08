//using XUnit.Maui.Runners.HeadlessRunner;

namespace XUnit.Maui.Runners
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