using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRAC.Api.SQLite;
using Microsoft.AspNetCore.Mvc;

namespace CRAC.Api.Controllers {
    [Route ("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase {
        // GET api/values
        [HttpGet]
        public ActionResult<Moviment> Get () {
            //inicializa connexao cm sqllite
            using (var dbContext = new CracContext ()) {

                //pega primeiro item que encontrar na tabela moviments
                var findMoviment = dbContext.Moviments.FirstOrDefault ();

                // se nao achar nada cria uma entrada no banco
                if (findMoviment == null) {
                    findMoviment = new Moviment () {
                    Base = 90,
                    Left = 90,
                    Right = 90,
                    Claw = 90
                    };

                    //adiciona e salva no banco
                    dbContext.Moviments.Add (findMoviment);
                    dbContext.SaveChanges ();
                }

                return findMoviment;

            }
        }

    }
}