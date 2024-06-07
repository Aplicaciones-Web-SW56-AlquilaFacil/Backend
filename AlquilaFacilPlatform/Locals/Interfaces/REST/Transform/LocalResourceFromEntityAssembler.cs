using AlquilaFacilPlatform.Locals.Domain.Model.Aggregates;
using AlquilaFacilPlatform.Locals.Interfaces.REST.Resources;

namespace AlquilaFacilPlatform.Locals.Interfaces.REST.Transform;

public static class LocalResourceFromEntityAssembler
{
    public static LocalResource ToResourceFromEntity(Local local)
    {
        return new LocalResource(
            local.Id, 
            local.StreetAddress, 
            local.LocalType, 
            local.NightPrice, 
            local.PhotoUrl,
            LocalCategoryResourceFromEntityAssembler.ToResourceFromEntity(local.LocalCategory));
    }
}