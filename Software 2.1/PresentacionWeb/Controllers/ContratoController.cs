using Aplicacion;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PresentacionWeb.Controllers
{
    public class ContratoController : Controller
    {
        // GET: Contrato
        public ActionResult Inicio()
        {
            return View("Inicio");
        }

        public ActionResult EditarContrato(Int32 Id_Empleado)
        {
            ViewBag.Empleado = Id_Empleado;
            Contrato contrato = ContratoAP.Instancia.ObtenerContrato(Id_Empleado);
            if (contrato.Id_Contrato == 0)
            {
                String msje = "Empleado no Cuenta con un contrato Vigente";
                return PartialView("_Error", msje);
            }
            else return PartialView("_EditarContrato",contrato);
        }

        public ActionResult VistaAnularContrato(Int32 Id_Empleado)
        {
            ViewBag.Empleado = Id_Empleado;
            Contrato contrato = ContratoAP.Instancia.ObtenerContrato(Id_Empleado);
            if (contrato.Id_Contrato == 0)
            {
                String msje = "Empleado no Cuenta con un contrato Vigente";
                return PartialView("_Error", msje);
            }
            else return PartialView("_VistaAnularContrato", ContratoAP.Instancia.ObtenerContrato(Id_Empleado));
        }

        public String ActualizarContrato(Contrato contrato, Int32 Id_AFP, Int32 Id_Cargo, Int32 Id_Empleado)
        {
            String rpta = ContratoAP.Instancia.ActualizarContrato(contrato, Id_AFP, Id_Empleado, Id_Cargo);
            return rpta;

        }

        public ActionResult CrearContrato(Int32 Id_Empleado)
        {
            ViewBag.Empleado = Id_Empleado;
            if (ContratoAP.Instancia.ValidarVigencia(Id_Empleado))
            {
                String msje = "Cuenta con un Contrato Vigente";
                return PartialView("_Error",msje);
            }
            else return PartialView("_CrearContrato");
        }

        public String RegistrarContrato(Contrato contrato,Int32 Id_AFP,Int32 Id_Cargo,Int32 Id_Empleado)
        {
            String rpta = ContratoAP.Instancia.RegistrarContrato(contrato, Id_AFP, Id_Empleado, Id_Cargo);
            return rpta;

        }

        public Int32 AnularContrato(Int32 Id_Contrato)
        {
            return ContratoAP.Instancia.AnularContrato(Id_Contrato);
        }

    }
}