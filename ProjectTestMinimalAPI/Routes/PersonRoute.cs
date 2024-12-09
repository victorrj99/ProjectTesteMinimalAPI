using ProjectTestMinimalAPI.Modules;

namespace ProjectTestMinimalAPI.Routes;

public static class PersonRoute
{
    public static void PersonRoutes(this WebApplication app)
    {
        app.MapGet("Person", () => new PersonModel("João"));
    }
}