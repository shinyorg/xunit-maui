using System.Reflection;
using Xunit.Sdk;

namespace XUnit.Maui.Runners
{
	/// <summary>	
	/// Usage Example
	/// [Theory]
	/// [Repeat(100)]
	/// public async Task TheSameImageSourceReturnsTheSameBitmap(int _)
	/// </summary>
	public sealed class RepeatAttribute : DataAttribute
	{
		readonly int _count;

		public RepeatAttribute(int count)
		{
			this._count = count;
		}

		public override IEnumerable<object[]> GetData(MethodInfo testMethod)
		{
			foreach (var iterationNumber in Enumerable.Range(start: 1, count: this._count))
			{
				yield return new object[] { iterationNumber };
			}
		}
	}
}
