﻿
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ROCAD.Controller;
using ROCAD.Model;

namespace ROCAD.Core
{
    internal class Launcher
    {
        public static void Main(string[] args)
        {
            Response rPossible1 = new Response("A");
            Response rPossible2 = new Response("D");
            Response rPossible3 = new Response("C");
            Response rPossible4 = new Response("B");

            List<Response> lrEtudiant = new List<Response>();



            List<Response> lrQuestionPossible = new List<Response>();
            lrQuestionPossible.Add(rPossible1);
            lrQuestionPossible.Add(rPossible2);
            lrQuestionPossible.Add(rPossible3);
            lrQuestionPossible.Add(rPossible4);

            List<Response> lrQuestionBonne = new List<Response>();
            lrQuestionBonne.Add(rPossible4);
            lrQuestionBonne.Add(rPossible3);
            lrQuestionBonne.Add(rPossible2);




            Question qEtudiant = new Question("MAMENE ??? TRES SALE? ", 5, 5, lrEtudiant);
            Question qSujet = new Question("MAMENE", 5,5, lrQuestionPossible, lrQuestionBonne);

            List<Question> listeQuestionsSujet = new List<Question>();
            listeQuestionsSujet.Add(qSujet);

            List<Question> listeQuestionsEtudiant = new List<Question>();
            listeQuestionsEtudiant.Add(qEtudiant);

            Student stu = new Student("21502022",listeQuestionsEtudiant);
            Subject s = new Subject(listeQuestionsSujet, stu);

            CorrectionHandler.correct(s);


            Console.WriteLine(stu);

            String title = "DS_deSaumon";
            String path = title + "";
            Project p = new Project("Denis Pallez","BD",s,"60","18/01/2017");
            Student stu2 = new Student("52",listeQuestionsEtudiant);

            p.addStudent(stu);
            p.addStudent(stu2);

            p.save(path);
            Project p_load = Project.load(path);


            Debug.WriteLine(p.title());
            Debug.WriteLine(p_load.title());
            if (p.Equals(p_load)) Debug.WriteLine("t'as save mec !");


            List<Student> l = new List<Student>();
            l.Add(stu);

            ExportationHandler.exportAsCsv(p.studentList(), p.title()+"_"+p.date()+"_"+p.time());

            PDFHandler pdf = new PDFHandler();
            pdf.initDocumentCreation(p);
            pdf.generateSheets();
        }
    }
}
