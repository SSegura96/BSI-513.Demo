using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiPrimeraSolucion.Model;

namespace MiPrimeraSolucion.Products.BL.Dominio.Repositorios
{
    public class Products
    {
        private static AdventureWorks2012Entities _context = new AdventureWorks2012Entities();

        public Products ()
        {
            _context.Configuration.LazyLoadingEnabled = true;
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
            foreach (var elemento in resultado)
            {
                if (elemento.ProductModel != null)
                        elemento.ProductModelName = elemento.ProductModel.Name;
                elemento.ProductModel = null;
                if (elemento.ProductSubcategory != null)
                        elemento.ProductSubcategoryName = elemento.ProductSubcategory.Name;
                if (elemento.ProductSubcategory != null)
                    if (elemento.ProductSubcategory.ProductCategory != null)
                        elemento.ProductCategoryName = elemento.ProductSubcategory.ProductCategory.Name;
                elemento.ProductSubcategory = null;
                elemento.ProductReview = null;
                //elemento.ProductModelName = ObtenerNombreDeModelo(elemento.ProductModelID);
                //elemento.ProductSubcategoryName = ObtenerNombreDeSubcategoria(elemento.ProductSubcategoryID);
                //elemento.ProductCategoryName = ObtenerNombreDeCategoria(elemento.ProductSubcategoryID);
            }
            return resultado;
        }

        private string ObtenerNombreDeModelo(Nullable <int> idModelo)
        {
            Model.ProductModel modelo = new ProductModel();
            if (idModelo != null)
                modelo = _context.ProductModel.Find(idModelo);
            return modelo.Name;
        }

        private string ObtenerNombreDeSubcategoria (Nullable <int> idSubCategoria)
        {
            Model.ProductSubcategory subCategoria = new ProductSubcategory();
            if (idSubCategoria != null)
                subCategoria = _context.ProductSubcategory.Find(idSubCategoria);
            return subCategoria.Name;
        }

        private string ObtenerNombreDeCategoria(Nullable<int> idCategoria)
        {
            Model.ProductCategory categoria = new ProductCategory();
            // TODO: Corregir la implementación
            return string.Empty;
            if (idCategoria != null)
                categoria = _context.ProductCategory.Find(idCategoria);

            return categoria.Name;
        }

    }
}