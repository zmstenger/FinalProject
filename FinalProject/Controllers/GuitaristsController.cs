using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;
namespace FinalProject.Controllers;
public class GuitaristsController : Controller
{
    public IActionResult Index()
    {
        var guitarists = new List<Guitarist>
        {
            new Guitarist { Name = "Eddie Van Halen", ImageUrl = "https://media-cldnry.s-nbcnews.com/image/upload/rockcms/2022-10/Eddie-Van-Halen-te-221006-d02f3c.jpg", },
            new Guitarist { Name = "Jimmy Page", ImageUrl = "https://cdn.mos.cms.futurecdn.net/avFgRsXrje3Dt2D3Gqh86L.jpg", },
            new Guitarist { Name = "Jimi Hendrix", ImageUrl = "https://guitar.com/wp-content/uploads/2020/05/Jimi-Hendrix-Credit-David-Redfern-Redferns@1400x1050.jpg",  },
            new Guitarist { Name = "Alex Lifeson", ImageUrl = "https://cdn.mos.cms.futurecdn.net/umtW3s9iSBSuQo4YEHAmaa.jpg", },
            new Guitarist { Name = "Brian May", ImageUrl = "https://blog.flametreepublishing.com/hubfs/maywide1.jpg",  },
                        new Guitarist { Name = "Eric Clapton", ImageUrl = "https://www.liveabout.com/thmb/N3lk3D4RVLPr0mOGXpB-WmwLVBo=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/3468297-58aca4c45f9b58a3c953e00e-8b29b132741a4caa9150c047a252bae5.jpg", },
            new Guitarist { Name = "David Gilmour", ImageUrl = "https://townsquare.media/site/295/files/2015/04/77879492.jpg?w=1200&h=0&zc=1&s=0&a=t&q=89",},
            new Guitarist { Name = "Billy Gibbons", ImageUrl = "https://cdn.mos.cms.futurecdn.net/RbjSu9e6dSQducQa5joE4C-1200-80.jpg", },
            new Guitarist { Name = "Tony Iommi", ImageUrl = "https://www.revolvermag.com/sites/default/files/media/images/article/tony-iommi-2008-gary_miller-getty-web-crop.jpg", },
                        new Guitarist { Name = "Slash", ImageUrl = "https://static.independent.co.uk/s3fs-public/thumbnails/image/2014/07/14/21/Slash-Rex.jpg", },




        };

        return View(guitarists);
    }
}
