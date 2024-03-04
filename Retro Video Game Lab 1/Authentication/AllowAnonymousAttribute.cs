namespace VideoGameExchangeFinal.Authentication
{
    /* Code block provided by:
     * Whetmore, J (2020). dotnet-6-basic-authentication-api source code.
     * Retrieved from https://github.com/cornflourblue/dotnet-6-basic-authentication-api/blob/master/Services/UserService.cs
     * */

    // It probably does something, right?
    [AttributeUsage(AttributeTargets.Method)]
    public class AllowAnonymousAttribute : Attribute
    {
    }
}
