namespace site.Data
{
	public class Manager<IEntity>
		where IEntity : ItemData
	{
		protected IDataContext context;

		public Manager(IDataContext context)
		{
			this.context = context;
		}
	}
}
