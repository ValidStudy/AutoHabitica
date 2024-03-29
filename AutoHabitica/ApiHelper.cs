using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace AutoHabitica
{
    internal class ApiHelper
    {
        private HttpClient client;
        public ApiHelper(string userId, string apiKey)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("x-api-user", userId);
            client.DefaultRequestHeaders.Add("x-api-key", apiKey);
            client.BaseAddress = new Uri("https://habitica.com/api/v3/");
        }
        public async Task<string> GetTasksAsync()
        {
            Debug.WriteLine("Sending tasks request...");
            try
            {
                var response = await client.GetAsync("tasks/user?"+ "type=habits");
                var responseString = await response.Content.ReadAsStringAsync();
                //Debug.WriteLine(responseString);
                return responseString;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred. Please try again"+Environment.NewLine
                    +ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return null;

        }
        public async void ScoreHabitAsync(string taskId)
        {
            bool success=false;
            while(!success)
            {
                try
                {
                    Debug.WriteLine($"Posting {taskId}...");
                    var response = await client.PostAsync("tasks/" + taskId + "/score/up",null);
                    var responseString=await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(responseString);
                    success = true;
                }
                catch (Exception ex)
                {
                    if (MessageBox.Show("An error occurred when scoring habit. Retry?"
                        + Environment.NewLine
                        + ex.Message, "Error", MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Error) != DialogResult.OK) success=true;
                    //Fake success. Just for user return.
                }
            }


        }

    }
}
