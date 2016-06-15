using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_ROLEKeys
	{

		#region Data Members

		int _roleID;

		#endregion

		#region Constructor

		public NS_KPI_U_ROLEKeys(int roleID)
		{
			 _roleID = roleID; 
		}

		#endregion

		#region Properties

		public int  RoleID
		{
			 get { return _roleID; }
		}

		#endregion

	}
}
