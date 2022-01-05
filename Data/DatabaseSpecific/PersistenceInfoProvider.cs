﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace EmployeeManagment.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitDepartmentEntityMappings();
			InitEmployeeEntityMappings();
		}

		/// <summary>Inits DepartmentEntity's mappings</summary>
		private void InitDepartmentEntityMappings()
		{
			this.AddElementMapping("DepartmentEntity", @"EmployeeManagmentDemo", @"dbo", "Department", 3, 0);
			this.AddElementFieldMapping("DepartmentEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DepartmentEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 1);
			this.AddElementFieldMapping("DepartmentEntity", "NameEnglish", "NameEnglish", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"EmployeeManagmentDemo", @"dbo", "Employee", 9, 0);
			this.AddElementFieldMapping("EmployeeEntity", "DateOfBirth", "DateOfBirth", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0);
			this.AddElementFieldMapping("EmployeeEntity", "DepartmentId", "DepartmentId", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeEntity", "Email", "Email", true, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("EmployeeEntity", "FirstName", "FirstName", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeeEntity", "Gender", "Gender", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("EmployeeEntity", "Id", "Id", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("EmployeeEntity", "IsActive", "IsActive", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("EmployeeEntity", "LastName", "LastName", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("EmployeeEntity", "PhotoPath", "PhotoPath", false, "NVarChar", 250, 0, 0, false, "", null, typeof(System.String), 8);
		}

	}
}
