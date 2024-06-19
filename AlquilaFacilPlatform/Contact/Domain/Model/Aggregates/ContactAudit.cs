using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace AlquilaFacilPlatform.Contact.Domain.Model.Aggregates;

public partial class Contact : IEntityWithCreatedUpdatedDate 
{
    [Column("CreatedAt")] public DateTimeOffset? CreatedDate { get; set; }
    [Column("UpdateAt")] public DateTimeOffset? UpdatedDate { get; set; }
}