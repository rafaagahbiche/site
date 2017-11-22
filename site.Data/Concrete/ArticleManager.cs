namespace site.Data
{
	using System;
	using System.Linq;

	public class ArticleManager: Manager<ArticleData>, IManager<ArticleData>
	{
		public ArticleManager(IDataContext _context) 
			: base(_context)
		{
		}

		public IQueryable<ArticleData> GetAll()
		{
			return (from article in context.DataXml
					.Element("data")
					.Element("articles")
					.Descendants("article")
					select new ArticleData
					{
						Id = article.Attribute("id") != null 
							? Convert.ToInt32(article.Attribute("id").Value) : -1,
						Title = article.Element("title") != null 
							? article.Element("title").Value : string.Empty,
						ShortDescription = article.Element("shortdescription") != null
							? article.Element("shortdescription").Value : string.Empty,
						LongDescription = article.Element("longdescription") != null
							? article.Element("longdescription").Value : string.Empty,
						DemoLink = article.Element("demo") != null
							? article.Element("demo").Value : string.Empty,
						BigIconLink = article.Element("bigicon") != null
							? article.Element("bigicon").Value : string.Empty,
						SmallIconLink = article.Element("smallicon") != null
							? article.Element("smallicon").Value : string.Empty
					}).AsQueryable();
		}
	}
}
