using Microsoft.AspNetCore.Mvc;

namespace Blog.WebApi.Controllers;

[Route("api/[controller]")]
public class TesteController
{
    [HttpGet]
    public string Get()
    {
        return "Teste";
    }
}