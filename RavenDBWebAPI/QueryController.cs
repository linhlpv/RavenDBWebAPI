using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RavenDBWebAPI.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RavenDBWebAPI
{
    [Route("api/Query")]
    public class QueryController : Controller
    {
        private IQueryRepository queryRepository;
        public QueryController (IQueryRepository queryRepository)
        {
            this.queryRepository = queryRepository;
        }

        [Route("GetFromTable"), HttpGet]
        public Customer GetFormTable()
        {
            return queryRepository.GetFromTable();
        }

        //[Route("GetFrom2Table")]

    }
}
