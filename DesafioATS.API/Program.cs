using DesafioATS.Application.Commands.Candidate;
using DesafioATS.Application.Profiles;
using DesafioATS.Domain.RepositoriesContracts;
using DesafioATS.Infrastructure.Data;
using DesafioATS.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(CandidateProfile).Assembly);
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(typeof(CreateCandidateCommandHandler).Assembly));
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<MongoDbContext>();

builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
builder.Services.AddScoped<IVacancyRepository, VacancyRepository>();
builder.Services.AddScoped<IVacancyApplicationRepository, VacancyApplicationRepository>();
builder.Services.AddScoped<ICandidateResumeRepository, CandidateResumeRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
