using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RestWithASPNet.Hypermidia.Abstract
{
    public interface IResponseEnricher
    {
        bool CanEnrich(ResultExecutedContext context);

        Task Enrich(ResultExecutedContext context);
    }
}
