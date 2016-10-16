using System;

using Xamarin.Forms;

namespace OpenSlavaApplication
{
	public class SpeakerProfile : ContentPage
	{
		public SpeakerProfile()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}

