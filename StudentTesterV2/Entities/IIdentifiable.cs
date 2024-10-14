namespace StudentTesterV3.Entities
{
    public interface IIdentifiable
    {
        string Id { get; set; }
        string Name { get; set; }
        int Yob { get; set; }
        double Gpa { get; set; }
    }
}