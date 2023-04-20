﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace CoreServices.Clases
{
    public class OperacionesCuenta
    {        
        public DbSet<Cuenta> GetCuentas()
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                return db.Cuenta;
            }
        }


        /*
         * public List<CollegeDetail> GetCollegeRecords()  
        {  
            using (CollegeDataEntities context = new CollegeDataEntities())  
            {  
                return context.CollegeDetails.ToList();  
            }  
        }
        */

        public bool InsertCuentas(int idCliente, int idTipoCuenta, int idBanco, string NumeroCuenta, bool Estado)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                ObjectParameter ReturnedValue = new ObjectParameter("ReturnValue", typeof(int));
                db.spInsertCuenta(idCliente, idTipoCuenta, idBanco, NumeroCuenta, Estado);

                if (Convert.ToInt32(ReturnedValue.Value) >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }            
        }

        public bool UpdateCuentas(int idCuenta, bool Estado, decimal Balance)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spUpsertCuenta(idCuenta, Estado, Balance);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool DeleteCuentas(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                int ReturnedValue = db.spDeleteCuenta(id);

                if (ReturnedValue >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Cuenta GetCuentabyID(int id)
        {
            using (DBCoreEntities db = new DBCoreEntities())
            {
                var Cuenta = db.Cuenta.Where(i => i.idCuenta == id).First();

                return Cuenta;
            }
        }
    }
}