using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (var db = new ToDoDbContext())
            {
                //Display all existing tasks.
                List<Task> allTasks = db.Tasks.ToList();
                return View(allTasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            //Display the Create page.
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            if (string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Comments))
            {
                //If there is not added title or comments, return to the Index page.
                return RedirectToAction("Index");
            }

            using (var db = new ToDoDbContext())
            {
                //Add the task to the database and save the changes.
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var db = new ToDoDbContext())
            {
                //Check if the current task exists in the database.
                Task currentTask = db.Tasks.FirstOrDefault(x => x.Id == id);
                //If the task doesn't exist, return to the Index page.
                if (currentTask == null)
                {
                    return RedirectToAction("Index");
                }

                //Else - display the Edit page.
                return View(currentTask);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            using (var db = new ToDoDbContext())
            {
                //Check for a task with exact same id as the parameter.
                Task currentTask = db.Tasks.FirstOrDefault(x => x.Id == task.Id);
                //If the task doesn't exist, return to the Index page.
                if (currentTask == null)
                {
                    return RedirectToAction("Index");
                }

                //Replace the old properties of the task with the new ones.
                currentTask.Title = task.Title;
                currentTask.Comments = task.Comments;
                //Save the changes.
                db.SaveChanges();

                //Display the Index page.
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Details(int id) //Check what is the URL path when you press the Delete button.
        {
            using (var db = new ToDoDbContext())
            {
                //Check if the current task exists in the database.
                Task currentTask = db.Tasks.FirstOrDefault(x => x.Id == id);
                //If the task doesn't exist, return to the Index page.
                if (currentTask == null)
                {
                    return RedirectToAction("Index");
                }

                //Else - display the Delete page.
                return View(currentTask);
            }
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            using (var db = new ToDoDbContext())
            {
                //Check if the current task exists in the database.
                Task currentTask = db.Tasks.FirstOrDefault(x => x.Id == id);
                //If the task doesn't exist, return to the Index page.
                if (currentTask == null)
                {
                    return RedirectToAction("Index");
                }

                //Else - remove the task from the list and save the changes.
                db.Tasks.Remove(currentTask);
                db.SaveChanges();
            }

            //Display the Index page.
            return RedirectToAction("Index");
        }
    }
}