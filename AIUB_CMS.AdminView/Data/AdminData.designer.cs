﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AIUB_CMS.AdminView.Data
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="AIUB-CMS Database")]
	public partial class AdminDataDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTest_AdminTable(Test_AdminTable instance);
    partial void UpdateTest_AdminTable(Test_AdminTable instance);
    partial void DeleteTest_AdminTable(Test_AdminTable instance);
    partial void InsertTest_StudentTable(Test_StudentTable instance);
    partial void UpdateTest_StudentTable(Test_StudentTable instance);
    partial void DeleteTest_StudentTable(Test_StudentTable instance);
    partial void InsertTest_FacultyTable(Test_FacultyTable instance);
    partial void UpdateTest_FacultyTable(Test_FacultyTable instance);
    partial void DeleteTest_FacultyTable(Test_FacultyTable instance);
    #endregion
		
		public AdminDataDataContext() : 
				base(global::AIUB_CMS.AdminView.Properties.Settings.Default.AIUB_CMS_DatabaseConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public AdminDataDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdminDataDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdminDataDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public AdminDataDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Test_AdminTable> Test_AdminTables
		{
			get
			{
				return this.GetTable<Test_AdminTable>();
			}
		}
		
		public System.Data.Linq.Table<Test_StudentTable> Test_StudentTables
		{
			get
			{
				return this.GetTable<Test_StudentTable>();
			}
		}
		
		public System.Data.Linq.Table<DepartmentTable> DepartmentTables
		{
			get
			{
				return this.GetTable<DepartmentTable>();
			}
		}
		
		public System.Data.Linq.Table<Test_FacultyTable> Test_FacultyTables
		{
			get
			{
				return this.GetTable<Test_FacultyTable>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_AdminTable")]
	public partial class Test_AdminTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ID;
		
		private string _Name;
		
		private string _Password;
		
		private string _FatherName;
		
		private string _MotherName;
		
		private string _Phone;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _Gender;
		
		private System.Nullable<int> _BloodGroup;
		
		private string _Email;
		
		private string _ImageDirectory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnFatherNameChanging(string value);
    partial void OnFatherNameChanged();
    partial void OnMotherNameChanging(string value);
    partial void OnMotherNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnGenderChanging(System.Nullable<int> value);
    partial void OnGenderChanged();
    partial void OnBloodGroupChanging(System.Nullable<int> value);
    partial void OnBloodGroupChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnImageDirectoryChanging(string value);
    partial void OnImageDirectoryChanged();
    #endregion
		
		public Test_AdminTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="NVarChar(50)")]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this.OnFatherNameChanging(value);
					this.SendPropertyChanging();
					this._FatherName = value;
					this.SendPropertyChanged("FatherName");
					this.OnFatherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="NVarChar(50)")]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this.OnMotherNameChanging(value);
					this.SendPropertyChanging();
					this._MotherName = value;
					this.SendPropertyChanged("MotherName");
					this.OnMotherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodGroup", DbType="Int")]
		public System.Nullable<int> BloodGroup
		{
			get
			{
				return this._BloodGroup;
			}
			set
			{
				if ((this._BloodGroup != value))
				{
					this.OnBloodGroupChanging(value);
					this.SendPropertyChanging();
					this._BloodGroup = value;
					this.SendPropertyChanged("BloodGroup");
					this.OnBloodGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageDirectory", DbType="NVarChar(250)")]
		public string ImageDirectory
		{
			get
			{
				return this._ImageDirectory;
			}
			set
			{
				if ((this._ImageDirectory != value))
				{
					this.OnImageDirectoryChanging(value);
					this.SendPropertyChanging();
					this._ImageDirectory = value;
					this.SendPropertyChanged("ImageDirectory");
					this.OnImageDirectoryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_StudentTable")]
	public partial class Test_StudentTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _ID;
		
		private System.Nullable<double> _CGPA;
		
		private System.Nullable<int> _Credits;
		
		private System.Nullable<int> _Department;
		
		private string _FatherName;
		
		private string _MotherName;
		
		private string _Phone;
		
		private string _Email;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _Gender;
		
		private System.Nullable<int> _BloodGroup;
		
		private string _Password;
		
		private string _ImageDirectory;
		
		private string _MACAddress;
		
		private System.Nullable<int> _Nationality;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnCGPAChanging(System.Nullable<double> value);
    partial void OnCGPAChanged();
    partial void OnCreditsChanging(System.Nullable<int> value);
    partial void OnCreditsChanged();
    partial void OnDepartmentChanging(System.Nullable<int> value);
    partial void OnDepartmentChanged();
    partial void OnFatherNameChanging(string value);
    partial void OnFatherNameChanged();
    partial void OnMotherNameChanging(string value);
    partial void OnMotherNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnGenderChanging(System.Nullable<int> value);
    partial void OnGenderChanged();
    partial void OnBloodGroupChanging(System.Nullable<int> value);
    partial void OnBloodGroupChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnImageDirectoryChanging(string value);
    partial void OnImageDirectoryChanged();
    partial void OnMACAddressChanging(string value);
    partial void OnMACAddressChanged();
    partial void OnNationalityChanging(System.Nullable<int> value);
    partial void OnNationalityChanged();
    #endregion
		
		public Test_StudentTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CGPA", DbType="Float")]
		public System.Nullable<double> CGPA
		{
			get
			{
				return this._CGPA;
			}
			set
			{
				if ((this._CGPA != value))
				{
					this.OnCGPAChanging(value);
					this.SendPropertyChanging();
					this._CGPA = value;
					this.SendPropertyChanged("CGPA");
					this.OnCGPAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Credits", DbType="Int")]
		public System.Nullable<int> Credits
		{
			get
			{
				return this._Credits;
			}
			set
			{
				if ((this._Credits != value))
				{
					this.OnCreditsChanging(value);
					this.SendPropertyChanging();
					this._Credits = value;
					this.SendPropertyChanged("Credits");
					this.OnCreditsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="Int")]
		public System.Nullable<int> Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="NVarChar(50)")]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this.OnFatherNameChanging(value);
					this.SendPropertyChanging();
					this._FatherName = value;
					this.SendPropertyChanged("FatherName");
					this.OnFatherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="NVarChar(50)")]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this.OnMotherNameChanging(value);
					this.SendPropertyChanging();
					this._MotherName = value;
					this.SendPropertyChanged("MotherName");
					this.OnMotherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(20)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodGroup", DbType="Int")]
		public System.Nullable<int> BloodGroup
		{
			get
			{
				return this._BloodGroup;
			}
			set
			{
				if ((this._BloodGroup != value))
				{
					this.OnBloodGroupChanging(value);
					this.SendPropertyChanging();
					this._BloodGroup = value;
					this.SendPropertyChanged("BloodGroup");
					this.OnBloodGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageDirectory", DbType="NVarChar(250)")]
		public string ImageDirectory
		{
			get
			{
				return this._ImageDirectory;
			}
			set
			{
				if ((this._ImageDirectory != value))
				{
					this.OnImageDirectoryChanging(value);
					this.SendPropertyChanging();
					this._ImageDirectory = value;
					this.SendPropertyChanged("ImageDirectory");
					this.OnImageDirectoryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MACAddress", DbType="NVarChar(20)")]
		public string MACAddress
		{
			get
			{
				return this._MACAddress;
			}
			set
			{
				if ((this._MACAddress != value))
				{
					this.OnMACAddressChanging(value);
					this.SendPropertyChanging();
					this._MACAddress = value;
					this.SendPropertyChanged("MACAddress");
					this.OnMACAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nationality", DbType="Int")]
		public System.Nullable<int> Nationality
		{
			get
			{
				return this._Nationality;
			}
			set
			{
				if ((this._Nationality != value))
				{
					this.OnNationalityChanging(value);
					this.SendPropertyChanging();
					this._Nationality = value;
					this.SendPropertyChanged("Nationality");
					this.OnNationalityChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DepartmentTable")]
	public partial class DepartmentTable
	{
		
		private System.Nullable<int> _DepartmentID;
		
		private string _DepartmentName;
		
		public DepartmentTable()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentID", DbType="Int")]
		public System.Nullable<int> DepartmentID
		{
			get
			{
				return this._DepartmentID;
			}
			set
			{
				if ((this._DepartmentID != value))
				{
					this._DepartmentID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DepartmentName", DbType="NVarChar(50)")]
		public string DepartmentName
		{
			get
			{
				return this._DepartmentName;
			}
			set
			{
				if ((this._DepartmentName != value))
				{
					this._DepartmentName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Test_FacultyTable")]
	public partial class Test_FacultyTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _Name;
		
		private string _ID;
		
		private string _Password;
		
		private string _Email;
		
		private System.Nullable<int> _BloodGroup;
		
		private string _PhoneNumber;
		
		private System.Nullable<int> _Department;
		
		private System.Nullable<System.DateTime> _DOB;
		
		private System.Nullable<int> _Gender;
		
		private string _FatherName;
		
		private string _MotherName;
		
		private System.Nullable<int> _Nationality;
		
		private string _ImageDirectory;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnIDChanging(string value);
    partial void OnIDChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnBloodGroupChanging(System.Nullable<int> value);
    partial void OnBloodGroupChanged();
    partial void OnPhoneNumberChanging(string value);
    partial void OnPhoneNumberChanged();
    partial void OnDepartmentChanging(System.Nullable<int> value);
    partial void OnDepartmentChanged();
    partial void OnDOBChanging(System.Nullable<System.DateTime> value);
    partial void OnDOBChanged();
    partial void OnGenderChanging(System.Nullable<int> value);
    partial void OnGenderChanged();
    partial void OnFatherNameChanging(string value);
    partial void OnFatherNameChanged();
    partial void OnMotherNameChanging(string value);
    partial void OnMotherNameChanged();
    partial void OnNationalityChanging(System.Nullable<int> value);
    partial void OnNationalityChanged();
    partial void OnImageDirectoryChanging(string value);
    partial void OnImageDirectoryChanged();
    #endregion
		
		public Test_FacultyTable()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50)")]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(50)")]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BloodGroup", DbType="Int")]
		public System.Nullable<int> BloodGroup
		{
			get
			{
				return this._BloodGroup;
			}
			set
			{
				if ((this._BloodGroup != value))
				{
					this.OnBloodGroupChanging(value);
					this.SendPropertyChanging();
					this._BloodGroup = value;
					this.SendPropertyChanged("BloodGroup");
					this.OnBloodGroupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PhoneNumber", DbType="NVarChar(50)")]
		public string PhoneNumber
		{
			get
			{
				return this._PhoneNumber;
			}
			set
			{
				if ((this._PhoneNumber != value))
				{
					this.OnPhoneNumberChanging(value);
					this.SendPropertyChanging();
					this._PhoneNumber = value;
					this.SendPropertyChanged("PhoneNumber");
					this.OnPhoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Department", DbType="Int")]
		public System.Nullable<int> Department
		{
			get
			{
				return this._Department;
			}
			set
			{
				if ((this._Department != value))
				{
					this.OnDepartmentChanging(value);
					this.SendPropertyChanging();
					this._Department = value;
					this.SendPropertyChanged("Department");
					this.OnDepartmentChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOB", DbType="Date")]
		public System.Nullable<System.DateTime> DOB
		{
			get
			{
				return this._DOB;
			}
			set
			{
				if ((this._DOB != value))
				{
					this.OnDOBChanging(value);
					this.SendPropertyChanging();
					this._DOB = value;
					this.SendPropertyChanged("DOB");
					this.OnDOBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gender", DbType="Int")]
		public System.Nullable<int> Gender
		{
			get
			{
				return this._Gender;
			}
			set
			{
				if ((this._Gender != value))
				{
					this.OnGenderChanging(value);
					this.SendPropertyChanging();
					this._Gender = value;
					this.SendPropertyChanged("Gender");
					this.OnGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FatherName", DbType="NVarChar(50)")]
		public string FatherName
		{
			get
			{
				return this._FatherName;
			}
			set
			{
				if ((this._FatherName != value))
				{
					this.OnFatherNameChanging(value);
					this.SendPropertyChanging();
					this._FatherName = value;
					this.SendPropertyChanged("FatherName");
					this.OnFatherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MotherName", DbType="NVarChar(50)")]
		public string MotherName
		{
			get
			{
				return this._MotherName;
			}
			set
			{
				if ((this._MotherName != value))
				{
					this.OnMotherNameChanging(value);
					this.SendPropertyChanging();
					this._MotherName = value;
					this.SendPropertyChanged("MotherName");
					this.OnMotherNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nationality", DbType="Int")]
		public System.Nullable<int> Nationality
		{
			get
			{
				return this._Nationality;
			}
			set
			{
				if ((this._Nationality != value))
				{
					this.OnNationalityChanging(value);
					this.SendPropertyChanging();
					this._Nationality = value;
					this.SendPropertyChanged("Nationality");
					this.OnNationalityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ImageDirectory", DbType="NVarChar(250)")]
		public string ImageDirectory
		{
			get
			{
				return this._ImageDirectory;
			}
			set
			{
				if ((this._ImageDirectory != value))
				{
					this.OnImageDirectoryChanging(value);
					this.SendPropertyChanging();
					this._ImageDirectory = value;
					this.SendPropertyChanged("ImageDirectory");
					this.OnImageDirectoryChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
