using System.Linq;

namespace site.Data
{
	public interface IManager<IEntity> where IEntity : ItemData
	{
		IQueryable<IEntity> GetAll();
	}
}
