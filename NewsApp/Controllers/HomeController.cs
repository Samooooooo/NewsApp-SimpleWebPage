using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NewsApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NewsApp.Controllers
{
  public class HomeController : Controller
  {
    private NewsAppDBContext dbContext;

    private IWebHostEnvironment hostEnvironment;

    public HomeController(IWebHostEnvironment hostEnvironment, NewsAppDBContext dbContext)
    {
      this.hostEnvironment = hostEnvironment;
      this.dbContext = dbContext;
    }

    public IActionResult Index()
    {
      List<Article> articles = dbContext.Articles
        .OrderByDescending(a => a.Created).ToList();
      ViewModels viewModels = new ViewModels()
      {
        TopArticle = articles.FirstOrDefault(),
        Articles = articles.Skip(1).ToList(),
      };
      return View(viewModels);
    }

    public IActionResult NewArticle()
    {
      GetImages();
      return View();
    }

    [HttpPost]
    public IActionResult NewArticle(Article article)
    {
      if (ModelState.IsValid)
      {
        int max = 0;
        article.Created = DateTime.Now;
        if (dbContext.Articles.Any())
        {
          max = dbContext.Articles.Max(a => a.Id);
        }
        article.Id = max + 1;
        dbContext.Articles.Add(article);

        dbContext.SaveChanges();

        return RedirectToAction("Index");
      }
      else
      {
        GetImages();
        return View();
      }
    }

    public IActionResult Details(int id)
    {
      return View(dbContext.Articles.FirstOrDefault(a => a.Id == id));
    }
    public IActionResult Delete(Article article)
    {
      List<Article> articles = dbContext.Articles
        .OrderByDescending(a => a.Created).ToList();
      ViewModels viewModels = new ViewModels()
      {
        TopArticle = articles.FirstOrDefault(),
        Articles = articles.Skip(1).ToList(),
      };
      return View(viewModels);
    }

    public IActionResult Remove(int id)
    {
      Article tempAR = dbContext.Articles.FirstOrDefault(a => a.Id == id);
      if (tempAR != null)
      {
        dbContext.Articles.Remove(tempAR);
        dbContext.SaveChanges();
        return RedirectToAction("Delete");
      }
      else
      {
        return View("Index");
      }
    }
    public void GetImages()
    {
      string path = Path.Combine(hostEnvironment.WebRootPath, "Image");
      string[] images = Directory.GetFiles(path)
        .Select(s => Path.GetFileName(s))
        .ToArray();
      ViewData["Images"] = new SelectList(images);
    }
  }
}
