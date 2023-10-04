using BlazorWebAssemblyCleanArchitecture.Application.Features.Stadiums.Queries.GetAllStadiums;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace BlazorWebAssemblyCleanArchitecture.WebUI.Pages
{
    public partial class Stadiums
    {
        [Inject]
        private HttpClient Http { get; set; }

        private List<GetAllStadiumsDto> stadiums;

        protected override async Task OnInitializedAsync()
        {
            stadiums = await Http.GetFromJsonAsync<List<GetAllStadiumsDto>>("api/stadiums");
        }
    }
}