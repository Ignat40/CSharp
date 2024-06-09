using solid;

namespace SOLID;

public static class Factory
{
    public static IPerson CreatePerson()
    {
        return new Person();
    }

    public static IChore CreateChore()
    {
        return new Chore(CreateLogger(), CreateMessage());
    }

    public static ILogger CreateLogger()
    {
        return new Logger();
    }

    public static IMessageSender CreateMessage()
    {
        return new Texter();
    }
}