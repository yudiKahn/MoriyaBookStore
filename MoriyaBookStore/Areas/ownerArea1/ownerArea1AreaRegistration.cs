using System.Web.Mvc;

namespace MoriyaBookStore.Areas.ownerArea1
{
    public class ownerArea1AreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ownerArea1";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ownerArea1_default",
                "ownerArea1/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}