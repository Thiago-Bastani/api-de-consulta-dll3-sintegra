var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", (string InscricaoEstadual, string UF) => {
    int result = DllHandler.ConsisteInscricaoEstadual(InscricaoEstadual, UF);
    return result == 0? "Valido" : "Invalido";
});

app.Run();
