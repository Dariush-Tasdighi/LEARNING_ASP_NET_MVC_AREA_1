namespace LEARNING_AREA.Areas.Administrator
{
	public class AdministratorAreaRegistration : System.Web.Mvc.AreaRegistration
	{
		public AdministratorAreaRegistration() : base()
		{
		}

		public override string AreaName
		{
			get
			{
				return "Administrator";
			}
		}

		public override void RegisterArea(System.Web.Mvc.AreaRegistrationContext context)
		{
			context.MapRoute(
				"Administrator_default",
				"Administrator/{controller}/{action}/{id}",
				new { action = "Index", id = System.Web.Mvc.UrlParameter.Optional }
			);
		}
	}
}
