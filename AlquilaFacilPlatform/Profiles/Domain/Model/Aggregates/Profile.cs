using AlquilaFacilPlatform.Profiles.Domain.Model.Commands;
using AlquilaFacilPlatform.Profiles.Domain.Model.ValueObjects;

namespace AlquilaFacilPlatform.Profiles.Domain.Model.Aggregates;

public class Profile
{
    public Profile()
    {
        Name = new PersonName();
        Birth = new DateOfBirth();
        PhoneN = new Phone();
        DocumentN = new DocumentNumber();
    }

    public Profile(string name, string fatherName, string motherName, string dateOfBirth, string documentNumber,
        string phone)
    {
        Name = new PersonName(name, fatherName, motherName);
        Birth = new DateOfBirth(dateOfBirth);
        PhoneN = new Phone(phone);
        DocumentN = new DocumentNumber(documentNumber);
    }
    
    public Profile(CreateProfileCommand command)
    {
        Name = new PersonName(command.Name, command.FatherName, command.MotherName);
        Birth = new DateOfBirth(command.DateOfBirth);
        PhoneN = new Phone(command.Phone);
        DocumentN = new DocumentNumber(command.DocumentNumber);
    }

    public int Id { get; }
    public PersonName Name { get; private set; }
    public DateOfBirth Birth { get; private set; }
    public Phone PhoneN { get; private set; }
    public DocumentNumber DocumentN { get; private set; }

    
    public string FullName => Name.FullName;
    
    public string BirthDate => Birth.BirthDate;
    
    public string PhoneNumber => PhoneN.PhoneNumber;
    
    public string NumberDocument => DocumentN.NumberDocument;


}