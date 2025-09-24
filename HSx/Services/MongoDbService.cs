using MongoDB.Driver;
using HSx.Models;

namespace HSx.Services;

public class MongoDbService
{
    private readonly IMongoCollection<Article> _articlesCollection;

    public MongoDbService(IMongoClient mongoClient)
    {
        // Используем переданный клиент
        var database = mongoClient.GetDatabase("BlazorAppDb");
        _articlesCollection = database.GetCollection<Article>("articles");
    }

    // остальные методы без изменений
    public async Task AddArticleAsync(Article article)
    {
        await _articlesCollection.InsertOneAsync(article);
    }

    public async Task<List<Article>> GetArticlesAsync()
    {
        return await _articlesCollection.Find(_ => true).ToListAsync();
    }

    public async Task<long> GetArticlesCountAsync()
    {
        return await _articlesCollection.CountDocumentsAsync(_ => true);
    }
}
