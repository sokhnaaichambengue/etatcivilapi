using EtatCivilAPI.Data;
namespace EtatCivilAPI.Models
{
    public class Death
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Address { get; set; }

        public string Nationality { get; set; }

        public string FatherFirstName { get; set; }

        public string FatherLastName { get; set; }

        public string MotherFirstName { get; set; }

        public string MotherLastName { get; set; }
    }


public static class DeathEndpoints
{
	public static void MapDeathEndpoints (this IEndpointRouteBuilder routes)
    {
        routes.MapGet("/api/Death", async (EtatCivilAPIContext db) =>
        {
            return await db.Death.ToListAsync();
        })
        .WithName("GetAllDeaths");

        routes.MapGet("/api/Death/{id}", async (int Id, EtatCivilAPIContext db) =>
        {
            return await db.Death.FindAsync(Id)
                is Death model
                    ? Results.Ok(model)
                    : Results.NotFound();
        })
        .WithName("GetDeathById");

        routes.MapPut("/api/Death/{id}", async (int Id, Death death, EtatCivilAPIContext db) =>
        {
            var foundModel = await db.Death.FindAsync(Id);

            if (foundModel is null)
            {
                return Results.NotFound();
            }

            db.Update(death);

            await db.SaveChangesAsync();

            return Results.NoContent();
        })
        .WithName("UpdateDeath");

        routes.MapPost("/api/Death/", async (Death death, EtatCivilAPIContext db) =>
        {
            db.Death.Add(death);
            await db.SaveChangesAsync();
            return Results.Created($"/Deaths/{death.Id}", death);
        })
        .WithName("CreateDeath");


        routes.MapDelete("/api/Death/{id}", async (int Id, EtatCivilAPIContext db) =>
        {
            if (await db.Death.FindAsync(Id) is Death death)
            {
                db.Death.Remove(death);
                await db.SaveChangesAsync();
                return Results.Ok(death);
            }

            return Results.NotFound();
        })
        .WithName("DeleteDeath");
    }
}}
