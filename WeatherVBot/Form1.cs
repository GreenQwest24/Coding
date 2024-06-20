using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Speech.Recognition;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class MainForm : Form
    {
        private const string OpenWeatherMapApiKey = "your_api_key_here"; // Replace with your OpenWeatherMap API key
        private const string OpenWeatherMapApiUrl = "http://api.openweathermap.org/data/2.5/weather?q={0}&units=metric&appid={1}";

        private SpeechRecognitionEngine speechRecognizer;

        public MainForm()
        {
            InitializeComponent();
            InitializeSpeechRecognition();
        }

        private void InitializeSpeechRecognition()
        {
            try
            {
                speechRecognizer = new SpeechRecognitionEngine();

                // Load grammar for recognizing city names
                Choices cities = new Choices(new string[] { "New York", "London", "Paris", "Berlin", "Tokyo" });
                GrammarBuilder gb = new GrammarBuilder();
                gb.Append(cities);
                Grammar grammar = new Grammar(gb);

                speechRecognizer.LoadGrammarAsync(grammar);
                speechRecognizer.SetInputToDefaultAudioDevice();
                speechRecognizer.SpeechRecognized += SpeechRecognizer_SpeechRecognized;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing Speech Recognition: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void SpeechRecognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string cityName = e.Result.Text;

            await GetWeather(cityName);
        }

        private async void btnGetWeather_Click(object sender, EventArgs e)
        {
            string cityName = txtCity.Text.Trim();
            await GetWeather(cityName);
        }

        private async Task GetWeather(string cityName)
        {
            try
            {
                string apiUrl = string.Format(OpenWeatherMapApiUrl, cityName, OpenWeatherMapApiKey);

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        WeatherData weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

                        DisplayWeather(weatherData);
                    }
                    else
                    {
                        MessageBox.Show($"Failed to retrieve weather data. Status code: {response.StatusCode}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving weather data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayWeather(WeatherData weatherData)
        {
            if (weatherData != null)
            {
                lblWeather.Text = $"Weather: {weatherData.weather[0].description}";
                lblTemperature.Text = $"Temperature: {weatherData.main.temp} °C";
                lblCity.Text = $"City: {weatherData.name}";
            }
        }

        private void btnStartListening_Click(object sender, EventArgs e)
        {
            try
            {
                speechRecognizer.RecognizeAsync(RecognizeMode.Multiple);
                btnStartListening.Enabled = false;
                btnStopListening.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting speech recognition: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnStopListening_Click(object sender, EventArgs e)
        {
            try
            {
                speechRecognizer.RecognizeAsyncStop();
                btnStartListening.Enabled = true;
                btnStopListening.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error stopping speech recognition: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (speechRecognizer != null)
            {
                speechRecognizer.Dispose();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class WeatherData
    {
        public Weather[] weather { get; set; }
        public Main main { get; set; }
        public string name { get; set; }
    }

    public class Weather
    {
        public string description { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
    }
}

