using System.Collections.Generic;

namespace site.Service
{
	public interface IArticleService
	{
		IEnumerable<ArticleViewModel> GetAll();
		ArticleViewModel Get(int id);
		ArticleViewModel Get(string title);
		ArticlesGlobe GetArticlesGlobe();
	}
}
