using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.EfCore;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<ICourseService, CourseManager>();

builder.Services.AddScoped<ICourseCenterService,CourseCenterManager>();

builder.Services.AddScoped<IStudentService, StudentManager>();

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICourseCenterRepository, CourseCenterRepository>();


// Add services to the container.

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
