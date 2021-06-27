using System;
using System.Collections.Generic;
using ComputerHardwareStore.DB;
using ComputerHardwareStore.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComputerHardwareStore.BusinessLogic
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _repository;

        public SupplierService(ISupplierRepository repository)
        {
            _repository = repository;
        }
        
        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return _repository.GetAllSuppliers();
        }

        public Item GetSupplierById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void CreateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateSupplier(Supplier supplier)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSupplier(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}