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

namespace ClassAppDL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ClassDatabase")]
	public partial class ClassDatabaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public ClassDatabaseDataContext() : 
				base(global::ClassAppDL.Properties.Settings.Default.ClassDatabaseConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public ClassDatabaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClassDatabaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClassDatabaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClassDatabaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetPerson")]
		public ISingleResult<GetPersonResult> GetPerson()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<GetPersonResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertPerson")]
		public int InsertPerson([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FullName", DbType="VarChar(10)")] string fullName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductName", DbType="VarChar(10)")] string productName, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Notes", DbType="NChar(50)")] string notes, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Purpose", DbType="NChar(20)")] string purpose, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductCategory", DbType="NChar(10)")] string productCategory, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ProductPrice", DbType="NChar(10)")] string productPrice)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fullName, productName, notes, purpose, productCategory, productPrice);
			return ((int)(result.ReturnValue));
		}
	}
	
	public partial class GetPersonResult
	{
		
		private int _PersonId;
		
		private string _FullName;
		
		private string _ProductName;
		
		private string _Notes;
		
		private string _Purpose;
		
		private string _ProductCategory;
		
		private string _ProductPrice;
		
		public GetPersonResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PersonId", DbType="Int NOT NULL")]
		public int PersonId
		{
			get
			{
				return this._PersonId;
			}
			set
			{
				if ((this._PersonId != value))
				{
					this._PersonId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FullName", DbType="VarChar(10)")]
		public string FullName
		{
			get
			{
				return this._FullName;
			}
			set
			{
				if ((this._FullName != value))
				{
					this._FullName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="VarChar(10)")]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this._ProductName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(50)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this._Notes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Purpose", DbType="VarChar(20)")]
		public string Purpose
		{
			get
			{
				return this._Purpose;
			}
			set
			{
				if ((this._Purpose != value))
				{
					this._Purpose = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductCategory", DbType="VarChar(10)")]
		public string ProductCategory
		{
			get
			{
				return this._ProductCategory;
			}
			set
			{
				if ((this._ProductCategory != value))
				{
					this._ProductCategory = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="VarChar(10)")]
		public string ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this._ProductPrice = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
