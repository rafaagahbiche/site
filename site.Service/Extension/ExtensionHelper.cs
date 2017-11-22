
namespace site.Service
{
	using Data;

	public static class ExtensionHelper
	{
		public static ArticleData GetDataModel(this ArticleViewModel articleViewModel)
		{
			var articleData = new ArticleData()
			{
				ShortDescription = articleViewModel.ShortDescription,
				LongDescription = articleViewModel.LongDescription,
				Id = articleViewModel.Id,
				Title = articleViewModel.Title,
				BigIconLink = articleViewModel.BigIconLink,
				SmallIconLink = articleViewModel.SmallIconLink,
				DemoLink = articleViewModel.DemoLink
			};

			return articleData;
		}

		public static ArticleViewModel GetViewModel(this ArticleData article)
		{
			var articleViewModel = new ArticleViewModel();
			if (article != null)
			{
				articleViewModel.Id = article.Id;
				articleViewModel.Title = article.Title;
				articleViewModel.ShortDescription = article.ShortDescription;
				articleViewModel.LongDescription = article.LongDescription;
				articleViewModel.DemoLink = article.DemoLink;
				articleViewModel.BigIconLink = article.BigIconLink;
				articleViewModel.SmallIconLink = article.SmallIconLink;
			}

			return articleViewModel;
		}
	}
}
