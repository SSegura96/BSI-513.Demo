using MiPrimeraSolucion.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraSolucion.Products.DI.DL.Dominio.Repositorios
{
    public class ProductModels
    {
        private static AdventureWorks2012Entities _context = new AdventureWorks2012Entities();

        public ProductModels()
        {
            _context.Configuration.ProxyCreationEnabled = false;
            _context.Configuration.LazyLoadingEnabled = true;
        }

        public ProductModels(bool enableLazyLoading)
        {
            _context.Configuration.LazyLoadingEnabled = enableLazyLoading;
        }

        public Model.ProductModel ObtenerPorId (int productModelId)
        {
            Model.ProductModel modelo = new ProductModel();
            modelo = _context.ProductModel.Find(productModelId);
            return modelo;

        }

        public string ObtenerNombreDeModelo(int productModelId)
        {
            Model.ProductModel modelo = ObtenerPorId (productModelId);
            if (modelo != null)
                return modelo.Name;
            else
                return null;
        }

    }
}