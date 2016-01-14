using System;

namespace oPOP.Core
{
	public class ProjectAssets : BusinessBaseEntity
	{
		public ProjectAssets ()
		{
		}

		public string PrototypeImage {
			get;
			set;
		}

		public int ProjectID {
			get;
			set;
		}
	}
}

