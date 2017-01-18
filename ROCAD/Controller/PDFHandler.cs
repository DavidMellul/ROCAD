using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ROCAD.Factory;
using ROCAD.Model;

namespace ROCAD.Controller
{
    public class PDFHandler
    {
        private string QCM_DATE;
        private string QCM_TIME;
        private string QCM_TITLE;

        private string QCM_FILEPATH;

        private PdfWriter m_writer;
        private Document m_writerData;

        private Project m_referencedProject;

        public void generateSheets()
        {
            List<Student> students = m_referencedProject.studentList();
            Font arial = FontFactory.GetFont("Arial", 10, Font.BOLDITALIC);

            for (int k = 1; k <= students.Count; k++)
            {
                Student studentK = students[k - 1];
                Debug.WriteLine(studentK.id());
                m_writerData.NewPage();

                PdfContentByte cb = m_writer.DirectContent;

                //Numéro et Id de la page
                BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                cb.BeginText();
                cb.SetFontAndSize(bfTimes, 8);
                cb.SetTextMatrix(450, 800); //(xPos, yPos)
                cb.ShowText(studentK.id().ToString() + "/" + k.ToString() + "/" + 1);
                cb.EndText();

                //Titre de la page (sujet,durée , date )
                Paragraph title = new Paragraph();
                title.Alignment = Element.ALIGN_CENTER;
                title.Font = FontFactory.GetFont("Times", 11, Font.BOLD);
                title.Add("\n" + QCM_TITLE + "\n");
                title.Add("Enseignant : "+m_referencedProject.author()+"\n");
                title.Add("Durée : " + QCM_TIME + " mins\n");
                title.Add(QCM_DATE);
                m_writerData.Add(title);

                //Identification utilisateur
                int i = 0;
                int j = 0;
                int y = 0;
                int z = 0;
                for (z = 0; z < 200; z = z + 20)
                {
                    for (i = 0; i < 200; i = i + 20)
                    {

                        if (i == 200 && y <= 6)
                        {

                            j = 0;
                            y++;
                            // z = z + 20;
                            i = 0;
                        }
                        cb.Rectangle(m_writerData.PageSize.Width - 500f + z, 700f - i, 10f, 10f);
                        cb.Stroke();
                        PdfContentByte c1 = m_writer.DirectContent;
                        BaseFont b1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                        c1.BeginText();
                        c1.SetFontAndSize(b1, 8);
                        c1.SetTextMatrix(107 + z, 700 - i); //(xPos, yPos)
                        c1.ShowText(j.ToString());

                        c1.EndText();

                        j++;


                    }
                    j = 0;
                }
                //Text a cote de l'identification
                PdfContentByte c2 = m_writer.DirectContent;

                BaseFont b2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                c2.BeginText();
                c2.SetFontAndSize(b2, 10);
                c2.SetTextMatrix(350, 620); //(xPos, yPos)
                c2.ShowText("codez votre numéro d'étudiant ci-contre");

                c2.EndText();

                PdfContentByte c3 = m_writer.DirectContent;

                BaseFont b3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                c3.BeginText();
                c3.SetFontAndSize(b2, 10);
                c3.SetTextMatrix(350, 610); //(xPos, yPos)
                c3.ShowText("Écrivez votre nom et prénom ci-dessous");

                c3.EndText();
                //Text dans la case pour nom et prenom

                PdfContentByte c4 = m_writer.DirectContent;

                c4.BeginText();
                c4.SetFontAndSize(b2, 10);
                c4.SetTextMatrix(350, 585); //(xPos, yPos)
                c4.ShowText("Nom et Prénom :");
                c4.EndText();

                PdfContentByte c5 = m_writer.DirectContent;

                c5.BeginText();
                c5.SetFontAndSize(b2, 10);
                c5.SetTextMatrix(350, 555); //(xPos, yPos)
                c5.ShowText(".......................................................................");
                c5.EndText();

                //case pour nom et prenom

                PdfContentByte ca = m_writer.DirectContent;

                ca.Rectangle(m_writerData.PageSize.Width - 450f + z, 750f - i, 200f, 50f);
                Rectangle rect = new Rectangle(
                    m_writerData.PageSize.Width - 90f, 830f,
                    m_writerData.PageSize.Width - 40f, 880f);

                ca.Stroke();
                //Consigne pour le doc
                PdfContentByte c6 = m_writer.DirectContent;

                c6.BeginText();
                c6.SetFontAndSize(b2, 10);
                c6.SetTextMatrix(300, 535); //(xPos, yPos)
                c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                    "              Pour chacune des questions ci-dessous il y a au moins un réponse juste et au moins une réponse",
                    95, 500, 0);
                c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                    "de fausse. Cochez comme indiqué ci-dessous l'esnemble des réponses justes pour obtenir touts les points",
                    95, 490, 0);
                c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                    "Mais attention, chaque erreur(réponse juste non cochée ou réponse fausse coché) entraine une pénalité",
                    95, 480, 0);
                c6.EndText();

                //case avant ligne
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("qcm.png");
                PNG.ScalePercent(15f);
                PNG.SetAbsolutePosition(m_writerData.PageSize.Width - 36f - 460f,
                    m_writerData.PageSize.Height - 36f - 350f);
                m_writerData.Add(PNG);

                //Texte explicatif pour bien cocher
                PdfContentByte c7 = m_writer.DirectContent;
                c7.BeginText();
                c7.SetFontAndSize(b2, 10);
                c7.SetTextMatrix(460, 350); //(xPos, yPos)
                c7.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                    "              Utilisez un stylo NOIR(n'utilisez pas de correcteur) et respectez les consignes sur comment",
                    120, 460, 0);
                c7.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                    "cocher une case.ATTENTION, une case cochée signifie: oui,cette case répond à la question.", 95,
                    450, 0);
                c7.EndText();
                //ligne

                c6.SetLineWidth(0f);
                c6.MoveTo(30, 440);
                c6.LineTo(570, 440);
                c6.Stroke();


                // --------------------------------------------- QUESTIONS  --------------------------------------------
                List<Question> questions = this.m_referencedProject.subject(studentK).questionList();

                foreach (Question q in questions)
                {
                    c6.BeginText();
                    c6.SetFontAndSize(b2, 10);
                    c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT,
                        q.description(),
                        95, 500, 0);
                    c6.EndText();
                }
            }

            m_writerData.Close();
            m_writer.Close();
            System.Diagnostics.Process.Start(this.QCM_FILEPATH);

        }

        private static int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }

        public void initDocumentCreation(Project p)
        {
            this.QCM_TITLE = p.title();
            this.QCM_FILEPATH = QCM_TITLE+ ".pdf";
            this.QCM_DATE = p.date();
            this.QCM_TIME = p.time();

            this.m_writerData = new Document();
            this.m_writer = PdfWriter.GetInstance(this.m_writerData, new FileStream(QCM_FILEPATH,FileMode.Create));
            this.m_writerData.Open();

            this.m_referencedProject = p;
        }

       }
    }


