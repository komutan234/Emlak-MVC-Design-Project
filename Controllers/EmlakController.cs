using Microsoft.AspNetCore.Mvc;
public class EmlakController:Controller
{
    public IActionResult Emlaklar()
    {
        var emlak=new EmlakModel
        {
            etur="Daire",
            byer="Daire"
        };
        ViewData["eturu"]=emlak;
        ViewData["byeri"]=emlak;
        return View();
    }
}