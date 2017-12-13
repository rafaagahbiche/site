
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
				DemoLink = articleViewModel.DemoLink,
				GitLink = articleViewModel.GitLink,
				Technos = articleViewModel.Technos
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
				articleViewModel.GitLink = article.GitLink;
				articleViewModel.Technos = article.Technos;
			}

			return articleViewModel;
		}

		public static string FriendlyTitle(this string title)
		{
			if (!string.IsNullOrEmpty(title))
			{
				title = title.Trim().Replace(" ", "-").Replace("'", "-");
			}

			return title;
		}
	}
}
