using System;
using System.Collections.Generic;
using oPOP.Core;

namespace POP.Touch
{
	public static class DummyData
	{
		public static List<Projects> GetData()
		{
			var data = new List<Projects> () {
				new Projects{ ProjectName = "+", ID = 0, IsActive = true, IsShared = false }

			};
			return data;
		}
	}
}

