using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //INSTANCIAS DO TIPO CLIENTE
        Cliente cliente1 = new Cliente(01, "Arthur a Ferreira", "857.032.950-41", "arthur.antunes@sp.sena.br", "madruga");
        Cliente cliente2 = new Cliente(02, "Gustavo Sousa", "858.332.950-31", "gustavo.antunes@sp.sena.br", "bradok");
        Cliente cliente3 = new Cliente(03, "Vladmir Putin", "123.666.950-51", "salazar.antunes@sp.sena.br", "tcheco");
        Cliente cliente4 = new Cliente(04, "Adolf Schindler", "658.042.950-44", "wermat.antava@sp.sena.br", "paloma");

        // LISTA DE CLIENTES
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);

        ViewBag.listaClientes = listaClientes;

        //INSTANCIAS DO TIPO FORNECEDOR
        Fornecedor fornecedor = new Fornecedor(01, "Treva Pet", "01.666.879/0001-44", "nandinhofuba@gmail.com");
        Fornecedor fornecedor = new Fornecedor(02, "Pet Shop Boys", "01.666.879/0001-44", "becodamordida@live.com");
        Fornecedor fornecedor = new Fornecedor(03, "Buba Pet", "01.666.879/0001-44", "sauros@gmail.com");
        Fornecedor fornecedor = new Fornecedor(04, "BolsoLula Pet", "01.666.478/0001-33", "bostilhostil@gmail.com");

        //LISTA DE FORNECEDOR
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);
        listaFornecedor.Add(fornecedor4);

        ViewBag.listaFornecedores = listaFornecedores;


        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
