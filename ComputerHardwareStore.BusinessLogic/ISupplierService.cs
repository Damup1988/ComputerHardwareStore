using System;
using System.Collections.Generic;
using ComputerHardwareStore.Domain;

namespace ComputerHardwareStore.BusinessLogic
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Item GetSupplierById(Guid id);
        void CreateSupplier(Supplier supplier);
        bool UpdateSupplier(Supplier supplier);
        bool DeleteSupplier(Guid id);
    }
}