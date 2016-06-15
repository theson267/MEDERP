using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_ROLE: BusinessObjectBase
	{

		#region InnerClass
		public enum NS_KPI_U_ROLEFields
		{
			RoleID,
			Name,
			Note
		}
		#endregion

		#region Data Members

			int _roleID;
			string _name;
			string _note;

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

		public string  Name
		{
			 get { return _name; }
			 set
			 {
				 if (_name != value)
				 {
					_name = value;
					 PropertyHasChanged("Name");
				 }
			 }
		}

		public string  Note
		{
			 get { return _note; }
			 set
			 {
				 if (_note != value)
				 {
					_note = value;
					 PropertyHasChanged("Note");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("RoleID", "RoleID"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Note", "Note",255));
		}

		#endregion

	}
}
