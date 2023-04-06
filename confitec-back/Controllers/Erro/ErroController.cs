using confitec_back.DL.Response.Base;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using confitec_back.DL.Excecoes;

namespace confitec_back.API.Controllers.Erro
{
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErroController : ControllerBase
    {
        [Route("erro")]
        public ErrorViewModel Erro()
        {
            IExceptionHandlerFeature contexto = HttpContext.Features.Get<IExceptionHandlerFeature>();
            Exception excecao = contexto?.Error!;

            HttpStatusCode httpStatusCode = excecao switch
            {
                KeyNotFoundException _ => HttpStatusCode.NotFound,
                ArgumentException _ => HttpStatusCode.NotAcceptable,
                MissingFieldException _ => HttpStatusCode.BadRequest,
                ObjetoJaExisteException _ => HttpStatusCode.Conflict,
                DataNacimentoException _ => HttpStatusCode.BadRequest,
                EmailInvalidoException _ => HttpStatusCode.BadRequest,
                _ => HttpStatusCode.InternalServerError
            };

            Response.StatusCode = (int)httpStatusCode;

            return new ErrorViewModel(Response.StatusCode.ToString(), excecao.Message);
        }
    }
}