var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CompleteAspireNETAPP_ApiService>("apiservice");

builder.AddProject<Projects.CompleteAspireNETAPP_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
