//Assignments();
//InterfaceImplementation();
//Nullable();
//ChangeValueTest();

void Assignments()
{
    // class
    var userc1 = new UserClass();
    userc1.Id = 1;

    var userc2 = userc1;
    userc2.Id = 2;

    Console.WriteLine(userc1.Id);
    Console.WriteLine(userc2.Id);

    // struct
    var users1 = new UserStruct();
    users1.Id = 1;

    var users2 = users1;
    users2.Id = 2;

    Console.WriteLine(users1.Id);
    Console.WriteLine(users2.Id);
}

void InterfaceImplementation()
{
    // class
    IUser userc1 = new UserClass();
    userc1.Id = 1;

    IUser userc2 = userc1;
    userc2.Id = 2;

    Console.WriteLine(userc1.Id);
    Console.WriteLine(userc2.Id);

    // struct
    IUser users1 = new UserStruct();
    users1.Id = 1;

    IUser users2 = users1;
    users2.Id = 2;

    Console.WriteLine(users1.Id);
    Console.WriteLine(users2.Id);
}

void Nullable()
{
    UserClass userc = null;
    //UserStruct users1 = null;
    UserStruct users2 = new UserStruct();
    UserStruct users3 = new();
    UserStruct users4 = default;
}

void ChangeClassValue(UserClass user)
{
    user.Id--;
}

void ChangeStructValue(UserStruct user)
{
    user.Id--;
}

void ChangeValueTest()
{
    var userc = new UserClass();
    userc.Id = 1;
    ChangeClassValue(userc);
    Console.WriteLine(userc.Id);

    var users = new UserStruct();
    users.Id = 1;
    ChangeStructValue(users);
    Console.WriteLine(users.Id);
}

public class UserClass: IUser
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    public UserClass InlineUserClass { get; set; }
}

public struct UserStruct: IUser
{
    public int Id { get; set; }
    public string Fullname { get; set; }
    //public UserStruct InlineUserStruct { get; set; }
    public UserStruct2 InlineUserStruct2 { get; set; }
}

public struct UserStruct2
{

}

public interface IUser
{
    public int Id { get; set; }
    public string Fullname { get; set; }
}