using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_ROLEITEM: BusinessObjectBase
	{

		#region InnerClass
		public enum NS_KPI_U_ROLEITEMFields
		{
			ItemID,
			RoleID,
			IsReadonly,
			IsFullControl
		}
		#endregion

		#region Data Members

			int _itemID;
			int _roleID;
			bool? _isReadonly;
			bool? _isFullControl;

		#endregion

		#region Properties

		public int  ItemID
		{
			 get { return _itemID; }
			 set
			 {
				 if (_itemID != value)
				 {
					_itemID = value;
					 PropertyHasChanged("ItemID");
				 }
			 }
		}

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

		public bool?  IsReadonly
		{
			 get { return _isReadonly; }
			 set
			 {
				 if (_isReadonly != value)
				 {
					_isReadonly = value;
					 PropertyHasChanged("IsReadonly");
				 }
			 }
		}

		public bool?  IsFullControl
		{
			 get { return _isFullControl; }
			 set
			 {
				 if (_isFullControl != value)
				 {
					_isFullControl = value;
					 PropertyHasChanged("IsFullControl");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ItemID", "ItemID"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("RoleID", "RoleID"));
		}

		#endregion

	}
}
