using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_USERKeys
	{

		#region Data Members

		int _userID;

		#endregion

		#region Constructor

		public NS_KPI_U_USERKeys(int userID)
		{
			 _userID = userID; 
		}

		#endregion

		#region Properties

		public int  UserID
		{
			 get { return _userID; }
		}

		#endregion

	}
}
