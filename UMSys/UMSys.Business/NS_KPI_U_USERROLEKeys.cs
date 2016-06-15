using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_USERROLEKeys
	{

		#region Data Members

		int _roleID;
		int _userID;

		#endregion

		#region Constructor

		public NS_KPI_U_USERROLEKeys(int roleID, int userID)
		{
			 _roleID = roleID; 
			 _userID = userID; 
		}

		#endregion

		#region Properties

		public int  RoleID
		{
			 get { return _roleID; }
		}
		public int  UserID
		{
			 get { return _userID; }
		}

		#endregion

	}
}
