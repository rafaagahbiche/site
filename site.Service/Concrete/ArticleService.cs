namespace site.Service
{
	using Data;
	using Domain;
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class ArticleService: IArticleService
	{
		private readonly IRepo<ArticleData> articleRepo;

		public ArticleService(IRepo<ArticleData> articleRepo)
		{
			this.articleRepo = articleRepo;
		}

		public ArticleViewModel Get(string title)
		{
			ArticleViewModel article = null;
			var articleData = articleRepo.GetAll().FirstOrDefault(x => x.Title.Equals(title, StringComparison.InvariantCultureIgnoreCase));
			if (articleData != null)
			{
				article = GetArticle(articleData);
			}

			return article;
		}

		public ArticleViewModel Get(int id)
		{
			ArticleViewModel article = null;
			var articleData = articleRepo.GetAll().FirstOrDefault(x => x.Id.Equals(id));
			if(articleData != null)
			{
				article = GetArticle(articleData);
			}

			return article;
		}

		public IEnumerable<ArticleViewModel> GetAll()
		{
			foreach(var item in articleRepo.GetAll())
			{
				yield return item.GetViewModel();
			}
		}

		private ArticleViewModel GetArticle(ArticleData articleData)
		{
            ArticleViewModel article = null;
            if (articleData != null)
            {
                article = articleData.GetViewModel();
            }
        
            return article;
        }
	}
}
