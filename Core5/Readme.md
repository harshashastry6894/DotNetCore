# Model first:

# After creating model execute below commands

# dotnet ef migrations add InitialCreate

# dotnet ef database update

# Dependency injection

we can inject depencies in startup (configure serive method) so that it is available application wise so that no need to instantiate every time we just need to reference the exisiting object.
