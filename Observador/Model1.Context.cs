﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Observador
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DataProductsEntities : DbContext
    {
        public DataProductsEntities()
            : base("name=DataProductsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CatBrands> CatBrands { get; set; }
        public virtual DbSet<CatCatalogs> CatCatalogs { get; set; }
        public virtual DbSet<CatColors> CatColors { get; set; }
        public virtual DbSet<CatProviders> CatProviders { get; set; }
        public virtual DbSet<CatRatings> CatRatings { get; set; }
        public virtual DbSet<CatSizes> CatSizes { get; set; }
        public virtual DbSet<CatTypeDetails> CatTypeDetails { get; set; }
        public virtual DbSet<CatTypeProduct> CatTypeProduct { get; set; }
        public virtual DbSet<ChangesOnProduct> ChangesOnProduct { get; set; }
        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<DetailProduct> DetailProduct { get; set; }
        public virtual DbSet<ImagesProduct> ImagesProduct { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Qualification> Qualification { get; set; }
        public virtual DbSet<SimilarProduct> SimilarProduct { get; set; }
        public virtual DbSet<SizeForProduct> SizeForProduct { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    
        public virtual int LFGC1_ActualizaProducto(Nullable<int> productId, Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string title, string nombre, string description, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dataUpdate)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("IdType", idType) :
                new ObjectParameter("IdType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("IdColor", idColor) :
                new ObjectParameter("IdColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("IdBrand", idBrand) :
                new ObjectParameter("IdBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("IdProvider", idProvider) :
                new ObjectParameter("IdProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("IdCatalog", idCatalog) :
                new ObjectParameter("IdCatalog", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dataUpdateParameter = dataUpdate.HasValue ?
                new ObjectParameter("DataUpdate", dataUpdate) :
                new ObjectParameter("DataUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LFGC1_ActualizaProducto", productIdParameter, idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, titleParameter, nombreParameter, descriptionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dataUpdateParameter);
        }
    
        public virtual ObjectResult<LFGC1_BuscaProductoID_Result> LFGC1_BuscaProductoID(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LFGC1_BuscaProductoID_Result>("LFGC1_BuscaProductoID", productIdParameter);
        }
    
        public virtual ObjectResult<LFGC1_BuscaProductoNombre_Result> LFGC1_BuscaProductoNombre(string productName)
        {
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LFGC1_BuscaProductoNombre_Result>("LFGC1_BuscaProductoNombre", productNameParameter);
        }
    
        public virtual int LFGC1_EliminaProductoPorID(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LFGC1_EliminaProductoPorID", productIdParameter);
        }
    
        public virtual int LFGC1_InsertaNuevoProducto(Nullable<int> idType, Nullable<int> idColor, Nullable<int> idBrand, Nullable<int> idProvider, Nullable<int> idCatalog, string title, string nombre, string description, string observations, Nullable<decimal> priceDistributor, Nullable<decimal> priceClient, Nullable<decimal> priceMember, Nullable<bool> isEnabled, string keywords, Nullable<System.DateTime> dataUpdate)
        {
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("IdType", idType) :
                new ObjectParameter("IdType", typeof(int));
    
            var idColorParameter = idColor.HasValue ?
                new ObjectParameter("IdColor", idColor) :
                new ObjectParameter("IdColor", typeof(int));
    
            var idBrandParameter = idBrand.HasValue ?
                new ObjectParameter("IdBrand", idBrand) :
                new ObjectParameter("IdBrand", typeof(int));
    
            var idProviderParameter = idProvider.HasValue ?
                new ObjectParameter("IdProvider", idProvider) :
                new ObjectParameter("IdProvider", typeof(int));
    
            var idCatalogParameter = idCatalog.HasValue ?
                new ObjectParameter("IdCatalog", idCatalog) :
                new ObjectParameter("IdCatalog", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("Title", title) :
                new ObjectParameter("Title", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("Description", description) :
                new ObjectParameter("Description", typeof(string));
    
            var observationsParameter = observations != null ?
                new ObjectParameter("Observations", observations) :
                new ObjectParameter("Observations", typeof(string));
    
            var priceDistributorParameter = priceDistributor.HasValue ?
                new ObjectParameter("PriceDistributor", priceDistributor) :
                new ObjectParameter("PriceDistributor", typeof(decimal));
    
            var priceClientParameter = priceClient.HasValue ?
                new ObjectParameter("PriceClient", priceClient) :
                new ObjectParameter("PriceClient", typeof(decimal));
    
            var priceMemberParameter = priceMember.HasValue ?
                new ObjectParameter("PriceMember", priceMember) :
                new ObjectParameter("PriceMember", typeof(decimal));
    
            var isEnabledParameter = isEnabled.HasValue ?
                new ObjectParameter("IsEnabled", isEnabled) :
                new ObjectParameter("IsEnabled", typeof(bool));
    
            var keywordsParameter = keywords != null ?
                new ObjectParameter("Keywords", keywords) :
                new ObjectParameter("Keywords", typeof(string));
    
            var dataUpdateParameter = dataUpdate.HasValue ?
                new ObjectParameter("DataUpdate", dataUpdate) :
                new ObjectParameter("DataUpdate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("LFGC1_InsertaNuevoProducto", idTypeParameter, idColorParameter, idBrandParameter, idProviderParameter, idCatalogParameter, titleParameter, nombreParameter, descriptionParameter, observationsParameter, priceDistributorParameter, priceClientParameter, priceMemberParameter, isEnabledParameter, keywordsParameter, dataUpdateParameter);
        }
    
        public virtual ObjectResult<LFGC1_MuestraProductos_Result> LFGC1_MuestraProductos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LFGC1_MuestraProductos_Result>("LFGC1_MuestraProductos");
        }
    
        public virtual ObjectResult<NmrhID_Result> NmrhID(Nullable<int> productId)
        {
            var productIdParameter = productId.HasValue ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NmrhID_Result>("NmrhID", productIdParameter);
        }
    
        public virtual ObjectResult<NmrhProduc_Result> NmrhProduc()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NmrhProduc_Result>("NmrhProduc");
        }
    }
}