namespace SOLID;


public class Program
{
    // DIP -> high level modules (everything that pulls smth) should not depend on low level modules (doesn't depend on anything),
    //        but rather both should depend on abstracitons. 

    public static void Main()
    {
        IPerson owner = Factory.CreatePerson();

        owner.FirstName = "Ivan";
        owner.LastName = "Petkanov";
        owner.EmailAddress = "i.petkanov@gmail.com";
        owner.PhoneNumber = "+359 887 290 192";


        IChore chore = Factory.CreateChore();
        chore.ChoreName = "Walk My Dawwwwgs";
        chore.Owner = owner;


        chore.PerformedWork(3);
        chore.PerformedWork(1.5);
        chore.CompleteChore();
    }

}