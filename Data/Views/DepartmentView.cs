﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.5.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace Views.DtoClasses
{ 
	/// <summary> DTO class which is derived from the entity 'Department'.</summary>
	[Serializable]
	[DataContract]
	public partial class DepartmentView
	{
		/// <summary>Gets or sets the Id field. Derived from Entity Model Field 'Department.Id'</summary>
		[DataMember]
		public System.Int32 Id { get; set; }
		/// <summary>Gets or sets the IsActive field. Derived from Entity Model Field 'Department.IsActive'</summary>
		[DataMember]
		public System.Boolean IsActive { get; set; }
		/// <summary>Gets or sets the NameEnglish field. Derived from Entity Model Field 'Department.NameEnglish'</summary>
		[DataMember]
		public System.String NameEnglish { get; set; }
	}

}




