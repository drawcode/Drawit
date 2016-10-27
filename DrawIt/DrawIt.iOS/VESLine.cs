using UIKit;
using Xamarin.Forms;

namespace DrawIt.iOS
{
	public class VESLine{
		public UIBezierPath Path {
			get;
			set;
		}

		public Color Color {
			get;
			set;
		}

		public byte Index {
			get;
			set;
		}
	}
}

