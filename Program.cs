using chairs_dotnet7_api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("chairlist"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();

var chairs = app.MapGroup("api/chair");

//TO DO: ASIGNACION DE RUTAS A LOS ENDPOINTS
chairs.MapPost("/chair",PostCreateChair );
chairs.MapGet("/chair", GetChairs);
chairs.MapGet("/chair,{name}", GetChairsByName);
chairs.MapPut("/chair, {id}", PutChairById);
chairs.MapPut("/chair, {id}/stock", PutChairStock);
chairs.MapPost("/chair/purschase", PutBuyChair);
chairs.MapDelete("/chair/{id}", DeleteChair);



app.Run();

//TO DO: ENDPOINTS SOLICITADOS

static async Task<IResult> PostCreateChair(DataContext db, chair.name)
{

}
static async Task<IResult> GetChairs(DataContext db)
{
    //obtener todas las sillas
    
    return TypedResults.Ok(await db.Chair.toArrayAsync());
}

static Task<IResult> GetChairsByName(DataContext db)
{

}
static Task<IResult> PutChairById(DataContext db)
{

}
static Task<IResult> PutChairStock(DataContext db)
{

}
static Task<IResult> PutBuyChair (DataContext db)
{

}
static Task<IResult> DeleteChair (DataContext db)
{

}
