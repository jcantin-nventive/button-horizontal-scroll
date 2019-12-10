using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScrollButtons
{
	public class MyViewModel
	{
		public IEnumerable<string> MyItems => Enumerable.Range(1, 5).Select(nb => $"Item #{nb}");
	}
}
