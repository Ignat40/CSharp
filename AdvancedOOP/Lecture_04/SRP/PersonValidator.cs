namespace SOLID
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandartMessages.DisplayValidationError("first name");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandartMessages.DisplayValidationError("last name");
                return false;
            }

            return true; 
        }
    }

}