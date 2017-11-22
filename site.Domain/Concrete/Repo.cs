

namespace site.Domain
{
	using Data;
	using System.Linq;

	public class Repo<T> : IRepo<T> where T : ItemData
	{
		protected readonly IManager<T> manager;

		public Repo(IManagerFactory<T> managerFactory)
		{
			this.manager = managerFactory.GetManager();
		}


		public IQueryable<T> GetAll()
		{
			return manager.GetAll();
		}
	}
}
