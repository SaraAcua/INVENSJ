﻿using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class Email
    { 
        private MailMessage email;
        private SmtpClient smtp;
        public Email()
        {
            smtp = new SmtpClient();
        }
        

        private void ConfigurarSmt()
        {
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("tiendaskshop@gmail.com",
             "invensj2020");
        }

        private void ConfigurarEmail(Cliente cliente)
        {
            email = new MailMessage();
            email.To.Add(cliente.Email);
            email.From = new MailAddress("tiendaskshop@gmail.com");
            email.Subject = "Registro de Usuario "
                + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            email.Body = $"<b>Sr {cliente.Nombre }</b><b> {cliente.Apellidos}</b> <br " +
                $" > se ha realizado su registro Satisfactoriamente    =)";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

        public string EnviarEmail(Cliente cliente)
        {

            try
            {
                ConfigurarSmt();
                ConfigurarEmail(cliente);
                smtp.Send(email);
                return ("Correo enviado Satifactoriamente");
            }
            catch (Exception e)
            {

                return ("error al enviar correo" + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }


    }

}
