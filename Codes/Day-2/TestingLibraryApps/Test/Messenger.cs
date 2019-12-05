namespace TestLibrary
{
    /// <summary>
    /// Class with methods to greet
    /// </summary>
    public class Messenger
    {
        /// <summary>
        /// Method to return welcome message for a person provided the name is supplied
        /// </summary>
        /// <param name="name">
        /// name of the person to send the welcome mesage to
        /// </param>
        /// <returns>
        /// returns the welcome message to that person
        /// </returns>
        public static string SayHello(string name)
        {
            //message to be returned to the person
            string message = $"hello {name}";
            //returning the message
            return message;
        }
    }
}
