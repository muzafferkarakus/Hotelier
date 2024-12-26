using Hotelier.WebUI.Dtos.FollowersDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Hotelier.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            //Instagram
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/muzaffer.karakus"),
                Headers =
    {
        { "x-rapidapi-key", "83f88aaf35msh5bee98e575be6ebp109084jsn4c2c9f5495b9" },
        { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                ResultInstagramFollowersDto resultInstagramFollowersDto = JsonConvert.DeserializeObject<ResultInstagramFollowersDto>(body);
                ViewBag.igFollower = resultInstagramFollowersDto.followers;
                ViewBag.igFollowing = resultInstagramFollowersDto.following;
            }


            //Twitter 
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter154.p.rapidapi.com/user/details?username=mkfotograf&user_id=96479162"),
                Headers =
    {
        { "x-rapidapi-key", "83f88aaf35msh5bee98e575be6ebp109084jsn4c2c9f5495b9" },
        { "x-rapidapi-host", "twitter154.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                ResultTwitterFollowersDto resultTwitterFollowersDto = JsonConvert.DeserializeObject<ResultTwitterFollowersDto>(body2);
                ViewBag.xFollower = resultTwitterFollowersDto.follower_count;
                ViewBag.xFollowing = resultTwitterFollowersDto.following_count;
            }


            //LinkedIn
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://fresh-linkedin-profile-data.p.rapidapi.com/get-linkedin-profile?linkedin_url=https%3A%2F%2Fwww.linkedin.com%2Fin%2Fmuzafferkarakus%2F&include_skills=false&include_certifications=false&include_publications=false&include_honors=false&include_volunteers=false&include_projects=false&include_patents=false&include_courses=false&include_organizations=false&include_profile_status=false&include_company_public_url=false"),
                Headers =
    {
        { "x-rapidapi-key", "83f88aaf35msh5bee98e575be6ebp109084jsn4c2c9f5495b9" },
        { "x-rapidapi-host", "fresh-linkedin-profile-data.p.rapidapi.com" },
    },
            };
            using (var response3 = await client.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                ResultLinkedInFollowersDto resultLinkedInFollowersDto = JsonConvert.DeserializeObject<ResultLinkedInFollowersDto>(body3);
                ViewBag.InConnection = resultLinkedInFollowersDto.data.connection_count;
                ViewBag.InFollower = resultLinkedInFollowersDto.data.follower_count;
            }

            return View();
        }
    }
}
