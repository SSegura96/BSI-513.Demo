using MiPrimeraSolucion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraSolucion.Products.BL.Dominio.Repositorios
{
    public class ProductCategories
    {
        private static AdventureWorks2012Entities _context = new AdventureWorks2012Entities();

        public ProductCategories()
        {
            _context.Configuration.ProxyCreationEnabled = false;
            _context.Configuration.LazyLoadingEnabled = true;
        }

        public ProductCategories(bool enableLazyLoading)
        {
            _context.Configuration.LazyLoadingEnabled = enableLazyLoading;
        }

        public Model.ProductCategory ObtenerPorId (int productCategoryId)
        {
            Model.ProductCategory modelo = new ProductCategory();
            modelo = _context.ProductCategory.Find(productCategoryId);
            return modelo;

        }

        public string ObtenerNombreDeCategoria(int productCategoryId)
        {
            Model.ProductCategory categoria = ObtenerPorId(productCategoryId);
            if (categoria != null)
                return categoria.Name;
            else
                return null;
        }

    }
}