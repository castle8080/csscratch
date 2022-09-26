using CSScratch.Model.Media;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Immutable;
using static System.Net.WebRequestMethods;

namespace CSScratch.Controllers
{

    [ApiController]
    public class MediaRecommendationController : Controller
    {
        private static ImmutableArray<MediaItem> mediaItems = ImmutableArray.Create(new MediaItem[] {
            new MusicAlbum(
                "Pink Floyd - Animals",
                "Animals is the tenth studio album by the English rock band Pink Floyd, released on 21 January 1977.",
                "Pink Floyd",
                1977,
                "https://www.amazon.com/Animals-Pink-Floyd/dp/B004ZN9UZO"
            ),
            new MusicAlbum(
                "Public Enemy - It Takes a Nation of Millions to Hold Us Back",
                "It Takes a Nation of Millions to Hold Us Back is the second studio album by American hip hop group Public Enemy, released on June 28, 1988.",
                "Public Enemy",
                1988,
                "https://www.amazon.com/music/player/albums/B002PMC8ME"
            ),
            new YouTubeVideo(
                "The Quantum Experiment that Broke Reality",
                "The double slit experiment radically changed the way we understand reality.",
                "https://youtu.be/p-MNSLsjjdo",
                6369773
            ),
            new YouTubeVideo(
                "Laniakea: Our home supercluster",
                "Superclusters – regions of space that are densely packed with galaxies – are the biggest structures in the Universe.",
                "https://youtu.be/rENyyRwxpHo",
                7749302
            ),
            new OnlineArticle(
                "Records (C# reference)",
                "Beginning with C# 9, you use the record keyword to define a reference type that provides built-in functionality for encapsulating data.",
                "https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record"
            )
        });


        [HttpGet]
        [Route("/recommendations")]
        public IList<MediaItem> List()
        {
            return mediaItems;
        }

        [HttpPost]
        [Route("/recommendations")]
        public MediaItem Add([FromBody] MediaItem recommendation)
        {
            return recommendation;
        }
    }
}
