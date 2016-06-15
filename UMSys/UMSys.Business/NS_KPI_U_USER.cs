using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_USER: BusinessObjectBase
	{

		#region InnerClass
		public enum NS_KPI_U_USERFields
		{
			UserID,
			UserName,
			Password,
			FullName,
			Act,
			Note
		}
		#endregion

		#region Data Members

			int _userID;
			string _userName;
			string _password;
			string _fullName;
			bool? _act;
			string _note;

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

		public string  UserName
		{
			 get { return _userName; }
			 set
			 {
				 if (_userName != value)
				 {
					_userName = value;
					 PropertyHasChanged("UserName");
				 }
			 }
		}

		public string  Password
		{
			 get { return _password; }
			 set
			 {
				 if (_password != value)
				 {
					_password = value;
					 PropertyHasChanged("Password");
				 }
			 }
		}

		public string  FullName
		{
			 get { return _fullName; }
			 set
			 {
				 if (_fullName != value)
				 {
					_fullName = value;
					 PropertyHasChanged("FullName");
				 }
			 }
		}

		public bool?  Act
		{
			 get { return _act; }
			 set
			 {
				 if (_act != value)
				 {
					_act = value;
					 PropertyHasChanged("Act");
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
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserID", "UserID"));
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("UserName", "UserName"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("UserName", "UserName",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Password", "Password",30));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("FullName", "FullName",150));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Note", "Note",255));
		}

		#endregion

	}
}
