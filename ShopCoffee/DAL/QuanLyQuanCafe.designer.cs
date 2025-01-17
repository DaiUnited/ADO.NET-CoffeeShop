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

namespace DAL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QuanLyQuanCafe")]
	public partial class QuanLyQuanCafeDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBan(Ban instance);
    partial void UpdateBan(Ban instance);
    partial void DeleteBan(Ban instance);
    partial void InsertChiTietHoaDon(ChiTietHoaDon instance);
    partial void UpdateChiTietHoaDon(ChiTietHoaDon instance);
    partial void DeleteChiTietHoaDon(ChiTietHoaDon instance);
    partial void InsertDoUong(DoUong instance);
    partial void UpdateDoUong(DoUong instance);
    partial void DeleteDoUong(DoUong instance);
    partial void InsertHoaDon(HoaDon instance);
    partial void UpdateHoaDon(HoaDon instance);
    partial void DeleteHoaDon(HoaDon instance);
    partial void InsertLoaiDoUong(LoaiDoUong instance);
    partial void UpdateLoaiDoUong(LoaiDoUong instance);
    partial void DeleteLoaiDoUong(LoaiDoUong instance);
    partial void InsertNhanVien(NhanVien instance);
    partial void UpdateNhanVien(NhanVien instance);
    partial void DeleteNhanVien(NhanVien instance);
    #endregion
		
		public QuanLyQuanCafeDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyQuanCafeDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyQuanCafeDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyQuanCafeDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ban> Bans
		{
			get
			{
				return this.GetTable<Ban>();
			}
		}
		
		public System.Data.Linq.Table<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this.GetTable<ChiTietHoaDon>();
			}
		}
		
		public System.Data.Linq.Table<DoUong> DoUongs
		{
			get
			{
				return this.GetTable<DoUong>();
			}
		}
		
		public System.Data.Linq.Table<HoaDon> HoaDons
		{
			get
			{
				return this.GetTable<HoaDon>();
			}
		}
		
		public System.Data.Linq.Table<LoaiDoUong> LoaiDoUongs
		{
			get
			{
				return this.GetTable<LoaiDoUong>();
			}
		}
		
		public System.Data.Linq.Table<NhanVien> NhanViens
		{
			get
			{
				return this.GetTable<NhanVien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ban")]
	public partial class Ban : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaBan;
		
		private string _TenBan;
		
		private string _TrangThai;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaBanChanging(string value);
    partial void OnMaBanChanged();
    partial void OnTenBanChanging(string value);
    partial void OnTenBanChanged();
    partial void OnTrangThaiChanging(string value);
    partial void OnTrangThaiChanged();
    #endregion
		
		public Ban()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBan", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaBan
		{
			get
			{
				return this._MaBan;
			}
			set
			{
				if ((this._MaBan != value))
				{
					this.OnMaBanChanging(value);
					this.SendPropertyChanging();
					this._MaBan = value;
					this.SendPropertyChanged("MaBan");
					this.OnMaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenBan", DbType="NVarChar(100)")]
		public string TenBan
		{
			get
			{
				return this._TenBan;
			}
			set
			{
				if ((this._TenBan != value))
				{
					this.OnTenBanChanging(value);
					this.SendPropertyChanging();
					this._TenBan = value;
					this.SendPropertyChanged("TenBan");
					this.OnTenBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="NVarChar(100)")]
		public string TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ban_HoaDon", Storage="_HoaDons", ThisKey="MaBan", OtherKey="MaBan")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Ban = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.Ban = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ChiTietHoaDon")]
	public partial class ChiTietHoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHoaDon;
		
		private string _MaDoUong;
		
		private System.Nullable<int> _SoLuong;
		
		private System.Nullable<double> _TongTien;
		
		private EntityRef<DoUong> _DoUong;
		
		private EntityRef<HoaDon> _HoaDon;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHoaDonChanging(int value);
    partial void OnMaHoaDonChanged();
    partial void OnMaDoUongChanging(string value);
    partial void OnMaDoUongChanged();
    partial void OnSoLuongChanging(System.Nullable<int> value);
    partial void OnSoLuongChanged();
    partial void OnTongTienChanging(System.Nullable<double> value);
    partial void OnTongTienChanged();
    #endregion
		
		public ChiTietHoaDon()
		{
			this._DoUong = default(EntityRef<DoUong>);
			this._HoaDon = default(EntityRef<HoaDon>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					if (this._HoaDon.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaHoaDonChanging(value);
					this.SendPropertyChanging();
					this._MaHoaDon = value;
					this.SendPropertyChanged("MaHoaDon");
					this.OnMaHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoUong", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDoUong
		{
			get
			{
				return this._MaDoUong;
			}
			set
			{
				if ((this._MaDoUong != value))
				{
					if (this._DoUong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDoUongChanging(value);
					this.SendPropertyChanging();
					this._MaDoUong = value;
					this.SendPropertyChanged("MaDoUong");
					this.OnMaDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoLuong", DbType="Int")]
		public System.Nullable<int> SoLuong
		{
			get
			{
				return this._SoLuong;
			}
			set
			{
				if ((this._SoLuong != value))
				{
					this.OnSoLuongChanging(value);
					this.SendPropertyChanging();
					this._SoLuong = value;
					this.SendPropertyChanged("SoLuong");
					this.OnSoLuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="Float")]
		public System.Nullable<double> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoUong_ChiTietHoaDon", Storage="_DoUong", ThisKey="MaDoUong", OtherKey="MaDoUong", IsForeignKey=true)]
		public DoUong DoUong
		{
			get
			{
				return this._DoUong.Entity;
			}
			set
			{
				DoUong previousValue = this._DoUong.Entity;
				if (((previousValue != value) 
							|| (this._DoUong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DoUong.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._DoUong.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._MaDoUong = value.MaDoUong;
					}
					else
					{
						this._MaDoUong = default(string);
					}
					this.SendPropertyChanged("DoUong");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTietHoaDon", Storage="_HoaDon", ThisKey="MaHoaDon", OtherKey="MaHoaDon", IsForeignKey=true)]
		public HoaDon HoaDon
		{
			get
			{
				return this._HoaDon.Entity;
			}
			set
			{
				HoaDon previousValue = this._HoaDon.Entity;
				if (((previousValue != value) 
							|| (this._HoaDon.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._HoaDon.Entity = null;
						previousValue.ChiTietHoaDons.Remove(this);
					}
					this._HoaDon.Entity = value;
					if ((value != null))
					{
						value.ChiTietHoaDons.Add(this);
						this._MaHoaDon = value.MaHoaDon;
					}
					else
					{
						this._MaHoaDon = default(int);
					}
					this.SendPropertyChanged("HoaDon");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DoUong")]
	public partial class DoUong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaDoUong;
		
		private string _TenDoUong;
		
		private System.Nullable<double> _GiaTien;
		
		private string _MaLoaiDoUong;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
		private EntityRef<LoaiDoUong> _LoaiDoUong;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDoUongChanging(string value);
    partial void OnMaDoUongChanged();
    partial void OnTenDoUongChanging(string value);
    partial void OnTenDoUongChanged();
    partial void OnGiaTienChanging(System.Nullable<double> value);
    partial void OnGiaTienChanged();
    partial void OnMaLoaiDoUongChanging(string value);
    partial void OnMaLoaiDoUongChanged();
    #endregion
		
		public DoUong()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			this._LoaiDoUong = default(EntityRef<LoaiDoUong>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDoUong", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaDoUong
		{
			get
			{
				return this._MaDoUong;
			}
			set
			{
				if ((this._MaDoUong != value))
				{
					this.OnMaDoUongChanging(value);
					this.SendPropertyChanging();
					this._MaDoUong = value;
					this.SendPropertyChanged("MaDoUong");
					this.OnMaDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDoUong", DbType="NVarChar(100)")]
		public string TenDoUong
		{
			get
			{
				return this._TenDoUong;
			}
			set
			{
				if ((this._TenDoUong != value))
				{
					this.OnTenDoUongChanging(value);
					this.SendPropertyChanging();
					this._TenDoUong = value;
					this.SendPropertyChanged("TenDoUong");
					this.OnTenDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiaTien", DbType="Float")]
		public System.Nullable<double> GiaTien
		{
			get
			{
				return this._GiaTien;
			}
			set
			{
				if ((this._GiaTien != value))
				{
					this.OnGiaTienChanging(value);
					this.SendPropertyChanging();
					this._GiaTien = value;
					this.SendPropertyChanged("GiaTien");
					this.OnGiaTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiDoUong", DbType="NVarChar(100)")]
		public string MaLoaiDoUong
		{
			get
			{
				return this._MaLoaiDoUong;
			}
			set
			{
				if ((this._MaLoaiDoUong != value))
				{
					if (this._LoaiDoUong.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaLoaiDoUongChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiDoUong = value;
					this.SendPropertyChanged("MaLoaiDoUong");
					this.OnMaLoaiDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DoUong_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="MaDoUong", OtherKey="MaDoUong")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiDoUong_DoUong", Storage="_LoaiDoUong", ThisKey="MaLoaiDoUong", OtherKey="MaLoaiDoUong", IsForeignKey=true)]
		public LoaiDoUong LoaiDoUong
		{
			get
			{
				return this._LoaiDoUong.Entity;
			}
			set
			{
				LoaiDoUong previousValue = this._LoaiDoUong.Entity;
				if (((previousValue != value) 
							|| (this._LoaiDoUong.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._LoaiDoUong.Entity = null;
						previousValue.DoUongs.Remove(this);
					}
					this._LoaiDoUong.Entity = value;
					if ((value != null))
					{
						value.DoUongs.Add(this);
						this._MaLoaiDoUong = value.MaLoaiDoUong;
					}
					else
					{
						this._MaLoaiDoUong = default(string);
					}
					this.SendPropertyChanged("LoaiDoUong");
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.DoUong = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.DoUong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.HoaDon")]
	public partial class HoaDon : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaHoaDon;
		
		private System.Nullable<System.DateTime> _NgayLap;
		
		private string _MaBan;
		
		private string _MaNhanVien;
		
		private System.Nullable<double> _ThanhTien;
		
		private string _TrangThai;
		
		private EntitySet<ChiTietHoaDon> _ChiTietHoaDons;
		
		private EntityRef<Ban> _Ban;
		
		private EntityRef<NhanVien> _NhanVien;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaHoaDonChanging(int value);
    partial void OnMaHoaDonChanged();
    partial void OnNgayLapChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayLapChanged();
    partial void OnMaBanChanging(string value);
    partial void OnMaBanChanged();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnThanhTienChanging(System.Nullable<double> value);
    partial void OnThanhTienChanged();
    partial void OnTrangThaiChanging(string value);
    partial void OnTrangThaiChanged();
    #endregion
		
		public HoaDon()
		{
			this._ChiTietHoaDons = new EntitySet<ChiTietHoaDon>(new Action<ChiTietHoaDon>(this.attach_ChiTietHoaDons), new Action<ChiTietHoaDon>(this.detach_ChiTietHoaDons));
			this._Ban = default(EntityRef<Ban>);
			this._NhanVien = default(EntityRef<NhanVien>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaHoaDon", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MaHoaDon
		{
			get
			{
				return this._MaHoaDon;
			}
			set
			{
				if ((this._MaHoaDon != value))
				{
					this.OnMaHoaDonChanging(value);
					this.SendPropertyChanging();
					this._MaHoaDon = value;
					this.SendPropertyChanged("MaHoaDon");
					this.OnMaHoaDonChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayLap", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayLap
		{
			get
			{
				return this._NgayLap;
			}
			set
			{
				if ((this._NgayLap != value))
				{
					this.OnNgayLapChanging(value);
					this.SendPropertyChanging();
					this._NgayLap = value;
					this.SendPropertyChanged("NgayLap");
					this.OnNgayLapChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaBan", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MaBan
		{
			get
			{
				return this._MaBan;
			}
			set
			{
				if ((this._MaBan != value))
				{
					if (this._Ban.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaBanChanging(value);
					this.SendPropertyChanging();
					this._MaBan = value;
					this.SendPropertyChanged("MaBan");
					this.OnMaBanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					if (this._NhanVien.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ThanhTien", DbType="Float")]
		public System.Nullable<double> ThanhTien
		{
			get
			{
				return this._ThanhTien;
			}
			set
			{
				if ((this._ThanhTien != value))
				{
					this.OnThanhTienChanging(value);
					this.SendPropertyChanging();
					this._ThanhTien = value;
					this.SendPropertyChanged("ThanhTien");
					this.OnThanhTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TrangThai", DbType="NVarChar(50)")]
		public string TrangThai
		{
			get
			{
				return this._TrangThai;
			}
			set
			{
				if ((this._TrangThai != value))
				{
					this.OnTrangThaiChanging(value);
					this.SendPropertyChanging();
					this._TrangThai = value;
					this.SendPropertyChanged("TrangThai");
					this.OnTrangThaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="HoaDon_ChiTietHoaDon", Storage="_ChiTietHoaDons", ThisKey="MaHoaDon", OtherKey="MaHoaDon")]
		public EntitySet<ChiTietHoaDon> ChiTietHoaDons
		{
			get
			{
				return this._ChiTietHoaDons;
			}
			set
			{
				this._ChiTietHoaDons.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ban_HoaDon", Storage="_Ban", ThisKey="MaBan", OtherKey="MaBan", IsForeignKey=true)]
		public Ban Ban
		{
			get
			{
				return this._Ban.Entity;
			}
			set
			{
				Ban previousValue = this._Ban.Entity;
				if (((previousValue != value) 
							|| (this._Ban.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ban.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._Ban.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaBan = value.MaBan;
					}
					else
					{
						this._MaBan = default(string);
					}
					this.SendPropertyChanged("Ban");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_NhanVien", ThisKey="MaNhanVien", OtherKey="MaNhanVien", IsForeignKey=true)]
		public NhanVien NhanVien
		{
			get
			{
				return this._NhanVien.Entity;
			}
			set
			{
				NhanVien previousValue = this._NhanVien.Entity;
				if (((previousValue != value) 
							|| (this._NhanVien.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._NhanVien.Entity = null;
						previousValue.HoaDons.Remove(this);
					}
					this._NhanVien.Entity = value;
					if ((value != null))
					{
						value.HoaDons.Add(this);
						this._MaNhanVien = value.MaNhanVien;
					}
					else
					{
						this._MaNhanVien = default(string);
					}
					this.SendPropertyChanged("NhanVien");
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
		
		private void attach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = this;
		}
		
		private void detach_ChiTietHoaDons(ChiTietHoaDon entity)
		{
			this.SendPropertyChanging();
			entity.HoaDon = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.LoaiDoUong")]
	public partial class LoaiDoUong : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaLoaiDoUong;
		
		private string _TenLoaiDoUong;
		
		private EntitySet<DoUong> _DoUongs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaLoaiDoUongChanging(string value);
    partial void OnMaLoaiDoUongChanged();
    partial void OnTenLoaiDoUongChanging(string value);
    partial void OnTenLoaiDoUongChanged();
    #endregion
		
		public LoaiDoUong()
		{
			this._DoUongs = new EntitySet<DoUong>(new Action<DoUong>(this.attach_DoUongs), new Action<DoUong>(this.detach_DoUongs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaLoaiDoUong", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaLoaiDoUong
		{
			get
			{
				return this._MaLoaiDoUong;
			}
			set
			{
				if ((this._MaLoaiDoUong != value))
				{
					this.OnMaLoaiDoUongChanging(value);
					this.SendPropertyChanging();
					this._MaLoaiDoUong = value;
					this.SendPropertyChanged("MaLoaiDoUong");
					this.OnMaLoaiDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenLoaiDoUong", DbType="NVarChar(100)")]
		public string TenLoaiDoUong
		{
			get
			{
				return this._TenLoaiDoUong;
			}
			set
			{
				if ((this._TenLoaiDoUong != value))
				{
					this.OnTenLoaiDoUongChanging(value);
					this.SendPropertyChanging();
					this._TenLoaiDoUong = value;
					this.SendPropertyChanged("TenLoaiDoUong");
					this.OnTenLoaiDoUongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="LoaiDoUong_DoUong", Storage="_DoUongs", ThisKey="MaLoaiDoUong", OtherKey="MaLoaiDoUong")]
		public EntitySet<DoUong> DoUongs
		{
			get
			{
				return this._DoUongs;
			}
			set
			{
				this._DoUongs.Assign(value);
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
		
		private void attach_DoUongs(DoUong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiDoUong = this;
		}
		
		private void detach_DoUongs(DoUong entity)
		{
			this.SendPropertyChanging();
			entity.LoaiDoUong = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NhanVien")]
	public partial class NhanVien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNhanVien;
		
		private string _MatKhau;
		
		private string _TenNhanVien;
		
		private string _SoDienThoai;
		
		private System.Nullable<int> _NamSinh;
		
		private string _GioiTinh;
		
		private EntitySet<HoaDon> _HoaDons;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNhanVienChanging(string value);
    partial void OnMaNhanVienChanged();
    partial void OnMatKhauChanging(string value);
    partial void OnMatKhauChanged();
    partial void OnTenNhanVienChanging(string value);
    partial void OnTenNhanVienChanged();
    partial void OnSoDienThoaiChanging(string value);
    partial void OnSoDienThoaiChanged();
    partial void OnNamSinhChanging(System.Nullable<int> value);
    partial void OnNamSinhChanged();
    partial void OnGioiTinhChanging(string value);
    partial void OnGioiTinhChanged();
    #endregion
		
		public NhanVien()
		{
			this._HoaDons = new EntitySet<HoaDon>(new Action<HoaDon>(this.attach_HoaDons), new Action<HoaDon>(this.detach_HoaDons));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNhanVien", DbType="NVarChar(100) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNhanVien
		{
			get
			{
				return this._MaNhanVien;
			}
			set
			{
				if ((this._MaNhanVien != value))
				{
					this.OnMaNhanVienChanging(value);
					this.SendPropertyChanging();
					this._MaNhanVien = value;
					this.SendPropertyChanged("MaNhanVien");
					this.OnMaNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MatKhau", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MatKhau
		{
			get
			{
				return this._MatKhau;
			}
			set
			{
				if ((this._MatKhau != value))
				{
					this.OnMatKhauChanging(value);
					this.SendPropertyChanging();
					this._MatKhau = value;
					this.SendPropertyChanged("MatKhau");
					this.OnMatKhauChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNhanVien", DbType="NVarChar(100)")]
		public string TenNhanVien
		{
			get
			{
				return this._TenNhanVien;
			}
			set
			{
				if ((this._TenNhanVien != value))
				{
					this.OnTenNhanVienChanging(value);
					this.SendPropertyChanging();
					this._TenNhanVien = value;
					this.SendPropertyChanged("TenNhanVien");
					this.OnTenNhanVienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoDienThoai", DbType="NVarChar(10)")]
		public string SoDienThoai
		{
			get
			{
				return this._SoDienThoai;
			}
			set
			{
				if ((this._SoDienThoai != value))
				{
					this.OnSoDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._SoDienThoai = value;
					this.SendPropertyChanged("SoDienThoai");
					this.OnSoDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NamSinh", DbType="Int")]
		public System.Nullable<int> NamSinh
		{
			get
			{
				return this._NamSinh;
			}
			set
			{
				if ((this._NamSinh != value))
				{
					this.OnNamSinhChanging(value);
					this.SendPropertyChanging();
					this._NamSinh = value;
					this.SendPropertyChanged("NamSinh");
					this.OnNamSinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GioiTinh", DbType="NVarChar(10)")]
		public string GioiTinh
		{
			get
			{
				return this._GioiTinh;
			}
			set
			{
				if ((this._GioiTinh != value))
				{
					this.OnGioiTinhChanging(value);
					this.SendPropertyChanging();
					this._GioiTinh = value;
					this.SendPropertyChanged("GioiTinh");
					this.OnGioiTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="NhanVien_HoaDon", Storage="_HoaDons", ThisKey="MaNhanVien", OtherKey="MaNhanVien")]
		public EntitySet<HoaDon> HoaDons
		{
			get
			{
				return this._HoaDons;
			}
			set
			{
				this._HoaDons.Assign(value);
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
		
		private void attach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = this;
		}
		
		private void detach_HoaDons(HoaDon entity)
		{
			this.SendPropertyChanging();
			entity.NhanVien = null;
		}
	}
}
#pragma warning restore 1591
