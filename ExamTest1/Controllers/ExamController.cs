using ExamTest1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExamTest1.Controllers
{

    public class ExamController : Controller
    {
        IEnumerable<Question> questions;

        List<Question> results;
        public ExamController()
        {
            Question question = new Question();
            questions = question.GetQuestions().OrderBy(i => i.Id);

            results = new List<Question>();
        }

        public ActionResult Index()
        {           
            
            return View(questions.ToList()[0]);
        }

        //public ActionResult Index(int? qNumber, int id, string Q1)

        [HttpPost]
        public ActionResult Index(Question question)
        {
            var qNumber = question.Id;
            //int number = qNumber ?? 1;
            //if (qNumber.HasValue)
            //    number = qNumber.Value + 1;

            if (qNumber == 5)
            {
                //return Content("");
                return RedirectToAction("Finish",  results );
            }
            var nextQuestion = questions.FirstOrDefault(i => i.Id == qNumber+1);

            results.Add(question);
            //results.Add(id, Q1);

            //Q1 = "";

            //qNumber = qNumber + 1;
            return View(nextQuestion);
        }

        // GET: Exam/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exam/Create
        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Finish(List<Question> dictionary)
        {
            string str = "";
            foreach (var item in dictionary)
            {
                str += item.Id.ToString();
            }

            return Content(str + "\nSınav Bitti.");
        }

        // POST: Exam/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exam/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Exam/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exam/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

