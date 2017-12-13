
namespace site.Service
{
	using System.Collections.Generic;

	public class ArticlesGlobe
	{
		public int SelectedArticleId { get; set; }
		public IEnumerable<ArticleViewModel> Articles { get; set; }
	}
}
