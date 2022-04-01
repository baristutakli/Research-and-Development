# MongoDB and Generic Repository

## Project Structure

### Entities
* BaseEntity
* Playlist derived from BaseEntity

### MongoDBSettings

```c#
    public class MongoDBSettings:IMongoDBSettings
    {
        public string ConnectionURI { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string CollectionName { get; set; } = null!;
    }
```

### Context
* IMongoContext
* MongoContext

### Respositories
* IRepository
* Repository(this is the base repository)
* IPlaylistRepository
* PlaylistRepository

### Configuration Settings and Registration of Services

```c#
// Register a configuration
builder.Services.Configure<MongoDBSettings>(builder.Configuration.GetSection("MongoDB"));


// Register a service and get the information from MongoDbSettings
builder.Services.AddSingleton<IMongoDBSettings>(serviceProvider =>
    serviceProvider.GetRequiredService<IOptions<MongoDBSettings>>().Value);


// Register services
builder.Services.AddScoped<IPlaylistRepository, PlaylistRepository>();
builder.Services.AddScoped<IMongoContext, MongoContext>();
```
