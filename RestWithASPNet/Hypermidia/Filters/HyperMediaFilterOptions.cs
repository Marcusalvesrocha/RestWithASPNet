using System;
using System.Collections.Generic;
using RestWithASPNet.Hypermidia.Abstract;

namespace RestWithASPNet.Hypermidia.Filters
{
    public class HyperMediaFilterOptions
    {
        public HyperMediaFilterOptions()
        {
        }

        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
