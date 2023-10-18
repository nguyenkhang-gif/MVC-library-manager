using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using final_project.Models;
using Microsoft.EntityFrameworkCore;

namespace final_project.Controllers;

public class HomeController : Controller
{

    private readonly IPersonRepository repo;

    public HomeController(IPersonRepository repo)
    {
        this.repo = repo;
    }

    public async Task<IActionResult> Index()
    {
        // repo.Persons.ToListAsync().ForEachAsync((item) =>
        // {
        //     Console.WriteLine(item.LastName);

        // });
        var data = await repo.Persons.ToListAsync();
        

        return  View(data);
    }




}
