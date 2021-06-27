using System;
using System.Collections.Generic;
using System.Linq;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.DB
{
    public class SupplierRepositoryDb : ISupplierRepository
    {
        private readonly SupplierContext _supplierContext;

        public SupplierRepositoryDb(SupplierContext supplierContext)
        {
            _supplierContext = supplierContext;
        }
        
        public bool SaveChangesFunc()
        {
            return (_supplierContext.SaveChanges() >= 0);
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _supplierContext.Suppliers.ToList();
        }

        public Item GetSupplierById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CreateSupplier(Item item)
        {
            throw new NotImplementedException();
        }

        public void UpdateSupplier(Item item)
        {
            throw new NotImplementedException();
        }

        public void DeleteSupplier(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}