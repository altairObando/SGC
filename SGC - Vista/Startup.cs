using System;
using Microsoft.Owin;
using Owin;
using SGC___Modelo;
using System.Data.Entity;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(SGC___Vista.Startup))]
namespace SGC___Vista
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            startApp();
        }

        private void startApp()
        {
            var model = new Modelo();
            using (var transact = model.Database.BeginTransaction())
            {
                try
                {
                    //Creando estados de las gestiones
                    if(model.EstadoGestion.Count() == 0)
                    {
                        model.EstadoGestion.Add(new EstadoGestion { estado = "En Proceso", disponible = true });
                        model.EstadoGestion.Add(new EstadoGestion { estado = "En Calibración", disponible = true });
                        model.EstadoGestion.Add(new EstadoGestion { estado = "Entrega de Equipos", disponible = true });
                        model.EstadoGestion.Add(new EstadoGestion { estado = "En Revision", disponible = true });
                        model.EstadoGestion.Add(new EstadoGestion { estado = "Finalizado", disponible = true });
                        model.SaveChanges();
                    }
                    //Creando los tipos de clientes de LAF-RAM
                    if(model.TipoCliente.Count() == 0)
                    {
                        model.TipoCliente.Add(new TipoCliente { tipo_cliente ="Empresa", activo = true});
                        model.TipoCliente.Add(new TipoCliente { tipo_cliente = "Laboratorio", activo = true });
                        model.TipoCliente.Add(new TipoCliente { tipo_cliente = "Hospital", activo = true });
                        model.TipoCliente.Add(new TipoCliente { tipo_cliente = "Persona Juridica", activo = true });

                        model.SaveChanges();
                    }
                    //Creando un cliente por defecto para los procesos internos
                    if(model.Cliente.Where( c => c.nombreInstitucion.Equals("LAF-RAM")).FirstOrDefault() == null){
                        var clienteLocal = new Cliente
                        {
                            nombreInstitucion = "LAF-RAM",
                            ciudad = "Managua",
                            codigoMinsa = "0000-0000X",
                            direccion = "UNAN - MANAGUA",
                            ruc = "0000000x0000",
                            telefono = "2222-2222", 
                            idTipoCliente = model.TipoCliente.First(x=> x.tipo_cliente == "Empresa").idTipoCliente
                        };
                        model.Cliente.Add(clienteLocal);
                        model.SaveChanges();
                    }
                    //Agregando Cargos Basicos para personas
                    if(model.Cargo.Count() == 0)
                    {
                        model.Cargo.Add(new Cargo { cargo1 = "Director", cargoDisponible = true });
                        model.Cargo.Add(new Cargo { cargo1 = "RC", cargoDisponible = true });
                        model.Cargo.Add(new Cargo { cargo1 = "RL", cargoDisponible = true });
                        model.Cargo.Add(new Cargo { cargo1 = "Personal", cargoDisponible = true });
                        model.Cargo.Add(new Cargo { cargo1 = "Visitante", cargoDisponible = true });
                        model.Cargo.Add(new Cargo { cargo1 = "Portador Dos.", cargoDisponible = true });
                        model.Cargo.Add(new Cargo { cargo1 = "R. Legal", cargoDisponible = true });

                        model.SaveChanges();
                    }
                    transact.Commit();
                }
                catch (Exception)
                {
                    transact.Rollback();
                    throw;
                }
            }
        }
    }
}
