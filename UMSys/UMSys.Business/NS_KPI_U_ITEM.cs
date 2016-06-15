using System;
using System.Collections.Generic;
using System.Text;
namespace UMSys.BusinessLayer
{
	public class NS_KPI_U_ITEM: BusinessObjectBase
	{

		#region InnerClass
		public enum NS_KPI_U_ITEMFields
		{
			ItemID,
			Name,
			Alias,
			Item_Title,
			Form_Namespace,
			IsFunction,
			IsDialog,
			Activate,
			ParrentId,
			Type,
			XML_File,
			Note,
			Order
		}
		#endregion

		#region Data Members

			int _itemID;
			string _name;
			string _alias;
			string _item_Title;
			string _form_Namespace;
			bool? _isFunction;
			bool? _isDialog;
			bool? _activate;
			int? _parrentId;
			string _type;
			string _xML_File;
			string _note;
			int? _order;

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

		public string  Alias
		{
			 get { return _alias; }
			 set
			 {
				 if (_alias != value)
				 {
					_alias = value;
					 PropertyHasChanged("Alias");
				 }
			 }
		}

		public string  Item_Title
		{
			 get { return _item_Title; }
			 set
			 {
				 if (_item_Title != value)
				 {
					_item_Title = value;
					 PropertyHasChanged("Item_Title");
				 }
			 }
		}

		public string  Form_Namespace
		{
			 get { return _form_Namespace; }
			 set
			 {
				 if (_form_Namespace != value)
				 {
					_form_Namespace = value;
					 PropertyHasChanged("Form_Namespace");
				 }
			 }
		}

		public bool?  IsFunction
		{
			 get { return _isFunction; }
			 set
			 {
				 if (_isFunction != value)
				 {
					_isFunction = value;
					 PropertyHasChanged("IsFunction");
				 }
			 }
		}

		public bool?  IsDialog
		{
			 get { return _isDialog; }
			 set
			 {
				 if (_isDialog != value)
				 {
					_isDialog = value;
					 PropertyHasChanged("IsDialog");
				 }
			 }
		}

		public bool?  Activate
		{
			 get { return _activate; }
			 set
			 {
				 if (_activate != value)
				 {
					_activate = value;
					 PropertyHasChanged("Activate");
				 }
			 }
		}

		public int?  ParrentId
		{
			 get { return _parrentId; }
			 set
			 {
				 if (_parrentId != value)
				 {
					_parrentId = value;
					 PropertyHasChanged("ParrentId");
				 }
			 }
		}

		public string  Type
		{
			 get { return _type; }
			 set
			 {
				 if (_type != value)
				 {
					_type = value;
					 PropertyHasChanged("Type");
				 }
			 }
		}

		public string  XML_File
		{
			 get { return _xML_File; }
			 set
			 {
				 if (_xML_File != value)
				 {
					_xML_File = value;
					 PropertyHasChanged("XML_File");
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

		public int?  Order
		{
			 get { return _order; }
			 set
			 {
				 if (_order != value)
				 {
					_order = value;
					 PropertyHasChanged("Order");
				 }
			 }
		}


		#endregion

		#region Validation

		internal override void AddValidationRules()
		{
			ValidationRules.AddRules(new Validation.ValidateRuleNotNull("ItemID", "ItemID"));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Name", "Name",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Alias", "Alias",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Item_Title", "Item_Title",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Form_Namespace", "Form_Namespace",200));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Type", "Type",50));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("XML_File", "XML_File",100));
			ValidationRules.AddRules(new Validation.ValidateRuleStringMaxLength("Note", "Note",200));
		}

		#endregion

	}
}
