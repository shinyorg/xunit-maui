using System.Reflection;

namespace XUnit.Maui.Runners
{
	public class TestOptions
	{
		/// <summary>
		/// The list of assemblies that contain tests.
		/// </summary>
		public List<Assembly> Assemblies { get; } = new List<Assembly>();

		/// <summary>
		/// The list of categories to skip in the form:
		///   [category-name]=[skip-when-value]
		/// </summary>
		public List<string> SkipCategories { get; } = new List<string>();
	}
}