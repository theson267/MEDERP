using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_USERROLE: BusinessObjectBase
	{

		#region InnerClass
		public enum NS_KPI_U_USERROLEFields
		{
			RoleID,
			UserID
		}
		#endregion

		#region Data Members

			int _roleID;
			int _userID;

		#endregion

		#region Properties

		public int  RoleID
		{
			 get { return _roleID; }
			 set
			 {
				 if (_roleID != value)
				 {
					_roleID = value;
					 PropertyHasChanged("RoleID");
				 }
			 }
		}

		public int  UserID
		{
			 get { return _userID; }
			 set
			 {
				 if (_userID != value)
				 {
					_userID = value;
					 PropertyHasChanged("UserID");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("RoleID", "RoleID"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserID", "UserID"));
		}

		#endregion

	}
}
