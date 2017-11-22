using System.Xml.Linq;

namespace site.Data
{
	public interface IDataContext
	{
		XDocument DataXml { get; }
		void SaveFile();
	}
}
