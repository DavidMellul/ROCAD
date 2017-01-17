using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ROCAD.Controller
{
    public class PDFHandler
    {
            public static void func()
            {
                int pageCount = 1;
                int idPage = 1;
                string dateDuQcm = "février 2016";

                int duree = 10; //en min et durée du QCM

                Font arial = FontFactory.GetFont("Arial", 10, Font.BOLDITALIC);
                var doc = new Document();
                string path = Environment.CurrentDirectory;
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(path + "/pdfdoc.pdf", FileMode.Create));
                doc.Open();

                for (int k = 1; k <= 80; k++)
                {
                    doc.NewPage();

                    idPage = k;

                    PdfContentByte cb = writer.DirectContent;

                    //Numéro et Id de la page

                    BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);

                    cb.BeginText();

                    cb.SetFontAndSize(bfTimes, 8);
                    cb.SetTextMatrix(450, 800);  //(xPos, yPos)
                    cb.ShowText("+67" + "/" + pageCount.ToString() + "/" + idPage.ToString());
                    cb.EndText();


                    //Titre de la page (sujet,durée , date )

                    Paragraph title = new Paragraph();

                    //font pour paragraphe

                    title.Alignment = Element.ALIGN_CENTER;

                    title.Font = FontFactory.GetFont("Times", 11, Font.BOLD);
                    title.Add("\nBases de la conception orientée objet \n");
                    title.Add("Diagramme de classes\n");
                    title.Add("Durée : " + duree.ToString() + " min\n");
                    title.Add(dateDuQcm);
                    doc.Add(title);

                    //Identification utilisateur (box) <--------------------------------------------Le probleme de la case est dans cette boucle :)
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

                            cb.Rectangle(doc.PageSize.Width - 500f + z, 700f - i, 10f, 10f);
                            cb.Stroke();
                            PdfContentByte c1 = writer.DirectContent;

                            BaseFont b1 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                            c1.BeginText();
                            c1.SetFontAndSize(b1, 8);
                            c1.SetTextMatrix(107 + z, 700 - i);  //(xPos, yPos)
                            c1.ShowText(j.ToString());

                            c1.EndText();

                            j++;


                        }
                        j = 0;
                    }
                    //Text a cote de l'identification
                    PdfContentByte c2 = writer.DirectContent;

                    BaseFont b2 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    c2.BeginText();
                    c2.SetFontAndSize(b2, 10);
                    c2.SetTextMatrix(350, 620);  //(xPos, yPos)
                    c2.ShowText("codez votre numéro d'étudiant ci-contre");

                    c2.EndText();

                    PdfContentByte c3 = writer.DirectContent;

                    BaseFont b3 = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                    c3.BeginText();
                    c3.SetFontAndSize(b2, 10);
                    c3.SetTextMatrix(350, 610);  //(xPos, yPos)
                    c3.ShowText("écriver votre nom et prénom ci-dessous");

                    c3.EndText();
                    //Text dans la case pour nom et prenom

                    PdfContentByte c4 = writer.DirectContent;

                    c4.BeginText();
                    c4.SetFontAndSize(b2, 10);
                    c4.SetTextMatrix(350, 585);  //(xPos, yPos)
                    c4.ShowText("Nom et Prénom :");
                    c4.EndText();

                    PdfContentByte c5 = writer.DirectContent;

                    c5.BeginText();
                    c5.SetFontAndSize(b2, 10);
                    c5.SetTextMatrix(350, 555);  //(xPos, yPos)
                    c5.ShowText(".......................................................................");
                    c5.EndText();

                    //case pour nom et prenom

                    PdfContentByte ca = writer.DirectContent;

                    ca.Rectangle(doc.PageSize.Width - 450f + z, 750f - i, 200f, 50f);
                    Rectangle rect = new Rectangle(
                        doc.PageSize.Width - 90f, 830f,
                        doc.PageSize.Width - 40f, 880f);

                    ca.Stroke();
                    //Consigne pour le doc
                    PdfContentByte c6 = writer.DirectContent;

                    c6.BeginText();
                    c6.SetFontAndSize(b2, 10);
                    c6.SetTextMatrix(300, 535);  //(xPos, yPos)
                    c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "              Pour chacune des questions ci-dessous il y a au moins un réponse juste et au moins une réponse", 95, 500, 0);
                    c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "de fausse. Cochez comme indiqué ci-dessous l'esnemble des réponses justes pour obtenir touts les points", 95, 490, 0);
                    c6.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Mais attention, chaque erreur(réponse juste non cochée ou réponse fausse coché) entraine une pénalité", 95, 480, 0);
                    c6.EndText();

                    //case avant ligne
                    iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance("qcm.png");
                    PNG.ScalePercent(15f);
                    PNG.SetAbsolutePosition(doc.PageSize.Width - 36f - 460f, doc.PageSize.Height - 36f - 350f);
                    doc.Add(PNG);

                    //text explicatife pour bien coché
                    PdfContentByte c7 = writer.DirectContent;
                    c7.BeginText();
                    c7.SetFontAndSize(b2, 10);
                    c7.SetTextMatrix(460, 350);  //(xPos, yPos)
                    c7.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "              Utilisez un stylo NOIR(n'utilisez pas de correcteur) et respectez les consignes sur comment", 120, 460, 0);
                    c7.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "cocher une case.ATTENTION, une case cochée signifie: oui,cette case répond à la question.", 95, 450, 0);
                    c7.EndText();

                    //ligne

                    c6.SetLineWidth(0f);
                    c6.MoveTo(30, 440);
                    c6.LineTo(570, 440);
                    c6.Stroke();

                    //On commence les questions
                    //Question

                    int[] valeurPos = { 420, 330, 235, 140 };

                    Random rndNumbers = new Random();

                    int returnValue1 = rndNumbers.Next(0, 4);
                    int returnValue2 = rndNumbers.Next(0, 4);
                    while(returnValue2==returnValue1)
                        returnValue2 = RandomNumber(0, 4);

                    int returnValue3 = rndNumbers.Next(0, 4);
                    while (returnValue1==returnValue3 || returnValue2 == returnValue3 ){
                        returnValue3 = rndNumbers.Next(0, 4);
                        Console.WriteLine("returnValue3");
                    }

                    int returnValue4 = rndNumbers.Next(0, 4); ;
                    while(returnValue4==returnValue1 || returnValue4==returnValue2 || returnValue4==returnValue3  ){

                        returnValue4 = rndNumbers.Next(0, 4);
                        Console.WriteLine(returnValue4);
                    }

                    int[] valeurPos1 = { 25, 40, 55,70};

                    Random rndNumbers1 = new Random();

                    int returnValue10 = rndNumbers.Next(0, 4);

                    int returnValue20 = rndNumbers.Next(0, 4);
                    while (returnValue20 == returnValue10)
                        returnValue20 = RandomNumber(0,4);

                    int returnValue30 = rndNumbers.Next(0, 4);
                    while (returnValue10 == returnValue30 || returnValue20 == returnValue30)
                    {
                        returnValue30 = rndNumbers.Next(0, 4);
                    }
                    int returnValue40 = rndNumbers.Next(0, 4); ;
                    while (returnValue40 == returnValue10 || returnValue40 == returnValue20 || returnValue40 == returnValue30)
                    {
                        returnValue40 = rndNumbers.Next(0, 4);
                    }
                    //1

                    PdfContentByte Question1Titre = writer.DirectContent;

                    cb.Rectangle(35f, 395f , 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 380f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 365f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 350f, 10f, 10f);
                    cb.Stroke();

                    BaseFont b4 = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, false);
                    Question1Titre.BeginText();
                    Question1Titre.SetFontAndSize(b4, 11);
                    Question1Titre.SetTextMatrix(30, 420);  //(xPos, yPos)
                    Question1Titre.ShowText("Question 1");
                    Question1Titre.EndText();

                    PdfContentByte questionA = writer.DirectContent;
                    questionA.BeginText();
                    questionA.SetFontAndSize(b2, 11);
                    questionA.SetTextMatrix(30, 420);  //(xPos, yPos)
                    questionA.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "                    A partir du seul diagramme de cas d'utilisation,quelles propositions sont vraies", 30, valeurPos[returnValue1], 0);
                    questionA.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un instructeur peut saisir les données d'un vol", 50, valeurPos[returnValue1]-valeurPos1[returnValue10], 0);
                    questionA.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un pilote peut demander à vocaliser les données courantes du vol", 50, valeurPos[returnValue1]-valeurPos1[returnValue20], 0);
                    questionA.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un pilote peut saisir les données d'un vol", 50, valeurPos[returnValue1] - valeurPos1[returnValue30], 0);
                    questionA.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un instructeur peut demander à vocaliser les données courantes du vol", 50, valeurPos[returnValue1] - valeurPos1[returnValue40], 0);
                    questionA.EndText();

                    //2

                    PdfContentByte Question2Titre = writer.DirectContent;

                    cb.Rectangle(35f, 305f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 290f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 275, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 260, 10f, 10f);//15
                    cb.Stroke();

                    Question2Titre.BeginText();
                    Question2Titre.SetFontAndSize(b4, 11);
                    Question2Titre.SetTextMatrix(30, 330);  //(xPos, yPos) //25
                    Question2Titre.ShowText("Question 2");
                    Question2Titre.EndText();

                    PdfContentByte questionB = writer.DirectContent;
                    questionB.BeginText();
                    questionB.SetFontAndSize(b2, 11);
                    questionB.SetTextMatrix(30, 420);  //(xPos, yPos)
                    questionB.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "                    A partit du seul diagramme de classe quelles propostions sont vraies :", 30, valeurPos[returnValue2], 0);
                    questionB.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Le GPS fait parti du sytéme modélisé", 50, valeurPos[returnValue2] - valeurPos1[returnValue10], 0);
                    questionB.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "L'instructeur est un acteur du systeme", 50, valeurPos[returnValue2] - valeurPos1[returnValue20], 0);
                    questionB.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Le GPS est l'acteur du systéme", 50, valeurPos[returnValue2] - valeurPos1[returnValue30], 0);
                    questionB.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Le GPS est un sytéme externe. On devra s'y connecter.", 50, valeurPos[returnValue2] - valeurPos1[returnValue40], 0);
                    questionB.EndText();

                    //3

                    PdfContentByte Question3Titre = writer.DirectContent;

                    cb.Rectangle(35f, 210f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 195f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 180f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 165f, 10f, 10f);//15
                    cb.Stroke();

                    Question2Titre.BeginText();
                    Question2Titre.SetFontAndSize(b4, 11);
                    Question2Titre.SetTextMatrix(30, 235);  //(xPos, yPos) //25
                    Question2Titre.ShowText("Question 3");
                    Question2Titre.EndText();

                    PdfContentByte questionC = writer.DirectContent;

                    questionC.BeginText();
                    questionC.SetFontAndSize(b2, 11);
                    questionC.SetTextMatrix(30, 420);  //(xPos, yPos)
                    questionC.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "                    A partir du seul diagramme de séquence , quelle propositions sont vraies :", 30, valeurPos[returnValue3], 0);
                    questionC.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Saisir les données du vol peut se faire oralement.", 50, valeurPos[returnValue3] - valeurPos1[returnValue10], 0);
                    questionC.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Demander les informations météo peut conduire à sélectionner l'unité", 50, valeurPos[returnValue3] -valeurPos1[returnValue20], 0);
                    questionC.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Une demande de sélection d'unité peut être étendue en demandant les informations météo", 50, valeurPos[returnValue3] - valeurPos1[returnValue30], 0);
                    questionC.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Tout accés aux données des vols passés implique de s'authentifier.", 50, valeurPos[returnValue3] - valeurPos1[returnValue40], 0);

                    questionC.EndText();

                    //4

                    PdfContentByte Question4Titre = writer.DirectContent;

                    cb.Rectangle(35f, 115f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 100f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 85f, 10f, 10f);
                    cb.Stroke();
                    cb.Rectangle(35f, 70, 10f, 10f);//15
                    cb.Stroke();

                    Question4Titre.BeginText();
                    Question4Titre.SetFontAndSize(b4, 11);
                    Question4Titre.SetTextMatrix(30, 140);  //(xPos, yPos) //25
                    Question4Titre.ShowText("Question 4");
                    Question4Titre.EndText();

                    PdfContentByte questionD = writer.DirectContent;

                    questionD.BeginText();
                    questionD.SetFontAndSize(b2, 11);
                    questionD.SetTextMatrix(30, 420);  //(xPos, yPos)
                    questionD.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "                    Quelle propriétés sont vraies relativement au diagramme de classe donné", 30, valeurPos[returnValue4], 0);
                    questionD.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Une route est associée à un seul vol", 50, valeurPos[returnValue4] - valeurPos1[returnValue10], 0);
                    questionD.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un pilote peut n'avoir accmpli aucune route.", 50, valeurPos[returnValue4] - valeurPos1[returnValue20], 0);
                    questionD.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un élève pilote peut avoir accompli plusieurs routes.", 50, valeurPos[returnValue4] - valeurPos1[returnValue30], 0);
                    questionD.ShowTextAligned(PdfContentByte.ALIGN_LEFT, "Un instructeur a un nom", 50, valeurPos[returnValue4] - valeurPos1[returnValue40], 0);
                    questionD.EndText();
                }
                doc.Close();
                System.Diagnostics.Process.Start(path + "/pdfdoc.pdf");
            }

            private static int RandomNumber(int min, int max)
            {
                Random random = new Random();
                return random.Next(min, max);
            }
        }
    }


