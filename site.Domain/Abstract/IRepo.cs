
namespace site.Domain
{
	using System.Linq;
	using site.Data;

	public interface IRepo<T> where T : ItemData
	{
		IQueryable<T> GetAll();
	}
}
