using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_USERITEMKeys
	{

		#region Data Members

		int _userID;
		int _itemID;

		#endregion

		#region Constructor

		public NS_KPI_USERITEMKeys(int userID, int itemID)
		{
			 _userID = userID; 
			 _itemID = itemID; 
		}

		#endregion

		#region Properties

		public int  UserID
		{
			 get { return _userID; }
		}
		public int  ItemID
		{
			 get { return _itemID; }
		}

		#endregion

	}
}
