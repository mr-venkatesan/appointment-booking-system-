using System.ComponentModel.DataAnnotations.Schema;
namespace AppointmentSystem.Domain.Entities.Users;
public class Users : BaseEntity
{
    [Column("full_name")]
    public String Name {get;private set;}

    [Column("email")]
    public String Email { get; private set; }

    [Column("phone_number")]
    public String PhoneNumber { get; private set; }

    [Column("password_hash")]
    public String Password { get; private set; }

    public Users(String name, String email, String phoneNumber, String password_hash, String createdBy)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Password = password_hash;
        SetCreated(createdBy);
    }

    public void Update(String name, String email, String phoneNumber, String password_hash, String updatedBy)
    {
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Password = password_hash;
        SetUpdated(updatedBy);
    }

}