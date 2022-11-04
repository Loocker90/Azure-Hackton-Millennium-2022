using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using WebApi.Models;

using AllowAnonymousAttribute = Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class PromotionsController : Controller
    {
        // GET: PromotionsController
        // return coordinates in Decimal degrees (DD):
        [Microsoft.AspNetCore.Mvc.HttpGet("{cif}")]
        [ProducesResponseType(typeof(Promotion), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public ActionResult Index([FromRoute] string cif)
        {
            var promotion = new Promotion()
            {
                CustomerName = "jc", // shoed by grab from db
                Details = new PromotionDetail()
                {
                    BasicInfo = "This is the promotion of today some boots !",
                    ItemCoordinates = new Coordinates
                    (
                      latitude:  52.231010, 
                      longitude: 21.006739
                    ),
                    ItemUrl = "https://www.pngfind.com/pngs/m/587-5870909_free-reebok-png-reebok-transparent-png.png",
                    LogoUrl = "https://searchlogovector.com/wp-content/uploads/2020/03/reebok-logo-vector.png",
                    PromoId = 1
                }
            };
            return Ok(promotion);
        }
    }
}
