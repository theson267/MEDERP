using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_ITEMKeys
	{

		#region Data Members

		int _itemID;

		#endregion

		#region Constructor

		public NS_KPI_U_ITEMKeys(int itemID)
		{
			 _itemID = itemID; 
		}

		#endregion

		#region Properties

		public int  ItemID
		{
			 get { return _itemID; }
		}

		#endregion

	}
}
