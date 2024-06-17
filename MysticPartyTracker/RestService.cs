using MysticPartyTracker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MysticPartyTracker
{
    public class RestService
    {
        HttpClient _client;
        JsonSerializerOptions _serializerOptions;

        public ObservableCollection<Spells> Magias { get; set; }

        public RestService()
        {
            Magias = null;
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public async Task<ObservableCollection<Spells>> GetMagiaAsync()
        {
            Magias = new ObservableCollection<Spells>();

            Uri uri = new Uri("https://www.dnd5eapi.co/api/spells");
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    Magias = JsonSerializer.Deserialize<ObservableCollection<Spells>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);

            }
            return Magias;
        }
    }
}
