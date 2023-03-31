using Microsoft.AspNetCore.Mvc;

namespace Convertidor_Moneda.Controllers
{
    public class ConvertidorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string demoneda, string amoneda, double cantidadmoneda)
        { 
            string Dolar = "USD - Dolar estadounidense";
            string Peso = "DOP - Peso dominicano";
            string Euro = "EUR - Euro";
            double Resultado;

            if (demoneda == Dolar && amoneda == Peso) 
            {
                Resultado = cantidadmoneda * 55.1913;
                ViewBag.Resultado = Resultado;
            }
            else 
                if (demoneda == Peso && amoneda == Dolar)
                {
                    Resultado = cantidadmoneda * 0.0181137;
                    ViewBag.Resultado = Resultado;
            }

            if (demoneda == Euro && amoneda == Peso)
            {
                Resultado = cantidadmoneda * 58.9605;
                ViewBag.Resultado = Resultado;
            }
            else 
                if (demoneda == Peso && amoneda == Euro)
                {
                    Resultado = cantidadmoneda * 0.0169618;
                    ViewBag.Resultado = Resultado;
                }

            if (demoneda == Dolar && amoneda == Euro)
            {
                Resultado = cantidadmoneda * 0.936065;
                ViewBag.Resultado = Resultado;
            }
            else 
                if (demoneda == Euro && amoneda == Dolar)
                {
                    Resultado = cantidadmoneda * 1.06804;
                    ViewBag.Resultado = Resultado;
            }

            return View(); 
        }
    }
}
