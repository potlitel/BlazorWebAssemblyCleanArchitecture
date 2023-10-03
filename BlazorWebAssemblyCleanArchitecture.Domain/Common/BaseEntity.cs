using BlazorWebAssemblyCleanArchitecture.Domain.Common.Interfaces;

namespace BlazorWebAssemblyCleanArchitecture.Domain.Common
{
    public abstract class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}