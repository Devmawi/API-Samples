﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 19.03.2023 16:03:42
namespace ODataWebApi.Models
{
    /// <summary>
    /// There are no comments for OrderSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("OrderSingle")]
    public partial class OrderSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Order>
    {
        /// <summary>
        /// Initialize a new OrderSingle object.
        /// </summary>
        public OrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new OrderSingle object.
        /// </summary>
        public OrderSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new OrderSingle object.
        /// </summary>
        public OrderSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Order> query)
            : base(query) {}

    }
    /// <summary>
    /// There are no comments for Order in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Order")]
    public partial class Order : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Order object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="amount">Initial value of Amount.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Order CreateOrder(int ID, decimal amount)
        {
            Order order = new Order();
            order.Id = ID;
            order.Amount = amount;
            return order;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Amount in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Amount")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Amount is required.")]
        public virtual decimal Amount
        {
            get
            {
                return this._Amount;
            }
            set
            {
                this.OnAmountChanging(value);
                this._Amount = value;
                this.OnAmountChanged();
                this.OnPropertyChanged("Amount");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private decimal _Amount;
        partial void OnAmountChanging(decimal value);
        partial void OnAmountChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// There are no comments for ArticleSingle in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("ArticleSingle")]
    public partial class ArticleSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Article>
    {
        /// <summary>
        /// Initialize a new ArticleSingle object.
        /// </summary>
        public ArticleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new ArticleSingle object.
        /// </summary>
        public ArticleSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new ArticleSingle object.
        /// </summary>
        public ArticleSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Article> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Orders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Orders")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Order> Orders
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Orders == null))
                {
                    this._Orders = Context.CreateQuery<global::ODataWebApi.Models.Order>(GetPath("Orders"));
                }
                return this._Orders;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Order> _Orders;
    }
    /// <summary>
    /// There are no comments for Article in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    [global::Microsoft.OData.Client.OriginalNameAttribute("Article")]
    public partial class Article : global::Microsoft.OData.Client.BaseEntityType, global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Article object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        /// <param name="itemNumber">Initial value of ItemNumber.</param>
        /// <param name="rating">Initial value of Rating.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Article CreateArticle(int ID, string itemNumber, int rating)
        {
            Article article = new Article();
            article.Id = ID;
            article.ItemNumber = itemNumber;
            article.Rating = rating;
            return article;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Id")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Id is required.")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property ItemNumber in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("ItemNumber")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "ItemNumber is required.")]
        public virtual string ItemNumber
        {
            get
            {
                return this._ItemNumber;
            }
            set
            {
                this.OnItemNumberChanging(value);
                this._ItemNumber = value;
                this.OnItemNumberChanged();
                this.OnPropertyChanged("ItemNumber");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _ItemNumber;
        partial void OnItemNumberChanging(string value);
        partial void OnItemNumberChanged();
        /// <summary>
        /// There are no comments for Property Rating in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Rating")]
        [global::System.ComponentModel.DataAnnotations.RequiredAttribute(ErrorMessage = "Rating is required.")]
        public virtual int Rating
        {
            get
            {
                return this._Rating;
            }
            set
            {
                this.OnRatingChanging(value);
                this._Rating = value;
                this.OnRatingChanged();
                this.OnPropertyChanged("Rating");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Rating;
        partial void OnRatingChanging(int value);
        partial void OnRatingChanged();
        /// <summary>
        /// There are no comments for Property Orders in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]

        [global::Microsoft.OData.Client.OriginalNameAttribute("Orders")]
        public virtual global::Microsoft.OData.Client.DataServiceCollection<global::ODataWebApi.Models.Order> Orders
        {
            get
            {
                return this._Orders;
            }
            set
            {
                this.OnOrdersChanging(value);
                this._Orders = value;
                this.OnOrdersChanged();
                this.OnPropertyChanged("Orders");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceCollection<global::ODataWebApi.Models.Order> _Orders = new global::Microsoft.OData.Client.DataServiceCollection<global::ODataWebApi.Models.Order>(null, global::Microsoft.OData.Client.TrackingMode.None);
        partial void OnOrdersChanging(global::Microsoft.OData.Client.DataServiceCollection<global::ODataWebApi.Models.Order> value);
        partial void OnOrdersChanged();
        /// <summary>
        /// This event is raised when the value of the property is changed
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// The value of the property is changed
        /// </summary>
        /// <param name="property">property name</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::ODataWebApi.Models.Order as global::ODataWebApi.Models.OrderSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::ODataWebApi.Models.OrderSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Order> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::ODataWebApi.Models.OrderSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataWebApi.Models.Order as global::ODataWebApi.Models.OrderSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::ODataWebApi.Models.OrderSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Order> _source,
            int id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::ODataWebApi.Models.OrderSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataWebApi.Models.Article as global::ODataWebApi.Models.ArticleSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="_keys">dictionary with the names and values of keys</param>
        public static global::ODataWebApi.Models.ArticleSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Article> _source, global::System.Collections.Generic.IDictionary<string, object> _keys)
        {
            return new global::ODataWebApi.Models.ArticleSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
        /// <summary>
        /// Get an entity of type global::ODataWebApi.Models.Article as global::ODataWebApi.Models.ArticleSingle specified by key from an entity set
        /// </summary>
        /// <param name="_source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::ODataWebApi.Models.ArticleSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Article> _source,
            int id)
        {
            global::System.Collections.Generic.IDictionary<string, object> _keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::ODataWebApi.Models.ArticleSingle(_source.Context, _source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(_source.Context, _keys)));
        }
    }
}
namespace Default
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    [global::Microsoft.OData.Client.OriginalNameAttribute("Container")]
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public Container(global::System.Uri serviceRoot) :
                this(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
        }

        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public Container(global::System.Uri serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion protocolVersion) :
                base(serviceRoot, protocolVersion)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "ODataWebApi.Models", "ODataWebApi.Models");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            resolvedType = this.DefaultResolveType(typeName, "Default", "Default");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            global::Microsoft.OData.Client.OriginalNameAttribute originalNameAttribute = (global::Microsoft.OData.Client.OriginalNameAttribute)global::System.Linq.Enumerable.SingleOrDefault(global::Microsoft.OData.Client.Utility.GetCustomAttributes(clientType, typeof(global::Microsoft.OData.Client.OriginalNameAttribute), true));
            if (clientType.Namespace.Equals("ODataWebApi.Models", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("ODataWebApi.Models.", originalNameAttribute.OriginalName);
                }
                return string.Concat("ODataWebApi.Models.", clientType.Name);
            }
            if (clientType.Namespace.Equals("Default", global::System.StringComparison.Ordinal))
            {
                if (originalNameAttribute != null)
                {
                    return string.Concat("Default.", originalNameAttribute.OriginalName);
                }
                return string.Concat("Default.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Articles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        [global::Microsoft.OData.Client.OriginalNameAttribute("Articles")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Article> Articles
        {
            get
            {
                if ((this._Articles == null))
                {
                    this._Articles = base.CreateQuery<global::ODataWebApi.Models.Article>("Articles");
                }
                return this._Articles;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::ODataWebApi.Models.Article> _Articles;
        /// <summary>
        /// There are no comments for Articles in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual void AddToArticles(global::ODataWebApi.Models.Article article)
        {
            base.AddObject("Articles", article);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private const string filePath = @"OData ServiceCsdl.xml";

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader();
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;

                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, true, out edmModel, out errors))
                    {
	                    global::System.Text.StringBuilder errorMessages = new global::System.Text.StringBuilder();
	                    foreach (var error in errors)
	                    {
		                    errorMessages.Append(error.ErrorMessage);
		                    errorMessages.Append("; ");
	                    }
	                    throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::System.Xml.XmlReader CreateXmlReader()
            {
                try
                {
                    var assembly = global::System.Reflection.Assembly.GetExecutingAssembly();
                    var resourcePath = global::System.Linq.Enumerable.Single(assembly.GetManifestResourceNames(), str => str.EndsWith(filePath));
                    global::System.IO.Stream stream = assembly.GetManifestResourceStream(resourcePath);
                    return global::System.Xml.XmlReader.Create(new global::System.IO.StreamReader(stream));
                }
                catch(global::System.Xml.XmlException e)
                {
                    throw new global::System.Xml.XmlException("Failed to create an XmlReader from the stream. Check if the resource exists.", e);
                }
            }
        }
        /// <summary>
        /// There are no comments for ExecuteSomeFunction in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("ExecuteSomeFunction")]
        public virtual global::Microsoft.OData.Client.DataServiceQuerySingle<string> ExecuteSomeFunction()
        {
            return this.CreateFunctionQuerySingle<string>("", "ExecuteSomeFunction", false);
        }
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// There are no comments for Rate in the schema.
        /// </summary>
        [global::Microsoft.OData.Client.OriginalNameAttribute("rate")]
        public static global::Microsoft.OData.Client.DataServiceActionQuerySingle<int> Rate(this global::Microsoft.OData.Client.DataServiceQuerySingle<global::ODataWebApi.Models.Article> _source)
        {
            if (!_source.IsComposable)
            {
                throw new global::System.NotSupportedException("The previous function is not composable.");
            }

            return new global::Microsoft.OData.Client.DataServiceActionQuerySingle<int>(_source.Context, _source.AppendRequestUri("Default.rate"));
        }
    }
}