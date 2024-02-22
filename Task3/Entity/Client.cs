using Task3.Attributes;

namespace Task3.Entity;

[ExcelTableName("Клиенты")]
public class Client
{
    public Client(int id, string name, string address, string contactPerson)
    {
        Id = id;
        OrgName = name;
        Address = address;
        ContactPerson = contactPerson;
    }
    [ExcelColumnName("Код клиента")]
    public int Id { get; set; }
    [ExcelColumnName("Наименование организации")]
    public string OrgName { get; set; }
    [ExcelColumnName("Адрес")]
    public string Address { get; set; }
    [ExcelColumnName("Контактное лицо (ФИО)")]
    public string ContactPerson { get; set; }
}