using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace KJL1.Models
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Customers", IdColumnName="Number")]
  public partial class Customer : Entity<int>
  {
    #region Fields
  
    [ValidateLength(0, 50)]
    private string _firstName;
    [ValidateLength(0, 50)]
    private string _lastName;
    private System.Nullable<bool> _active;
    [ValidateLength(0, 50)]
    private string _serviceLevel;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the FirstName entity attribute.</summary>
    public const string FirstNameField = "FirstName";
    /// <summary>Identifies the LastName entity attribute.</summary>
    public const string LastNameField = "LastName";
    /// <summary>Identifies the Active entity attribute.</summary>
    public const string ActiveField = "Active";
    /// <summary>Identifies the ServiceLevel entity attribute.</summary>
    public const string ServiceLevelField = "ServiceLevel";


    #endregion
    
    #region Relationships

    [ReverseAssociation("CustomerNumber")]
    private readonly EntityCollection<Order> _orders = new EntityCollection<Order>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Order> Orders
    {
      get { return Get(_orders); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string FirstName
    {
      get { return Get(ref _firstName, "FirstName"); }
      set { Set(ref _firstName, value, "FirstName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string LastName
    {
      get { return Get(ref _lastName, "LastName"); }
      set { Set(ref _lastName, value, "LastName"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<bool> Active
    {
      get { return Get(ref _active, "Active"); }
      set { Set(ref _active, value, "Active"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public string ServiceLevel
    {
      get { return Get(ref _serviceLevel, "ServiceLevel"); }
      set { Set(ref _serviceLevel, value, "ServiceLevel"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Orders")]
  public partial class Order : Entity<int>
  {
    #region Fields
  
    private System.Nullable<System.DateTime> _date;
    private System.Nullable<decimal> _totalAmount;
    [Column("CustomerNumber")]
    private System.Nullable<int> _customerNumberId;
    private System.Nullable<int> _productId;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Date entity attribute.</summary>
    public const string DateField = "Date";
    /// <summary>Identifies the TotalAmount entity attribute.</summary>
    public const string TotalAmountField = "TotalAmount";
    /// <summary>Identifies the CustomerNumberId entity attribute.</summary>
    public const string CustomerNumberIdField = "CustomerNumberId";
    /// <summary>Identifies the ProductId entity attribute.</summary>
    public const string ProductIdField = "ProductId";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Orders")]
    private readonly EntityHolder<Customer> _customerNumber = new EntityHolder<Customer>();
    [ReverseAssociation("Orders")]
    private readonly EntityHolder<Product> _product = new EntityHolder<Product>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public Customer CustomerNumber
    {
      get { return Get(_customerNumber); }
      set { Set(_customerNumber, value); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public Product Product
    {
      get { return Get(_product); }
      set { Set(_product, value); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> Date
    {
      get { return Get(ref _date, "Date"); }
      set { Set(ref _date, value, "Date"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> TotalAmount
    {
      get { return Get(ref _totalAmount, "TotalAmount"); }
      set { Set(ref _totalAmount, value, "TotalAmount"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="CustomerNumber" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> CustomerNumberId
    {
      get { return Get(ref _customerNumberId, "CustomerNumberId"); }
      set { Set(ref _customerNumberId, value, "CustomerNumberId"); }
    }

    /// <summary>Gets or sets the ID for the <see cref="Product" /> property.</summary>
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<int> ProductId
    {
      get { return Get(ref _productId, "ProductId"); }
      set { Set(ref _productId, value, "ProductId"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [Table("Products")]
  public partial class Product : Entity<int>
  {
    #region Fields
  
    [ValidateLength(0, 50)]
    private string _name;
    private System.Nullable<decimal> _cost;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Name entity attribute.</summary>
    public const string NameField = "Name";
    /// <summary>Identifies the Cost entity attribute.</summary>
    public const string CostField = "Cost";


    #endregion
    
    #region Relationships

    [ReverseAssociation("Product")]
    private readonly EntityCollection<Order> _orders = new EntityCollection<Order>();


    #endregion
    
    #region Properties

    [System.Diagnostics.DebuggerNonUserCode]
    public EntityCollection<Order> Orders
    {
      get { return Get(_orders); }
    }


    [System.Diagnostics.DebuggerNonUserCode]
    public string Name
    {
      get { return Get(ref _name, "Name"); }
      set { Set(ref _name, value, "Name"); }
    }

    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Cost
    {
      get { return Get(ref _cost, "Cost"); }
      set { Set(ref _cost, value, "Cost"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the LightSpeedModel2 model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class LightSpeedModel2UnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<Customer> Customers
    {
      get { return this.Query<Customer>(); }
    }
    
    public System.Linq.IQueryable<Order> Orders
    {
      get { return this.Query<Order>(); }
    }
    
    public System.Linq.IQueryable<Product> Products
    {
      get { return this.Query<Product>(); }
    }
    
  }

}
