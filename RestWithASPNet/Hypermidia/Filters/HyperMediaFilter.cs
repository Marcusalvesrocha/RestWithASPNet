using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestWithASPNet.Hypermidia.Filters
{
    public class HyperMediaFilter : ResultFilterAttribute
    {
        private readonly HyperMediaFilterOptions _hyperMediaFilterOptions;

        public HyperMediaFilter(HyperMediaFilterOptions hyperMediaFilterOptions)
        {
            _hyperMediaFilterOptions = hyperMediaFilterOptions;
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            TryEnrichResult(context);
            base.OnResultExecuted(context);
        }

        private void TryEnrichResult(ResultExecutedContext context)
        {
            if (context.Result is OkObjectResult okObjectResult)
            {
                var enricher = _hyperMediaFilterOptions.ContentResponseEnricherList.FirstOrDefault(x => x.CanEnrich(context));
            };
        }
    }
}
