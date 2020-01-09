﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;

namespace LLBLGenPro.OrmCookbook.TypedViewClasses
{
	/// <summary>Class which represents a row in the typed view 'EmployeeDetail'.</summary>
	/// <remarks>This class is a result class for a query, which is produced with the property <see cref="LLBLGenPro.OrmCookbook.FactoryClasses.QueryFactory.EmployeeDetail"/>. </remarks>
	[Serializable]
	public partial class EmployeeDetailRow 
	{
		partial void OnCreated();
		
		/// <summary>Initializes a new instance of the <see cref="EmployeeDetailRow"/> class.</summary>
		public EmployeeDetailRow()
		{
			OnCreated();
		}

		/// <summary>Gets or sets the CellPhone field.</summary>
		public System.String CellPhone { get; set; }
		/// <summary>Gets or sets the EmployeeClassificationKey field.</summary>
		public System.Int32 EmployeeClassificationKey { get; set; }
		/// <summary>Gets or sets the EmployeeClassificationName field.</summary>
		public System.String EmployeeClassificationName { get; set; }
		/// <summary>Gets or sets the EmployeeKey field.</summary>
		public System.Int32 EmployeeKey { get; set; }
		/// <summary>Gets or sets the FirstName field.</summary>
		public System.String FirstName { get; set; }
		/// <summary>Gets or sets the IsEmployee field.</summary>
		public System.Boolean IsEmployee { get; set; }
		/// <summary>Gets or sets the IsExempt field.</summary>
		public System.Boolean IsExempt { get; set; }
		/// <summary>Gets or sets the LastName field.</summary>
		public System.String LastName { get; set; }
		/// <summary>Gets or sets the MiddleName field.</summary>
		public System.String MiddleName { get; set; }
		/// <summary>Gets or sets the OfficePhone field.</summary>
		public System.String OfficePhone { get; set; }
		/// <summary>Gets or sets the Title field.</summary>
		public System.String Title { get; set; }
	}
}

