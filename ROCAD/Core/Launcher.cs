﻿
using System;
using System.Collections.Generic;
using ROCAD.Controller;
using ROCAD.Model;

namespace ROCAD.Core
{
    internal class Launcher
    {
        public static void Main(string[] args)
        {
       //     Response rEtudiant1 = new Response("");
            Response rEtudiant2 = new Response("B");
            Response rEtudiant3 = new Response("D");

            Response rPossible1 = new Response("A");
            Response rPossible2 = new Response("B");
            Response rPossible3 = new Response("C");
            Response rPossible4 = new Response("D");

            List<Response> lrEtudiant = new List<Response>();
       //     lrEtudiant.Add(rEtudiant1);
            lrEtudiant.Add(rEtudiant2);
            lrEtudiant.Add(rEtudiant3);


            List<Response> lrQuestionPossible = new List<Response>();
            lrQuestionPossible.Add(rPossible1);
            lrQuestionPossible.Add(rPossible2);
            lrQuestionPossible.Add(rPossible3);
            lrQuestionPossible.Add(rPossible4);

            List<Response> lrQuestionBonne = new List<Response>();
            lrQuestionBonne.Add(rPossible2);
            lrQuestionBonne.Add(rPossible4);




            Question qEtudiant = new Question("MAMENE ??? TRES SALE? ", 5, 5, lrEtudiant);
            Question qSujet = new Question("MAMENE", 5,5, lrQuestionPossible, lrQuestionBonne);

            List<Question> listeQuestionsSujet = new List<Question>();
            listeQuestionsSujet.Add(qSujet);

            List<Question> listeQuestionsEtudiant = new List<Question>();
            listeQuestionsEtudiant.Add(qEtudiant);

            Student stu = new Student("21502022","MELLUL","DAVID",listeQuestionsEtudiant);
            Subject s = new Subject(listeQuestionsSujet, stu);

            CorrectionHandler.correct(s);

            Console.WriteLine(stu);


        }
    }
}
