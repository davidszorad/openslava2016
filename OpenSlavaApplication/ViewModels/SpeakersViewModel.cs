using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenSlavaApplication
{
	public class SpeakersViewModel
	{
		public static async Task<Speakers> GetSpeakers()
		{
			string baseUrl = "PLACEHOLDER_FOR_REST_API_URL";
			var client = new HttpClient();

			using (HttpResponseMessage response = await client.GetAsync(new Uri(baseUrl.ToString(), UriKind.Absolute)))
			{
				if (response.IsSuccessStatusCode)
				{
					string speakersJson = await client.GetStringAsync(baseUrl);
					Speakers speakers = JsonConvert.DeserializeObject<Speakers>(speakersJson);
					return speakers;
				}
			}
			return null;
		}
	}
}
