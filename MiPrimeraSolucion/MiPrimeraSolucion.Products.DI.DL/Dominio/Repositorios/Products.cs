using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiPrimeraSolucion.Model;

namespace MiPrimeraSolucion.Products.DI.DL.Dominio.Repositorios
{
    public class Products
    {
        private static AdventureWorks2012Entities _context = new AdventureWorks2012Entities();

        public Products (AdventureWorks2012Entities elContexto)
        {
            _context.Configuration.ProxyCreationEnabled = false;
            _context.Configuration.LazyLoadingEnabled = true;
            _context = elContexto;
        }

        public Products(bool enableLazyLoading)
        {
            _context.Configuration.LazyLoadingEnabled = enableLazyLoading;
        }


        public IList<Model.Product> ListarProductosPorColor(string elColor)
        {
            return (ListarProductosPorColor(false, elColor));
        }

        public IList<Model.Product> ListarProductosPorColor(bool busquedaExacta, string elColor)
        {
            string tablasInclude = "ProductSubCategory, ProductModel, ProductSubcategory.ProductCategory";
            tablasInclude = string.Empty;
            IList<Model.Product> resultado = null;
            if (busquedaExacta)
                resultado =  _context.Product.Where(p=> p.Color.Equals(elColor)).OrderByDescending(p=> p.Name).ToList();
            else
                resultado = _context.Product.Where(p => p.Color.Contains(elColor)).OrderByDescending(p => p.Name).ToList();
            TraerInformacionAdicional(resultado);

            return resultado;
        }

        private void TraerInformacionAdicional(IList<Product> resultado)
        {
            var repositorioModelo = new Repositorios.ProductModels();
            var repositorioCategoria = new Repositorios.ProductCategories();
            var repositorioSubcategoria = new Repositorios.ProductSubcategories();
            foreach (var elemento in resultado)
            {
                //if (elemento.ProductModel != null)
                //    elemento.ProductModelName = elemento.ProductModel.Name;
                //elemento.ProductModel = null;
                //if (elemento.ProductSubcategory != null)
                //    elemento.ProductSubcategoryName = elemento.ProductSubcategory.Name;
                //if (elemento.ProductSubcategory != null)
                //    if (elemento.ProductSubcategory.ProductCategory != null)
                //        elemento.ProductCategoryName = elemento.ProductSubcategory.ProductCategory.Name;
                //elemento.ProductSubcategory = null;
                //elemento.ProductReview = null;
                if (elemento.ProductModelID != null)
                    elemento.ProductModelName = repositorioModelo.ObtenerNombreDeModelo((int)elemento.ProductModelID);
                if (elemento.ProductSubcategoryID != null)
                    elemento.ProductSubcategoryName = repositorioSubcategoria.ObtenerNombreDeSubcategoria((int)elemento.ProductSubcategoryID);
                if (elemento.ProductSubcategoryID != null)
                    elemento.ProductCategoryName = repositorioSubcategoria.ObtenerNombreDeCategoria((int)elemento.ProductSubcategoryID);
            }
        }

    }
}