using Quiz.Entity;
using Quiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz.Controllers
{
    public class QuizController : Controller
    {
        private readonly EFConext _context;

        public QuizController()
        {
            _context = new EFConext();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<QuizViewModel> data = _context.Quizzes.Select(t => new QuizViewModel()
            {
                Id = t.Id,
                Name = t.Name,
                Questions = t.Questions

            }).ToList();

            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddQuestionViewModel t, AddAnswerViewModel a)
        {
            _context.Questions.Add(new Question
            {
                TextQuestion = t.TextQuestion,
                asnw1 = t.asnw1,
                asnw2 = t.asnw2,
                asnw3 = t.asnw3,
                asnw4 = t.asnw4
            });

            

            _context.SaveChanges();

            return RedirectToAction("Index", "Quiz");
        }

        //public ActionResult Delete(int Id)
        //{
        //    var delQuest = _context.Questions.FirstOrDefault(t => t.Id == Id);

        //    if (delQuest != null)
        //    {
        //        _context.Questions.Remove(delQuest);
        //        _context.SaveChanges();
        //    }

        //    return RedirectToAction("Index", "Anime");
        //}

        //[HttpGet]
        //public ActionResult Edit(int Id)
        //{
        //    var editQuest = _context.Questions.Select(t => new QuestionViewModel
        //    {

        //    }).FirstOrDefault(t => t.Id == Id);

        //    if (editQuest != null)
        //        return View(editQuest);
        //    else
        //        return RedirectToAction("Index", "Quiz");
        //}

        //[HttpPost]
        //public ActionResult Edit(QuestionViewModel model)
        //{
        //    var editQuest = _context.Questions.FirstOrDefault(t => t.Id == model.Id);

        //    if (editQuest != null)
        //    {
        //        editQuest.TextQuestion = model.TextQuestion;
        //        editQuest.QuizId = model.QuizId;

        //        _context.SaveChanges();
        //        return RedirectToAction("Index", "Quiz");
        //    }
        //    else
        //        return RedirectToAction("Index", "Quiz");

        //}
    }
}