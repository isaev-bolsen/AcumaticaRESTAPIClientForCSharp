using Acumatica.RESTClient.Model;
using System.Runtime.Serialization;

namespace Acumatica.Default_18_200_001.Model
{
	[DataContract]
	public partial class EmailChangeOrder : EntityAction<ChangeOrder>
	{
		public EmailChangeOrder(ChangeOrder entity) : base(entity)
		{ }
		public EmailChangeOrder() : base()
		{ }
	}
}