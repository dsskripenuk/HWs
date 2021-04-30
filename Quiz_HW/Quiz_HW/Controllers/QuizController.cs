using Quiz_HW.Entity;
using Quiz_HW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiz_HW.Controllers
{
    public class QuizController : Controller
    {
        private readonly EFContext _context;

        public QuizController()
        {
            _context = new EFContext();
        }

        // GET: Quiz
        [HttpGet]
        public ActionResult Index()
        {
            List<QuestionViewModel> data = _context.Questions.Select(t => new QuestionViewModel()
            {
                Id = t.Id,
                TextQuestion = t.TextQuestion,
                asnw1 = t.asnw1,
                asnw2 = t.asnw2,
                asnw3 = t.asnw3,
                asnw4 = t.asnw4
            }).ToList();
            return View(data);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddQuestionViewModel t)
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

        public ActionResult Delete(int Id)
        {
            var delQuest = _context.Questions.FirstOrDefault(t => t.Id == Id);

            if (delQuest != null)
            {
                _context.Questions.Remove(delQuest);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", "Quiz");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            var editQuest = _context.Questions.Select(t => new QuestionViewModel
            {
                TextQuestion = t.TextQuestion,
                asnw1 = t.asnw1,
                asnw2 = t.asnw2,
                asnw3 = t.asnw3,
                asnw4 = t.asnw4
            }).FirstOrDefault(t => t.Id == Id);

            if (editQuest != null)
                return View(editQuest);
            else
                return RedirectToAction("Index", "Quiz");
        }

        [HttpPost]
        public ActionResult Edit(QuestionViewModel model)
        {
            var editQuest = _context.Questions.FirstOrDefault(t => t.Id == model.Id);

            if (editQuest != null)
            {
                editQuest.TextQuestion = model.TextQuestion;
                editQuest.asnw1 = model.asnw1;
                editQuest.asnw2 = model.asnw2;
                editQuest.asnw3 = model.asnw3;
                editQuest.asnw4 = model.asnw4;

                _context.SaveChanges();
                return RedirectToAction("Index", "Quiz");
            }
            else
                return RedirectToAction("Index", "Quiz");

        }
    }
}