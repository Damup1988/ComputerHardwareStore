using System;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.DB
{
    public interface ISupplierRepository
    {
        bool SaveChangesFunc();
        IEnumerable<Supplier> GetAllSuppliers();
        Item GetSupplierById(Guid id);
        void CreateSupplier(Item item);
        void UpdateSupplier(Item item);
        void DeleteSupplier(Guid id);
    }
}