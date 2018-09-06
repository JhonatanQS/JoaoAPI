using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace JoaoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly Contexto _contexto;

        public ValuesController(Contexto contexto)
        {
            _contexto = contexto;
        }

        //para chamar: api/values - GET
        [HttpGet(Name ="GetAll")]
        public ActionResult<IEnumerable<InformacaoNavegacao>> Get()
        {
            return this._contexto.InformacaoNavegacao.ToList();
        }

        // para chamar: api/values - POST
        [HttpPost]
        public ActionResult Post([FromBody] InformacaoNavegacao info)
        {
            InformacaoNavegacao novo = new InformacaoNavegacao();
            novo = info;
            this._contexto.InformacaoNavegacao.Add(novo);
            this._contexto.SaveChangesAsync();

            return RedirectPermanent("GetAll");
        }
    }
}