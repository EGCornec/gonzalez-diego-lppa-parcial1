using ParcialDEGLPPA.Data;
using ParcialDEGLPPA.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialDEGLPPA.Business
{
    public class AfiliadoB
    {
        
            BaseDataService<Afiliados> db;
            public AfiliadoB()
            {
                db = new BaseDataService<Afiliados>();
            }

            public Afiliados Agregar(Afiliados model)
            {
                return db.Create(model);
            }

            public List<Afiliados> Listar()
            {

                var lista = db.Get();
                return lista;
            }

            public Afiliados Get(int id)
            {
                return db.GetById(id);
            }

            public void Eliminar(Afiliados model)
            {
                db.Delete(model);
            }

            public void Update(Afiliados model)
            {
                db.Update(model);
            }
        }
}