﻿using Impacta.MOD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Impacta.Tarefas.Controllers
{
	public class AutenticadorController : Controller
	{
		public ActionResult Formulario()
		{
			return View();
		}

		public ActionResult Entrar(Usuario usuario)
		{
			if (usuario.Username != null && usuario.Password != null && 
				usuario.Username.Equals("RealBooks") && usuario.Password.Equals("RealBooks"))
			{
				Session["Usuario"] = usuario.Username;
				return RedirectToAction("Index", "RealBooks");
			}
			else
			{
				ViewBag.Mensagem = " usuário ou senha incorretos ";
				return View("Formulario");
			}
		}

		public ActionResult Sair()
		{
			Session.Abandon();
			return RedirectToAction("Formulario");
		}
	}
}