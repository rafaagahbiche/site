namespace site.Service
{
	public class ArticleViewModel: ItemViewModel
	{
		public string Title { get; set; }
		public string ShortDescription { get; set; }
		public string LongDescription { get; set; }
		public string DemoLink { get; set; }
		public string GitLink { get; set; }
		public string BigIconLink { get; set; }
		public string SmallIconLink { get; set; }
		public string[] Technos { get; set; }
	}
}
