using System;

namespace oPOP.Core
{
	public class Projects : BusinessBaseEntity
	{
		public Projects ()
		{
		}

		//Properties
		public string ProjectName {
			get;
			set;
		}
		public string ProjectThumbnail {
			get;
			set;
		}

		public bool IsShared {
			get;
			set;
		}
		public bool IsActive {
			get;
			set;
		}
		public bool IsInTrialMode {
			get;
			set;
		}
		public bool IsCompleted {
			get;
			set;
		}
	}
}

