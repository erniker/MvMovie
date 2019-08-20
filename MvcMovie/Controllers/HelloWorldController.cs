using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        /// <summary>
        /// Método que devuelve un objeto view()
        /// http://localhost:xxxx/HelloWorld
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }



        /// <summary>
        /// Método de ejemplo para usarlo en un endpoint con paso de parámetros
        /// http://localhost:xxxx/HelloWorld/Welcome1?name=Rick&numtimes=4
        /// </summary>
        /// <param name="name"></param>
        /// <param name="numTimes"></param>
        /// <returns></returns>
        public string Welcome1(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($" Hola {name}, NumTimes es: {numTimes}");
        }
        /// <summary>
        /// Método de ejemplo para usarlo en un endpoint con paso de parámetros
        /// http://localhost:xxx/HelloWorld/Welcome2/3?name=Rick
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ID"></param>
        /// <returns></returns>
        public string Welcome2(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($" Hello {name}, ID: {ID}");
        }
    }
}




