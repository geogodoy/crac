using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRAC.Api.SQLite;
using Microsoft.AspNetCore.Mvc;

namespace Crac.Controllers {
    public class HomeController : Controller {
        public IActionResult Index () {

            Moviment curMoviment = null;

            using (var dbContext = new CracContext ()) {

                //pega primeiro item que encontrar na tabela moviments
                curMoviment = dbContext.Moviments.FirstOrDefault ();

                // se nao achar nada cria uma entrada no banco
                if (curMoviment == null) {
                    curMoviment = new Moviment () {
                    Base = 90,
                    Left = 90,
                    Right = 90,
                    Claw = 90
                    };

                    //adiciona e salva no banco
                    dbContext.Moviments.Add (curMoviment);
                    dbContext.SaveChanges ();
                }
            }

            return View (curMoviment);
        }

        [HttpPost]
        public IActionResult Index (Moviment moviment) {
            Moviment curMoviment = null;

            using (var dbContext = new CracContext ()) {

                //pega primeiro item que encontrar na tabela moviments
                curMoviment = dbContext.Moviments.FirstOrDefault ();

                // se nao achar nada cria uma entrada no banco
                if (curMoviment == null) {
                    curMoviment = new Moviment () {
                    Base = moviment.Base,
                    Left = moviment.Left,
                    Right = moviment.Right,
                    Claw = moviment.Claw
                    };

                    //adiciona e salva no banco
                    dbContext.Moviments.Add (curMoviment);
                    dbContext.SaveChanges ();
                } else {

                    // se movimento ja existe atualiza os campos e salva contexto
                    curMoviment.Base = moviment.Base;
                    curMoviment.Left = moviment.Left;
                    curMoviment.Right = moviment.Right;
                    curMoviment.Claw = moviment.Claw;

                    //modifica e salva no banco
                    dbContext.Moviments.Update(curMoviment);
                    dbContext.SaveChanges ();
                }
            }

            return View (moviment);
        }
    }
}