using System.Runtime.InteropServices;
using UIKit;

namespace XUnit.Maui.Runners
{
	public class ColorComparison : IEqualityComparer<UIColor>
	{
		public const double Tolerance = 0.000001;

		public static bool ARGBEquivalent(UIColor? color1, UIColor? color2, double tolerance = Tolerance)
		{
			if (color1 == null && color2 == null)
				return true;
			if (color1 == null || color2 == null)
				return false;

			color1.GetRGBA(out NFloat red1, out NFloat green1, out NFloat blue1, out NFloat alpha1);
			color2.GetRGBA(out NFloat red2, out NFloat green2, out NFloat blue2, out NFloat alpha2);

			return Equal(red1, red2, tolerance)
				&& Equal(green1, green2, tolerance)
				&& Equal(blue1, blue2, tolerance)
				&& Equal(alpha1, alpha2, tolerance);
		}

		static bool Equal(NFloat v1, NFloat v2, double tolerance)
		{
			return Math.Abs(v1 - v2) <= tolerance;
		}

		public bool Equals(UIColor? x, UIColor? y) => ARGBEquivalent(x, y);

		public int GetHashCode(UIColor obj) => obj.GetHashCode();
	}
}