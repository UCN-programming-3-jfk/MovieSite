using Microsoft.AspNetCore.Mvc;
using MovieSite.DAL;
using MovieSite.DAL.Model;

namespace MovieSite.Website.Controllers;
public class MovieController : Controller
{
    private IMovieDAO _dataAccessLayer;
    public MovieController(IMovieDAO dataAccess)
    {
        _dataAccessLayer = dataAccess;
    }

    // GET: MovieController
    public ActionResult Index()
    {
        return View(_dataAccessLayer.GetAll());
    }

    // GET: MovieController/Details/5
    public ActionResult Details(int id)
    {
        return View(_dataAccessLayer.Get(id));
    }

    // GET: MovieController/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: MovieController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Movie movie)
    {
        try
        {
            _dataAccessLayer.Add(movie);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: MovieController/Edit/5
    public ActionResult Edit(int id)
    {
        return View(_dataAccessLayer.Get(id));
    }

    // POST: MovieController/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, Movie movie)
    {
        try
        {
            _dataAccessLayer.Update(movie);
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: MovieController/Delete/5
    public ActionResult Delete(int id)
    {
        return View(_dataAccessLayer.Get(id));
    }

    // POST: MovieController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, Movie collection)
    {
        try
        {
            View(_dataAccessLayer.Delete(id));
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}