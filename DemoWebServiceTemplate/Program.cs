//cria o objeto que tem todas as configurações asp.net
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//envolve injeções de dependências - serviços adicionais dos quais eu dependo e vou usar
//suporte aos
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
