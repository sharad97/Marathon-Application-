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

namespace WebApplication3.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Marathon")]
	public partial class RunnerDetailsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertrunner(runner instance);
    partial void Updaterunner(runner instance);
    partial void Deleterunner(runner instance);
    #endregion
		
		public RunnerDetailsDataContext() : 
				base(global::WebApplication3.Properties.Settings.Default.MarathonConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public RunnerDetailsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunnerDetailsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunnerDetailsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public RunnerDetailsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<runner> runners
		{
			get
			{
				return this.GetTable<runner>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.runner")]
	public partial class runner : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Nullable<double> _Age;
		
		private double _Bib;
		
		private string _City;
		
		private string _DivPl;
		
		private string _Name;
		
		private string _Overall;
		
		private string _Sex;
		
		private string _SexPl;
		
		private string _State;
		
		private string _Time;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAgeChanging(System.Nullable<double> value);
    partial void OnAgeChanged();
    partial void OnBibChanging(double value);
    partial void OnBibChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnDivPlChanging(string value);
    partial void OnDivPlChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnOverallChanging(string value);
    partial void OnOverallChanged();
    partial void OnSexChanging(string value);
    partial void OnSexChanged();
    partial void OnSexPlChanging(string value);
    partial void OnSexPlChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnTimeChanging(string value);
    partial void OnTimeChanged();
    #endregion
		
		public runner()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Age", DbType="Float")]
		public System.Nullable<double> Age
		{
			get
			{
				return this._Age;
			}
			set
			{
				if ((this._Age != value))
				{
					this.OnAgeChanging(value);
					this.SendPropertyChanging();
					this._Age = value;
					this.SendPropertyChanged("Age");
					this.OnAgeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bib", DbType="Float NOT NULL", IsPrimaryKey=true)]
		public double Bib
		{
			get
			{
				return this._Bib;
			}
			set
			{
				if ((this._Bib != value))
				{
					this.OnBibChanging(value);
					this.SendPropertyChanging();
					this._Bib = value;
					this.SendPropertyChanged("Bib");
					this.OnBibChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="NVarChar(255)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DivPl", DbType="NVarChar(255)")]
		public string DivPl
		{
			get
			{
				return this._DivPl;
			}
			set
			{
				if ((this._DivPl != value))
				{
					this.OnDivPlChanging(value);
					this.SendPropertyChanging();
					this._DivPl = value;
					this.SendPropertyChanged("DivPl");
					this.OnDivPlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(255)")]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Overall", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string Overall
		{
			get
			{
				return this._Overall;
			}
			set
			{
				if ((this._Overall != value))
				{
					this.OnOverallChanging(value);
					this.SendPropertyChanging();
					this._Overall = value;
					this.SendPropertyChanged("Overall");
					this.OnOverallChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sex", DbType="NVarChar(255)")]
		public string Sex
		{
			get
			{
				return this._Sex;
			}
			set
			{
				if ((this._Sex != value))
				{
					this.OnSexChanging(value);
					this.SendPropertyChanging();
					this._Sex = value;
					this.SendPropertyChanged("Sex");
					this.OnSexChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SexPl", DbType="NVarChar(255)")]
		public string SexPl
		{
			get
			{
				return this._SexPl;
			}
			set
			{
				if ((this._SexPl != value))
				{
					this.OnSexPlChanging(value);
					this.SendPropertyChanging();
					this._SexPl = value;
					this.SendPropertyChanged("SexPl");
					this.OnSexPlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="NVarChar(255)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="NVarChar(255)")]
		public string Time
		{
			get
			{
				return this._Time;
			}
			set
			{
				if ((this._Time != value))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._Time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
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
