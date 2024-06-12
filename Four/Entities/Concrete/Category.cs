using System;
using Entities.Abstract;

namespace Entities.Concrete
	//çıplak sınıf kalmasın kuralı sınıflar inheritance almıyorsa ilerde sıkıntı olabilr.
{
	public class Category:IEntity
	{
		public int CategoryId { get; set; }

		public string CategoryName { get; set; }
	}
}

