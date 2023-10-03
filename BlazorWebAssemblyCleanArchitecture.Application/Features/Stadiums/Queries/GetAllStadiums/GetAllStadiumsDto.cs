using BlazorWebAssemblyCleanArchitecture.Application.Common.Mappings;
using BlazorWebAssemblyCleanArchitecture.Domain.Entities;

namespace BlazorWebAssemblyCleanArchitecture.Application.Features.Stadiums.Queries.GetAllStadiums
{
    public class GetAllStadiumsDto : IMapFrom<Stadium>
    {
        public int Id { get; init; }
        public string Name { get; set; } = null!;
        public string City { get; set; } = null!;
        public int? Capacity { get; set; }
        public int? BuiltYear { get; set; }
        public int? PitchLength { get; set; }
        public int? PitchWidth { get; set; }
    }
}