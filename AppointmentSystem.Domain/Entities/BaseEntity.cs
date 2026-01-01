using System.ComponentModel.DataAnnotations.Schema;

public abstract class BaseEntity
{
    [Column("id")]
    public Guid Id { get; protected set; }
    
    [Column("created_by")]
    public string CreatedBy { get; protected set; } = string.Empty;
    [Column("updated_by")]
    public string? UpdatedBy { get; protected set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; protected set; }
    
    [Column("updated_at")]
    public DateTime? UpdatedAt { get; protected set; }

    protected BaseEntity()
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
    }

    public void SetCreated(string createdBy)
    {
        CreatedBy = createdBy;
        CreatedAt = DateTime.UtcNow;
    }

    public void SetUpdated(string? updatedBy)
    {
        UpdatedBy = updatedBy;
        UpdatedAt = DateTime.UtcNow;
    }
}
