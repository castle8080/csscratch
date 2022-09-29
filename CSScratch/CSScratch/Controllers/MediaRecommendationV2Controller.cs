using CSScratch.Model.MediaV2;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;

namespace CSScratch.Controllers
{


    [ApiController]
    public class MediaRecommendationV2Controller
    {

        private static ImmutableArray<Recommendation> mediaItems = ImmutableArray.Create(new Recommendation[] {
            new Recommendation(new MusicAlbum(
                "Pink Floyd - Animals",
                "Animals is the tenth studio album by the English rock band Pink Floyd, released on 21 January 1977.",
                "Pink Floyd",
                1977,
                "https://www.amazon.com/Animals-Pink-Floyd/dp/B004ZN9UZO"
            )),
            new Recommendation(new MusicAlbum(
                "Public Enemy - It Takes a Nation of Millions to Hold Us Back",
                "It Takes a Nation of Millions to Hold Us Back is the second studio album by American hip hop group Public Enemy, released on June 28, 1988.",
                "Public Enemy",
                1988,
                "https://www.amazon.com/music/player/albums/B002PMC8ME"
            )),
            new Recommendation(new YouTubeVideo(
                "The Quantum Experiment that Broke Reality",
                "The double slit experiment radically changed the way we understand reality.",
                "https://youtu.be/p-MNSLsjjdo",
                6369773
            )),
            new Recommendation(new YouTubeVideo(
                "Laniakea: Our home supercluster",
                "Superclusters – regions of space that are densely packed with galaxies – are the biggest structures in the Universe.",
                "https://youtu.be/rENyyRwxpHo",
                7749302
            )),
            new Recommendation(new OnlineArticle(
                "Records (C# reference)",
                "Beginning with C# 9, you use the record keyword to define a reference type that provides built-in functionality for encapsulating data.",
                "https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record"
            ))
        });


        [HttpGet]
        [Route("/api/v2/recommendations")]
        [Route("/api/recommendations")]
        public IList<Recommendation> List()
        {
            return mediaItems;
        }

        [HttpPost]
        [Route("/api/v2/recommendations")]
        [Route("/api/recommendations")]
        public Recommendation Add([FromBody] Recommendation recommendation)
        {
            return recommendation;
        }


    }
}
