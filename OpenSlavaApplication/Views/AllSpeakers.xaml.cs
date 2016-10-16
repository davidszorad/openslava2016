using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OpenSlavaApplication
{
	public partial class AllSpeakers : ContentPage
	{
		public AllSpeakers()
		{
			InitializeComponent();
		}

		protected async override void OnAppearing()
		{
			base.OnAppearing();

			Speakers allSpeakers = await SpeakersViewModel.GetSpeakers();

			if (allSpeakers != null)
			{
				SpeakersList.ItemsSource = allSpeakers.speakers;
			}
		}

		async void OnSpeakerItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var gotoItem = e.SelectedItem as Speaker;
			var gotoPage = new SpeakerProfile();

			gotoPage.BindingContext = gotoItem;
			await Navigation.PushAsync(gotoPage);
		}
	}
}
