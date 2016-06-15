using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_ROLEITEMKeys
	{

		#region Data Members

		int _itemID;
		int _roleID;

		#endregion

		#region Constructor

		public NS_KPI_U_ROLEITEMKeys(int itemID, int roleID)
		{
			 _itemID = itemID; 
			 _roleID = roleID; 
		}

		#endregion

		#region Properties

		public int  ItemID
		{
			 get { return _itemID; }
		}
		public int  RoleID
		{
			 get { return _roleID; }
		}

		#endregion

	}
}
