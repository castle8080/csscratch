using Microsoft.Azure.Cosmos;
using Model.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DocDB.Serialize;
using Microsoft.Azure.Cosmos.Linq;

namespace DocDB
{
    public static class CosmosExtensions
    {
        public async static Task<List<T>> ToListAsync<T>(this FeedIterator<T> feed)
        {
            var items = new List<T>();
            while (feed.HasMoreResults)
            {
                var nextResult = await feed.ReadNextAsync();
                if (nextResult != null)
                {
                    items.AddRange(nextResult);
                }
            }
            return items;
        }
    }

    public class QueryCosmos
    {
        private CosmosClient dbClient;
        private Container container;

        public QueryCosmos()
        {
            this.dbClient = new CosmosClient(
                Environment.GetEnvironmentVariable("COSMOS_ENDPOINT"),
                Environment.GetEnvironmentVariable("COSMOS_KEY"),
                new CosmosClientOptions
                {
                    Serializer = new NewtonsoftCosmosSerializer(CreateNewtonsoftSerializer())
                }
            );

            this.container = dbClient.GetContainer("DigitalProcedure", "MediaItems");
        }

        public static JsonSerializer CreateNewtonsoftSerializer()
        {
            // Creates a serializer that can deserialize media items.
            var serializer = new JsonSerializer();
            serializer.Converters.Add(
                new SubTypeReader<MediaItem>.Builder()
                    .WithSubType<MusicAlbum>()
                    .WithSubType<OnlineArticle>()
                    .WithSubType<YouTubeVideo>()
                    .Build()
            );
            return serializer;
        }

        public async Task QueryMusicAlbums()
        {
            //
            // queries music albums from media items using a linq query.
            // this requires a condition on type to work.
            //
            var itemQ = container.GetItemLinqQueryable<MusicAlbum>();

            var items = await itemQ
                .Where(m => m.Type == "MusicAlbum")
                .Where(m => m.Artist == "Frank Zappa")
                .ToFeedIterator()
                .ToListAsync();

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public async Task QueryAllMediaItems()
        {
            //
            // Query through all media items.
            //
            var itemQ = container.GetItemLinqQueryable<MediaItem>();
            var items = await itemQ.ToFeedIterator().ToListAsync();

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public async Task QueryOnlineArticlesAsJson()
        {
            //
            // This example queries using SQL and returns JObjects.
            // This is a way to handle querying and processing with no concrete type
            // being defined.
            //
            var feedIter = container.GetItemQueryIterator<JObject>(@"
                select *
                from MediaItems m
                where m['type$'] = 'OnlineArticle'
            ");

            var items = await feedIter.ToListAsync();

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public async Task QueryDifferentTypes()
        {
            //
            // If you want to run a query which might return differen sub types
            // and use conditions on the subtype, you have to use sql.
            // I could not see how to do this with linq.
            //
            var feedIter = container.GetItemQueryIterator<MediaItem>(@"
                select *
                from MediaItems m
                where
                    (m['type$'] = 'OnlineArticle') or
                    (m['type$'] = 'MusicAlbum' and m['ReleaseYear'] >= 2000)
            ");

            var items = await feedIter.ToListAsync();

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        public async Task AddItems()
        {
            var response = await container.CreateItemAsync(new OnlineArticle(
                Guid.NewGuid().ToString(),
                "How does photosynthesis work?",
                "some weird article",
                "https://sciencing.com/how-does-photosynthesis-work-13714442.html"
            ));

            await container.CreateItemAsync(new MusicAlbum(
                Guid.NewGuid().ToString(),
                "Hot Rats",
                "Hot Rats is the second solo album by Frank Zappa, released in October 1969.",
                "Frank Zappa",
                1969,
                "https://www.amazon.com/dp/B00B2Z1FOW"
            ));

            await container.CreateItemAsync(new MusicAlbum(
                Guid.NewGuid().ToString(),
                "Toxicity",
                "Toxicity is the second studio album by Armenian-American heavy metal band System of a Down, released on September 4, 2001.",
                "System of a Down",
                2001,
                "https://www.amazon.com/dp/B001414XLQ"
            ));

            await container.CreateItemAsync(new YouTubeVideo(
                Guid.NewGuid().ToString(),
                "Object-Oriented Programming is Embarrassing: 4 Short Examples",
                "Object-Oriented Programming is Embarrassing: 4 Short Examples",
                "https://www.youtube.com/watch?v=IRTfhkiAqPw",
                1813914
            ));
        }

        public async static Task Run()
        {
            var qCosmos = new QueryCosmos();
            //qCosmos.TestSerialization();
            //await qCosmos.AddItems();

            Console.WriteLine("Query Music Albums:--------------------");
            await qCosmos.QueryMusicAlbums();

            Console.WriteLine("Query Media Items:--------------------");
            await qCosmos.QueryAllMediaItems();

            Console.WriteLine("Query online articles as json:--------------------");
            await qCosmos.QueryOnlineArticlesAsJson();

            Console.WriteLine("Query different types:--------------------");
            await qCosmos.QueryDifferentTypes();
        }
    }
}
