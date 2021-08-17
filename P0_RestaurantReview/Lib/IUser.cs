namespace Lib
{
    public interface IUser
    {
        string name { get; set; }
        Gender gender { get; set; }
        int age  { get; set; }  
    }
}