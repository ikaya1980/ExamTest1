using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamTest1.Models
{
    public class Question
    {
        public Question()
        {

        }

        public Question(string text, string sectionA, string sectionB, string sectionC, string correctAnswer)
        {
            this.Text = text;
            this.SectionA = sectionA;
            this.SectionB = sectionB;
            this.SectionC = sectionC;
            this.CorrectAnswer = correctAnswer;
        }

        public int Id { get; set; }


        public string Text { get; set; }

        public string SectionA { get; set; }

        public string SectionB { get; set; }

        public string SectionC { get; set; }

        public bool boolSectionA { get; set; }
        public bool boolSectionB { get; set; }
        public bool boolSectionC { get; set; }

        public string CorrectAnswer { get; set; }

        public List<Question> GetQuestions()
        {
            List<Question> questions = new List<Question>();
            questions.Add(new Question() { Id = 1, Text = "Türkiyenin başkenti neresidir?", SectionA = "İzmir", SectionB = "İstanbul", SectionC = "Ankara", CorrectAnswer = "Ankara" });
            questions.Add(new Question() { Id = 2, Text = "Almanya başkenti neresidir?", SectionA = "Berlin", SectionB = "İstanbul", SectionC = "Ankara", CorrectAnswer = "Berlin" });
            questions.Add(new Question() { Id = 3, Text = "Fransa başkenti neresidir?", SectionA = "İzmir", SectionB = "Paris", SectionC = "Ankara", CorrectAnswer = "Paris" });
            questions.Add(new Question() { Id = 4, Text = "Amerika başkenti neresidir?", SectionA = "İzmir", SectionB = "İstanbul", SectionC = "Dc Washington", CorrectAnswer = "Dc Washington" });
            questions.Add(new Question() { Id = 5, Text = "Vietnam başkenti neresidir?", SectionA = "İzmir", SectionB = "Honeo", SectionC = "Ankara", CorrectAnswer = "Honeo" });


            return questions;


        }


    }
}