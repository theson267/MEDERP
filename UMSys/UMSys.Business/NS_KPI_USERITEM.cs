using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_USERITEM: BusinessObjectBase
	{

		#region InnerClass
		public enum NS_KPI_USERITEMFields
		{
			UserID,
			ItemID,
			IsReadOnly,
			IsFullControl
		}
		#endregion

		#region Data Members

			int _userID;
			int _itemID;
			bool? _isReadOnly;
			bool? _isFullControl;

		#endregion

		#region Properties

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

		public bool?  IsReadOnly
		{
			 get { return _isReadOnly; }
			 set
			 {
				 if (_isReadOnly != value)
				 {
					_isReadOnly = value;
					 PropertyHasChanged("IsReadOnly");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserID", "UserID"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ItemID", "ItemID"));
		}

		#endregion

	}
}
