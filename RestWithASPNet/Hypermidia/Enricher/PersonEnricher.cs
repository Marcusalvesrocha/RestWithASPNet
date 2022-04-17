using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestWithASPNet.Data.VO;
using RestWithASPNet.Hypermidia.Constants;

namespace RestWithASPNet.Hypermidia.Enricher
{
    public class PersonEnricher : ContentResponseEnricher<PersonVO>
    {
        private readonly object _lock = new object();

        protected override Task EnrichModel(PersonVO content, IUrlHelper urlHelper)
        {
            var path = "api/persons/v1";
            string link = getLink(content.Id, urlHelper, path);

            content.Links.Add(new HyperMidiaLink()
            {
                Action = HttpActionsVerbs.GET,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultGet
            });

            content.Links.Add(new HyperMidiaLink()
            {
                Action = HttpActionsVerbs.POST,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPost
            });

            content.Links.Add(new HyperMidiaLink()
            {
                Action = HttpActionsVerbs.PUT,
                Href = link,
                Rel = RelationType.self,
                Type = ResponseTypeFormat.DefaultPut
            });

            content.Links.Add(new HyperMidiaLink()
            {
                Action = HttpActionsVerbs.DELETE,
                Href = link,
                Rel = RelationType.self,
                Type = "int"
            });

            return null;
        }

        private string getLink(long id, IUrlHelper urlHelper, string path)
        {
            lock (_lock)
            {
                var url = new { controller = path, id = id};
                return new StringBuilder(urlHelper.Link("DefaultApi", url)).Replace("%2F", "/").ToString();
            };
        }
    }
}
