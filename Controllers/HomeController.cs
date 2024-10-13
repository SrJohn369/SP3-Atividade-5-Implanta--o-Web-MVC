using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SP3_Atividade_5_Implanta__o_Web_MVC_.Models;

namespace SP3_Atividade_5_Implanta__o_Web_MVC_.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instâncias de Cliente
        Cliente cliente1 = new(42, "João Silva", "123.456.789-01", "joao.silva@example.com", "Canela");
        Cliente cliente2 = new(43, "Maria Souza", "987.654.321-02", "maria.souza@example.com", "Bella");
        Cliente cliente3 = new(44, "José Oliveira", "111.222.333-03", "jose.oliveira@example.com", "Max");
        Cliente cliente4 = new(45, "Ana Paula", "444.555.666-04", "ana.paula@example.com", "Luna");
        Cliente cliente5 = new(46, "Carlos Alberto", "777.888.999-05", "carlos.alberto@example.com", "Rocky");
        // lista de clietnes
        List<Cliente> listaDeClientes = new();
        listaDeClientes.Add(cliente1);
        listaDeClientes.Add(cliente2);
        listaDeClientes.Add(cliente3);
        listaDeClientes.Add(cliente4);
        listaDeClientes.Add(cliente5);

        // ViewBags de clientes
        ViewBag.Clientes = listaDeClientes;

        // instâncias de Fornecedores
        Fornecedor fornecedor1 = new(1, "12.345.678/0001-01", "Fornecedor A", "fornecedor.a@example.com");
        Fornecedor fornecedor2 = new(2, "23.456.789/0002-02", "Fornecedor B", "fornecedor.b@example.com");
        Fornecedor fornecedor3 = new(3, "34.567.890/0003-03", "Fornecedor C", "fornecedor.c@example.com");
        Fornecedor fornecedor4 = new(4, "45.678.901/0004-04", "Fornecedor D", "fornecedor.d@example.com");
        Fornecedor fornecedor5 = new(5, "56.789.012/0005-05", "Fornecedor E", "fornecedor.e@example.com");
        // lista de fornecedores
        List<Fornecedor> listaDeFornecedores = new();
        listaDeFornecedores.Add(fornecedor1);
        listaDeFornecedores.Add(fornecedor2);
        listaDeFornecedores.Add(fornecedor3);
        listaDeFornecedores.Add(fornecedor4);
        listaDeFornecedores.Add(fornecedor5);

        // ViewBags de fornecedores
        ViewBag.Fornecedores = listaDeFornecedores;

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
