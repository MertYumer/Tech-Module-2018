using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Data;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new ToDoDbContext())
            {
                var allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Comments))
            {
                return RedirectToAction("Index");
            }

            using (var db = new ToDoDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new ToDoDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ToDoDbContext())
                {
                    var currentTask = db.Tasks.FirstOrDefault(t => t.Id == task.Id);
                    currentTask.Title = task.Title;
                    currentTask.Comments = task.Comments;
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            using (var db = new ToDoDbContext())
            {
                var task = db.Tasks.FirstOrDefault(t => t.Id == id);

                if (task == null)
                {
                    return RedirectToAction("Index");
                }

                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (var db = new ToDoDbContext())
            {
                var currentTask = db.Tasks.FirstOrDefault(t => t.Id == task.Id);

                if (currentTask != null)
                {
                    db.Tasks.Remove(currentTask);
                    db.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}