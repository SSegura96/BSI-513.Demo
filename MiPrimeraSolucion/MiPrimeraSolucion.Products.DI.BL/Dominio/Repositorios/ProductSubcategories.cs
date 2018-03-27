using MiPrimeraSolucion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraSolucion.Products.DI.BL.Dominio.Repositorios
{
    public class ProductSubcategories
    {
        private static AdventureWorks2012Entities _context = new AdventureWorks2012Entities();

        public ProductSubcategories()
        {
            _context.Configuration.ProxyCreationEnabled = false;
            _context.Configuration.LazyLoadingEnabled = true;
        }

        public ProductSubcategories(bool enableLazyLoading)
        {
            _context.Configuration.LazyLoadingEnabled = enableLazyLoading;
        }

        public Model.ProductSubcategory ObtenerPorId (int productSubcategoryId)
        {
            Model.ProductSubcategory modelo = new ProductSubcategory();
            modelo = _context.ProductSubcategory.Find(productSubcategoryId);
            return modelo;

        }

        public string ObtenerNombreDeSubcategoria(int productSubcategoryId)
        {
            Model.ProductSubcategory subcategoria = ObtenerPorId (productSubcategoryId);
            if (subcategoria != null)
                return subcategoria.Name;
            else
                return null;
        }

        public string ObtenerNombreDeCategoria(int productSubcategoryId)
        {
            string resultado = string.Empty;
            Model.ProductSubcategory subcategoria = ObtenerPorId (productSubcategoryId);
            if (subcategoria != null)
            {
                var elRepositorioDeCategoria = new Repositorios.ProductCategories();
                resultado = elRepositorioDeCategoria.ObtenerNombreDeCategoria(subcategoria.ProductCategoryID);
            }
            return resultado;
        }

    }
}