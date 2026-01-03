using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentSystem.Domain.Entities.Doctor;

[Table("doctors", Schema = "public")]
public class Doctor : BaseEntity
{
    [Column("name")]
    public string Name { get; private set; }
    [Column("specialization")]
    public string Specialization { get; private set; }

    [Column("phone_number")]
    public string PhoneNumber { get; private set; }

    public Doctor(string name, string specialization, string phoneNumber, string createdBy)
    {
        Name = name;
        Specialization = specialization;
        PhoneNumber = phoneNumber;

        SetCreated(createdBy);
    }

    public void Update(string name, string specialization, string phoneNumber,string? updatedBy)
    {
        Name = name;
        Specialization = specialization;
        PhoneNumber = phoneNumber;
        SetUpdated(updatedBy);
    }
}

