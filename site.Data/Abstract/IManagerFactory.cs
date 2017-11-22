namespace site.Data
{
	public interface IManagerFactory<IEntity> where IEntity : ItemData
	{
		IManager<IEntity> GetManager();
	}
}
