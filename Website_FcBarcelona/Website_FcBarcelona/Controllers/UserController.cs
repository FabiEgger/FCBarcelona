﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Website_FCBarcelona.Models;
using Website_FCBarcelona.Models.db;

namespace Website_FCBarcelona.Controllers
{
    public class UserController : Controller
    {
        private IRepositoryUser rep;

        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Registration()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            // Parameter user:hier sind die eingegebenen Daten des Formulars enthalten

            if (user == null)
            {
                return RedirectToAction("Registration");
            }
            //2. Formulardaten überprüfen - muss immer gemacht werden
            //      auch wenn z.b das Formular mit HIlfe von JavaScript
            //      überprüft wurde
            CheckUserData(user);

            //falls Fehler vorhanden sind
            if (!ModelState.IsValid)
            {
                // wird rufen das FOrmular erneut auf
                //      das Formular wird mit dem vorhergehenden Werten befüllt
                return View(user);
            }
            else
            {
                // eine Instanz unserer DB-Klasse erzeugen
                rep = new RepositoryUserDB();

                // Verbindung zum BD-Server herstellen
                rep.Open();

                // versuchen die Userdaten einzutragen
                if (rep.Insert(user))
                {
                    // Verbindung schließen
                    rep.Close();
                    // Erfolgsmeldung ausgeben
                    return View("Message", new Message("Registrierung", "Ihre Daten wurde erfolgreich abgespeichert"));
                }
                else
                {
                    rep.Close();
                    // Fehlermeldung ausgeben
                    return View("Message", new Message("Registrierung", "Ihre Daten konnten nicht abgespeichert werden"));
                }




            }
        }

        public ActionResult Login()
        {
            return View(new UserLogin());
        }
        [HttpPost]
        public ActionResult Login(UserLogin user)
        {
            User userfromDB;
            rep = new RepositoryUserDB();
            rep.Open();
            userfromDB = rep.Login(user);
            rep.Close();
            if (userfromDB == null)
            {
                ModelState.AddModelError("Username", "Benutzername oder Passwort stimmen nicht überein!");
                return View(user);
            }
            else
            {
                // der komplette User wird in einer Sessionvariable abgelegt und ist somit auf jeder Seite verfügbar
                Session["loggedinUser"] = userfromDB;
                return RedirectToAction("index", "home");
            }
        }
        private void CheckUserData(User user)
        {
            if (user == null)
            {
                return;
            }

            if (string.IsNullOrEmpty(user.Username.Trim()))
            {
                ModelState.AddModelError("Username", "Benutzername ist ein Pflichtfeld.");
            }

            //Passwortfeld
            //Richtlinien: mind. 8 Zeichen lang, mind. 1 Kleinbuchstabe, mind. 1 Großbuchstabe, mind. 1  SOnderzeichen
            if (!CheckPassword(user.Password))
            {
                ModelState.AddModelError("Passwort", "Passwort muss mind. 8 Zeichen lang sein und mind. 1 Kleinbuchstabe, mind. 1 Großbuchstabe, mind. 1  SOnderzeichen enthalten");
            }
            if (user.Password != user.Password2)
            {
                ModelState.AddModelError("Password2", "Passwort2 muss mit Passwort1 übereinstimmen");
            }
        }
        private bool CheckPassword(string password)
        {
            string pwd = password.Trim();
            if (password.Trim().Length < 8)
            {
                return false;
            }

            if (!PasswordContainsCountLowercaseCharacters(pwd, 1))
            {
                return false;
            }
            if (!PasswordContainsCountUppercaseCharacters(pwd, 1))
            {
                return false;
            }
            if (!PasswordContainsCountSpecialCharacters(pwd, 1))
            {
                return false;
            }
            return true;
        }

        private bool PasswordContainsCountLowercaseCharacters(string text, int minCount)
        {
            int count = 0;
            foreach (char c in text)
            {
                //falls das aktuelle Zeichen ein Kleinuchstabe ist
                if (char.IsLower(c))
                {
                    //Anzahl erhöhen
                    count++;
                }

            }
            return count >= minCount;
        }

        private bool PasswordContainsCountUppercaseCharacters(string text, int minCount)
        {
            int count = 0;
            foreach (char c in text)
            {
                //falls das aktuelle Zeichen ein Kleinuchstabe ist
                if (char.IsUpper(c))
                {
                    //Anzahl erhöhen
                    count++;
                }

            }
            return count >= minCount;
        }

        private bool PasswordContainsCountSpecialCharacters(string text, int minCount)
        {
            string allowedChars = "!§$%&/()[]{}=?'*+#€^°;:,.-_\"'\\";
            int count = 0;
            foreach (char c in text)
            {
                //falls das aktuelle Zeichen ein Kleinuchstabe ist
                if (allowedChars.Contains(c))
                {
                    //Anzahl erhöhen
                    count++;
                }

            }
            return count >= minCount;
        }
    }
}