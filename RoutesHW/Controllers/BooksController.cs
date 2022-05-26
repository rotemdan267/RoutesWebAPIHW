using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutesHW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [Route("{id:int:min(6)}")]
        public string GetByIdINT(int id)
        {
            return "book INT > 5 " + id;
        }


        [Route("{id:regex(book(z|b)oom)}")]
        public string GetByIdREG(string id)
        {
            return "book REGEX " + id;
        }

        //[Route("{id:alpha}")]
        //public string GetByIdAlpha(string id)
        //{
        //    return "book Letters-Only " + id;
        //}
    }
}
