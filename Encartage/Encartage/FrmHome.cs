using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Threading;

namespace Encartage
{
    public partial class FrmHome : Form
    {
        /* @Variables : Pour le mouvement du formulaire */
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        /* @Variables : Stockage des données pour le document xml, excel */
        private static string basePath = AppDomain.CurrentDomain.BaseDirectory;
        private string docXML = $@"{basePath}Config\Encartage.xml";

        public static List<string> listeEditionsDna = new List<string>(); 
        public static List<string> listeEditionsAls = new List<string>();
        public static int nbEdit67Dna = 0;
        public static int nbEdit68Dna = 0;
        public static int nbEdit67Als = 0;
        public static int nbEdit68Als = 0;

        public static List<string> listeTextesASaisir = new List<string>();

        private List<string> listeKeyDico = new List<string>()
        {
            "titre", "initiales", "dateDebut", "dateFin", "nom", "poids", "type", "editions",
            "distrib", "nbExemp", "editionsPorteur", "editionsPartielle", "distribPartielle",
            "nbExempPartielle", "textes"
        };
        private List<string> listeMois = new List<string>()
        {
            "JANVIER", "FÉVRIER", "MARS", "AVRIL", "MAI", "JUIN", "JUILLET", "AOÛT", "SEPTEMBRE",
            "OCTOBRE", "NOVEMBRE", "DÉCEMBRE"
        };

        private char[] tabCharInterdits = new char[] { '/', '\\', ';', ':', '<', '>', '?', '*', '|', '"' };

        /* @Variables : Gestionnaire de menu */
        SaisieEncart saisieEncart;
        ModificationEncart modificationEncart;
        FicheImpression ficheImpression;

        bool saisieEncartIsActual = false;
        bool modifEncartIsActual = false;
        bool ficheImpressionIsActual = false;



        /* @Constructor : Constructeur du formulaire */
        public FrmHome()
        {
            InitializeComponent();
        }



        /* @Event (Form) : Load du formulaire */
        private void frmHome_Load(object sender, EventArgs e)
        {
            this.ActiveControl = lblTitre;
            recupEditions();
            recupTextes();
        }

        #region Animation entrer et sortie menu
        /* @Event (Panel) : Mouse Enter des zones du menu */
        private void lblImpression_MouseEnter(object sender, EventArgs e)
        {
            Panel pnl;
            if (sender is Label)
            {
                pnl = (Panel)((Label)sender).Parent;
            }
            else
            {
                pnl = (Panel)sender;
            }
            pnl.BackColor = Color.FromArgb(235, 235, 235);
        }

        /* @Event (Panel) : Mouse Leave des zones de menu */
        private void lblImpression_MouseLeave(object sender, EventArgs e)
        {
            Panel pnl;
            if (sender is Label)
            {
                pnl = (Panel)((Label)sender).Parent;
            }
            else
            {
                pnl = (Panel)sender;
            }
            pnl.BackColor = Color.White;
        }
        #endregion

        #region Control box
        /* @Event (Bouton) : Click sur le bouton pour minimiser l'application */
        private void btnMinim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.ActiveControl = lblTitre;
        }

        /* @Event (Bouton) : Click sur le bouton pour fermer l'application */
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Click sur un menu
        /* @Event (Panel) : Click sur la partie "Saisie encart" */
        private void lblSaisieEncart_Click(object sender, EventArgs e)
        {
            if (modifEncartIsActual)
            {
                DialogResult d = MsgBox.showYesNo("Voulez-vous annuler la modification de l'encart ?", 
                    "Annuler ?");
                if(d == DialogResult.Yes)
                {
                    pnlContent.Controls.Remove(modificationEncart);
                    modifEncartIsActual = false;
                    buildSaisieEncart();
                }
            }
            else if (ficheImpressionIsActual)
            {
                ficheImpressionIsActual = false;
                pnlContent.Controls.Remove(ficheImpression);
                buildSaisieEncart();
            }
            else
            {
                buildSaisieEncart();
            }
            saisieEncartIsActual = true;
        }

        /* @Event (Panel) : Click sur la partie "Modification encart" */
        private void lblModifEncart_Click(object sender, EventArgs e)
        {
            if (saisieEncartIsActual)
            {
                DialogResult d = MsgBox.showYesNo("Voulez-vous annuler la saisie de l'encart ?",
                    "Annuler ?");
                if (d == DialogResult.Yes)
                {
                    pnlContent.Controls.Remove(saisieEncart);
                    saisieEncartIsActual = false;
                    buildModificationEncart();
                }
            }
            else if (ficheImpressionIsActual)
            {
                ficheImpressionIsActual = false;
                pnlContent.Controls.Remove(ficheImpression);
                buildModificationEncart();
            }
            else
            {
                buildModificationEncart();
            }
            modifEncartIsActual = true;
        }

        /* @Event (Panel) : Click sur la partie "Impression" */
        private void lblImpression_Click(object sender, EventArgs e)
        {
            if (saisieEncartIsActual)
            {
                DialogResult d = MsgBox.showYesNo("Voulez-vous annuler la saisie de l'encart ?",
                    "Annuler ?");
                if (d == DialogResult.Yes)
                {
                    pnlContent.Controls.Remove(saisieEncart);
                    saisieEncartIsActual = false;
                    buildFicheImpression();
                }
            }
            else if (modifEncartIsActual)
            {
                DialogResult d = MsgBox.showYesNo("Voulez-vous annuler la modification de l'encart ?",
                    "Annuler ?");
                if (d == DialogResult.Yes)
                {
                    pnlContent.Controls.Remove(modificationEncart);
                    modifEncartIsActual = false;
                    buildFicheImpression();
                }
            }
            else
            {
                buildFicheImpression();
            }
            ficheImpressionIsActual = true;
        }
        #endregion

        #region Mouvement du formulaire avec la souris
        /* @Event (Panel) : MouseDown de la barre du haut */
        private void lblTitre_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        /* @Event (Panel) : MouseMove de la barre du haut */
        private void lblTitre_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        /* @Event (Panel) : MouseUp de la barre du haut */
        private void lblTitre_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        #region Manipulation du fichier XML
        /* @Method : Récupère toutes les éditions pour les titre DNA et ALS */
        private void recupEditions()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(docXML); //Charge le document xml

                XmlNodeList l = xDoc.SelectNodes("/encartage/titres/titre"); //Noeuds "titre"
                for(int i = 0; i < l.Count; i++)
                {
                    XmlNode n = l[i];
                    if (n.Attributes[0].Value == "DNA")
                    {
                        for(int j = 0; j < n.ChildNodes.Count; j++)
                        {
                            XmlNode nd = n.ChildNodes[j];
                            listeEditionsDna.Add(nd.InnerText); //Ajout à la liste
                            if (nd.InnerText.Contains("67"))
                            {
                                nbEdit67Dna++;
                            }
                            else if (nd.InnerText.Contains("68"))
                            {
                                nbEdit68Dna++;
                            }
                        }
                    }
                    else if(n.Attributes[0].Value == "ALS")
                    {
                        for(int j = 0; j < n.ChildNodes.Count; j++)
                        {
                            XmlNode nd = n.ChildNodes[j];
                            listeEditionsAls.Add(nd.InnerText); //Ajout à la liste
                            if (nd.InnerText.Contains("67"))
                            {
                                nbEdit67Als++;
                            }
                            else if (nd.InnerText.Contains("68"))
                            {
                                nbEdit68Als++;
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MsgBox.show(e.Message, "Erreur avec le document xml");
            }
        }

        /* @Method : Récupère tous les textes prédéfinis à saisir pour l'encart */
        private void recupTextes()
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(docXML); //Charge le document xml

                XmlNode n = xDoc.SelectSingleNode("/encartage/textes"); //Noeud "textes"
                for (int i = 0; i < n.ChildNodes.Count; i++)
                {
                    listeTextesASaisir.Add(n.ChildNodes[i].InnerText);
                }
            }
            catch (Exception e)
            {
                MsgBox.show(e.Message, "Erreur avec le document xml");
            }
        }

        /* @Method : Ajoute un texte dans le document xml */
        public void addTexteXml(string txt)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(docXML); //Charge le document xml

                XmlNode n = xDoc.SelectSingleNode("/encartage/textes"); //Noeud "textes"
                XmlElement newText = xDoc.CreateElement("texte");
                newText.InnerText = txt;
                
                n.AppendChild(newText);

                xDoc.Save(docXML);
            }
            catch(Exception e)
            {
                MsgBox.show(e.Message, "Erreur avec le document xml");
            }
        }
        #endregion

        #region Manipulation des encarts avec les excels
        /* @Method : Sauvegarde l'encart dans la base de données */
        public void saveEncart(Dictionary<string, string> dico)
        {
            bool newFile = false;
            Excel ex = null;
            string directory = getBaseDirectory(dico["dateFin"], dico["titre"]);
            StringBuilder sb = new StringBuilder(directory);
            string maquette = $@"{basePath}MAQUETTES\BDD_MAQUETTE.xlsx";
            string newFilePath = $@"{directory}\BDD.xlsx";

            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            try
            {
                #region Ouverture du fichier existant ou la maquette
                if (File.Exists(newFilePath))
                {
                    ex = new Excel(newFilePath, 1);
                    newFile = false;
                }
                else
                {
                    ex = new Excel(maquette, 1);
                    newFile = true;
                }
                #endregion

                #region Recherche de la ligne vide la plus proche + numéro de l'encart
                int ligneVide = 1;
                while (ex.readCell(ligneVide, 0) != "")
                {
                    ligneVide++;
                }
                #endregion

                #region Remplissage du tableau avec les valeurs
                var data = new object[1, listeKeyDico.Count + 1];
                data[0, 0] = ligneVide.ToString();
                for (int row = 1; row <= 1; row++)
                {
                    for (int column = 2; column <= listeKeyDico.Count + 1; column++)
                    {
                        data[row - 1, column - 1] = dico[listeKeyDico[column - 2]];
                    }
                }
                #endregion

                #region Remplissage de la ligne excel
                int[] tabStart = new int[] { ligneVide, 0 };
                int[] tabEnd = new int[] { ligneVide, listeKeyDico.Count };
                ex.writeToRange(tabStart, tabEnd, data);
                #endregion

                if (newFile) { ex.saveAs(newFilePath); }
                else { ex.save(); }
            }
            catch(Exception e)
            {
                MsgBox.show(e.Message, "Erreur avec le document excel");
            }
            finally
            {
                if(ex != null)
                {
                    ex.close();
                }
            }
        }

        /* @Method : Rebuild la bdd */
        public void rebuildBdd(string dateEncart, string titre, 
            List<Dictionary<string, string>> listeDico)
        {
            Excel ex = null;
            string directory = getBaseDirectory(dateEncart, titre);
            string bdd = $@"{directory}\BDD.xlsx";
            string bddMaquette = $@"{basePath}MAQUETTES\BDD_MAQUETTE.xlsx";

            try
            {
                ex = new Excel(bddMaquette, 1);

                string[,] data = new string[listeDico.Count, listeKeyDico.Count + 1];
                for (int i = 0; i < listeDico.Count; i++)
                {
                    Dictionary<string, string> dico = listeDico[i];
                    data[i, 0] = (i + 1).ToString();
                    for(int column = 2; column <= listeKeyDico.Count + 1; column++)
                    {
                        data[i, column - 1] = dico[listeKeyDico[column - 2]];
                    }
                }
                ex.writeToRange(new int[] { 1, 0 }, 
                    new int[] { listeDico.Count, listeKeyDico.Count + 1 }, data);

                if (File.Exists(bdd))
                {
                    File.Delete(bdd);
                }

                ex.saveAs(bdd);
            }
            catch(Exception e)
            {
                MsgBox.show(e.Message, "Erreur lors de la re-création de la bdd");
            }
            finally
            {
                if(ex != null)
                {
                    ex.close();
                }
            }
        }

        /* @Method : Renvoie une liste de dictionnaire correspond aux encarts du jour avec le titre */
        public List<Dictionary<string, string>> getAllEncart(string dateEncart, string titre)
        {
            Excel ex = null;
            string directory = getBaseDirectory(dateEncart, titre);
            string pathBdd = $@"{directory}\BDD.xlsx";

            try
            {
                if (File.Exists(pathBdd))
                {
                    ex = new Excel(pathBdd, 1);
                    int row = 1;
                    List<Dictionary<string, string>> listeDico = new List<Dictionary<string, string>>();

                    while (ex.readCell(row, 0) != string.Empty)
                    {
                        Dictionary<string, string> dico = new Dictionary<string, string>();
                        dico["numero"] = ex.readCell(row, 0);
                        int column = 1;
                        while (column != listeKeyDico.Count + 1)
                        {
                            dico[listeKeyDico[column - 1]] = ex.readCell(row, column);
                            column++;
                        }
                        listeDico.Add(dico);
                        row++;
                    }
                    return listeDico;
                }
                else
                {
                    MsgBox.show("Il n'y a pas d'encart pour cette date.", "Erreur de date");
                    return null;
                }
            }
            catch(Exception e)
            {
                MsgBox.show(e.Message, "Erreur lors de la récupération des encarts");
                return null;
            }
            finally
            {
                if(ex != null)
                {
                    ex.close();
                }
            }
        }

        /* @Method : Crée le plan du ou des encarts pour une certaine date et un titre*/
        public void buildPlanEncart(string dateEncart, string titre, 
            List<Dictionary<string, string>> listeDico)
        {
            Excel ex = null;
            if (listeDico != null)
            {
                List<string> listeEdit = createListEdit(titre == "DNA" ? listeEditionsDna : listeEditionsAls);
                string planBase = $@"{basePath}MAQUETTES\PLAN_{titre}.xls";
                string directory = getBaseDirectory(dateEncart, titre);
                string pathPlan = $@"{directory}\PLAN.xls";
                try
                {
                    ex = new Excel(planBase, 1);
                    if (File.Exists(pathPlan)) //On le supprime s'il existe
                    {
                        File.Delete(pathPlan);
                    }

                    for(int k = 0; k < listeDico.Count; k++) //Remplit les dicos des éditions
                    {
                        listeDico[k]["editions2"] = getAllEdit(listeDico[k]["editions"], listeDico[k]["titre"]);
                        listeDico[k]["editionsPartielle2"] = getAllEdit(listeDico[k]["editionsPartielle"], 
                            listeDico[k]["titre"]);
                        listeDico[k]["editionsPorteur2"] = getAllEdit(listeDico[k]["editionsPorteur"],
                            listeDico[k]["titre"]);
                    }


                    for (int i = 0; i < listeEdit.Count; i++) //Pour chaque éditions
                    {
                        string[,] data = new string[listeDico.Count, 6];
                        for (int a = 0; a < listeDico.Count; a++) //On remplit le tableau avec du vide
                        {
                            for (int b = 0; b < 6; b++)
                            {
                                data[a, b] = "";
                            }
                        }

                        string editAct = listeEdit[i];
                        int actualRow = 0;
                        for (int j = 0; j < listeDico.Count; j++)
                        {
                            Dictionary<string, string> dicoAct = listeDico[j];

                            if (dicoAct["editions2"].Contains(editAct))
                            {
                                data[actualRow, 0] = listeDico[j]["nom"];
                                if (dicoAct["distrib"].Contains("P") && dicoAct["type"] != "P")
                                {
                                    data[actualRow, 1] = "X";
                                }
                                if (dicoAct["distrib"].Contains("VNO") && dicoAct["type"] != "P")
                                {
                                    data[actualRow, 2] = "X";
                                }
                                if (dicoAct["distrib"].Contains("SB") && dicoAct["type"] != "P")
                                {
                                    data[actualRow, 3] = "X";
                                }
                                if (dicoAct["type"] == "P")
                                {
                                    data[actualRow, 5] = "X";
                                }
                                actualRow++;
                            }
                            else if (dicoAct["editionsPartielle2"].Contains(editAct))
                            {
                                data[actualRow, 0] = listeDico[j]["nom"];
                                data[actualRow, 5] = "X";
                                actualRow++;
                            }
                            else if (dicoAct["editionsPorteur2"].Contains(editAct))
                            {
                                data[actualRow, 0] = listeDico[j]["nom"];
                                data[actualRow, 1] = "X";
                                actualRow++;
                            }
                        }
                        if (editAct == "67L")
                        {
                            ex.writeToRangeNamed($"EDI{editAct}1", data);
                            ex.writeToRangeNamed($"EDI{editAct}2", data);
                        }
                        else
                        {
                            ex.writeToRangeNamed($"EDI{editAct}", data);
                        }
                    }

                    if (titre == "DNA")
                    {
                        ex.writeToCellNamed("DATE1", dateEncart);
                        ex.writeToCellNamed("DATE2", dateEncart);
                    }
                    else
                    {
                        ex.writeToCellNamed("DATE", dateEncart);
                    }

                    ex.saveAs(pathPlan);
                }
                catch (Exception e)
                {
                    MsgBox.show(e.Message, "Erreur lors de la création du plan");
                }
                finally
                {
                    if(ex != null)
                    {
                        ex.close();
                    }
                }
            }
        }

        /* @Method : Crée une seule note après la fin de saisie */
        public void buildNote(Dictionary<string, string> dico)
        {
            Excel ex = null;
            string noteBase = $@"{basePath}MAQUETTES\NOTE_MAQUETTE.xls";
            string directory = getBaseDirectory(dico["dateFin"], dico["titre"]);
            StringBuilder sb = new StringBuilder(directory);
            sb.Append($@"\NOTES\");
            string pathNotes = sb.ToString();

            string change = dico["nom"];
            for(int i = 0; i < tabCharInterdits.Length; i++)
            {
                if (dico["nom"].Contains(tabCharInterdits[i]))
                {
                    change = change.Replace(tabCharInterdits[i], '_');
                }
            }
            if(change == "")
            {
                sb.Append($@"{dico["nom"]}.xls");
            }
            else
            {
                sb.Append($@"{change}.xls");
            }
            

            string pathNote = sb.ToString();

            try
            {
                ex = new Excel(noteBase, 1);
                if (!Directory.Exists(pathNotes))
                {
                    Directory.CreateDirectory(pathNotes);
                }
                if (File.Exists(pathNote))
                {
                    File.Delete(pathNote);
                }

                #region Remplit le document des données
                ex.writeToRangeNamed("TYPE", buildArrayNote(dico));
                ex.writeToCellNamed("TITRE", dico["titre"] == "DNA" ? "DERNIERES NOUVELLES D'ALSACE" : "L'ALSACE");
                ex.writeToCellNamed("POIDS", dico["poids"]);
                ex.writeToCellNamed("NBEXEMP", dico["nbExemp"]);
                ex.writeToCellNamed("DATEDEBUT", dico["dateDebut"]);
                ex.writeToCellNamed("DATEFIN", dico["dateFin"]);
                ex.writeToCellNamed("NOM", dico["nom"]);
                ex.writeToCellNamed("INITIALES", dico["initiales"]);

                if (dico["textes"] != "")
                {
                    string[] tab = dico["textes"].Split(new string[] { ";;;" }, StringSplitOptions.None);
                    string[,] dataTexte = new string[tab.Length, 1];
                    for(int i = 0; i < tab.Length; i++)
                    {
                        dataTexte[i, 0] = tab[i];
                    }
                    ex.writeToRangeNamed("TEXTES", dataTexte);
                }
                #endregion

                ex.saveAs(pathNote);

            }
            catch (Exception e)
            {
                MsgBox.show(e.Message, "Erreur lors de la construction de la note");
            }
            finally
            {
                if(ex != null)
                {
                    ex.close();
                }
            }
        }

        /* @Method : Crée le document : liste des encarts */
        public void buildListeEncart(string dateEncart, string titre, 
            List<Dictionary<string, string>> listeDico)
        {
            Excel ex = null;
            string listeBase = $@"{basePath}MAQUETTES\LISTE_ENCART_MAQUETTE.xls";
            string directory = getBaseDirectory(dateEncart, titre);
            string pathListe = $@"{directory}\LISTE_ENCARTS.xls";

            try
            {
                if (File.Exists(pathListe))
                {
                    File.Delete(pathListe);
                }

                ex = new Excel(listeBase, 1);

                string[,] data = new string[listeDico.Count, 6];
                for(int i = 0; i < listeDico.Count; i++)
                {
                    data[i, 0] = listeDico[i]["nom"];
                    string edit = getAllEdit(listeDico[i]["editions"], titre, true);
                    if(listeDico[i]["editionsPorteur"] != "")
                    {
                        edit += $",{getAllEdit(listeDico[i]["editionsPorteur"], titre, true)}";
                    }
                    if(listeDico[i]["editionsPartielle"] != "")
                    {
                        edit += $",{getAllEdit(listeDico[i]["editionsPartielle"], titre, true)}";
                    }
                    data[i, 1] = edit;

                    data[i, 2] = listeDico[i]["nbExemp"];
                    if (listeDico[i]["poids"] != "")
                    {
                        data[i, 4] = listeDico[i]["poids"] + " g";
                        if(listeDico[i]["nbExemp"] != "")
                        {
                            try
                            {
                                data[i, 5] = ((int.Parse(listeDico[i]["poids"]) * int.Parse(listeDico[i]["nbExemp"])
                                / 1000)).ToString() + " kg";
                            }
                            catch(Exception)
                            {
                                MsgBox.show("Erreur avec le poids ou le nombre d'exemplaire", "Erreur");
                            }
                        }
                    }
                }

                ex.writeToCellNamed("DATE", dateEncart);
                ex.writeToRangeNamed("ENCARTS", data);
                ex.saveAs(pathListe);
            }
            catch(Exception e)
            {
                MsgBox.show(e.Message, "Erreur lors de la création de la liste");
            }
            finally
            {
                if (ex != null)
                {
                    ex.close();
                }
            }
        }

        /* @Method : Renvoie un booleen si un fichier de note existe ou non */
        public bool fileExistNote(string dateEncart, string titre, string nom)
        {
            StringBuilder sb = new StringBuilder(getBaseDirectory(dateEncart, titre));
            sb.Append($@"\NOTES\{nom}");
            return File.Exists(sb.ToString());
        }

        /* @Method : Renvoie le tableau de string correspondant à la note */
        private string[,] buildArrayNote(Dictionary<string, string> d)
        {
            d["editions"] = getAllEdit(d["editions"], d["titre"], true);
            d["editionsPartielle"] = getAllEdit(d["editionsPartielle"], d["titre"], true);
            d["editionsPorteur"] = getAllEdit(d["editionsPorteur"], d["titre"], true);
            string[,] data = null;
            if (d["type"] == "C") //Si édition complète
            {
                if (d["distrib"].Contains("P"))
                {
                    if (d["distrib"].Contains("VNO"))
                    {
                        if (d["distrib"].Contains("SB"))
                        {
                            if (d["distribPartielle"].Contains("P"))
                            {
                                #region Distrib (porteur + VNO + SB) + (edit partielle porteur)
                                data = new string[4, 2]
                                {
                                            {"dans l'ensemble des éditions : ", ""},
                                            {"", d["editions"]},
                                            {"et, suivant jeux séparés dans les districts porteurs des éditions : ", ""},
                                            {"", d["editionsPartielle"]}
                                };
                                #endregion
                            }
                            else
                            {
                                #region Distrib (porteur + VNO + SB)
                                data = new string[2, 2]
                                {
                                            {"dans l'ensemble des éditions : ", ""},
                                            {"", d["editions"]},

                                };
                                #endregion
                            }
                        }
                        else if (d["distribPartielle"].Contains("P"))
                        {
                            if (d["distribPartielle"].Contains("VNO"))
                            {
                                #region Distrib (porteur + VNO) + (edit partielle porteur + VNO)
                                data = new string[4, 2]
                                {
                                            {"dans tous les districts porteurs et la vente au numéro des éditions : ", ""},
                                            {"", d["editions"]},
                                            {"et, suivant jeux séparés, dans les districts porteurs et la vente au numéro des éditions : ", ""},
                                            {"", d["editionsPartielle"]}
                                };
                                #endregion
                            }
                            else if (d["editionsPorteur"] != "")
                            {
                                #region Distrib (porteur + VNO) + (edit partielle porteur) + (port uniq)
                                data = new string[6, 2]
                                {
                                            {"dans tous les districts porteurs et la vente au numéro des éditions : ", ""},
                                            {"", d["editions"]},
                                            {"tous les districts porteurs des éditions : ", ""},
                                            {"", d["editionsPorteur"]},
                                            {"et, suivant jeux séparés, dans une partie des éditions : ", ""},
                                            {"", d["editionsPartielle"]}
                                };
                                #endregion
                            }
                            else
                            {
                                #region Distrib (porteur + VNO) + (edit partielle porteur)
                                data = new string[4, 2]
                                {
                                            {"dans tous les districts porteurs et la vente au numéro des éditions : ", ""},
                                            {"", d["editions"]},
                                            {"et, suivant jeux séparés, dans les districts porteurs des éditions : ", ""},
                                            {"", d["editionsPartielle"]},
                                };
                                #endregion
                            }
                        }
                        else if (d["editionsPorteur"] != "")
                        {
                            #region Distrib (porteur + VNO) + (port uniq)
                            data = new string[4, 2]
                            {
                                        {"dans tous les districts porteurs et la vente au numéro des éditions : ", ""},
                                        {"", d["editions"]},
                                        {"et dans tous les districts porteurs des éditions : ", ""},
                                        {"", d["editionsPorteur"]},
                            };
                            #endregion
                        }
                        else
                        {
                            #region Distrib porteur + VNO
                            data = new string[2, 2]
                            {
                                        {"dans tous les districts porteurs et la vente au numéro des éditions : ", ""},
                                        {"", d["editions"]},
                            };
                            #endregion
                        }
                    }
                    else if (d["distrib"].Contains("SB"))
                    {
                        #region Distrib porteur + VNO
                        data = new string[2, 2]
                        {
                                        {"dans tous les districts porteurs et les sous bandes des éditions : ", ""},
                                        {"", d["editions"]},
                        };
                        #endregion
                    }
                    else if (d["distribPartielle"].Contains("P"))
                    {
                        #region Distrib (porteur) + (edit partielle porteur)
                        data = new string[4, 2]
                        {
                                    {"dans tous les districts porteurs des éditions : ", ""},
                                    {"", d["editions"]},
                                    {"et, suivant jeux séparés, dans les districts porteurs des éditions : ", ""},
                                    {"",  d["editionsPartielle"]},
                        };
                        #endregion
                    }
                    else
                    {
                        #region Distrib (porteur)
                        data = new string[2, 2]
                        {
                                    {"dans tous les districts porteurs des éditions : ", ""},
                                    {"", d["editions"]},
                        };
                        #endregion
                    }
                }
                else if (d["distrib"].Contains("VNO")) //"VNO"
                {
                    if (d["distrib"].Contains("SB"))
                    {
                        #region Distrib (VNO + SB)
                        data = new string[2, 2]
                        {
                                    {"dans la vente au numéro et les s/bandes des éditions : ", ""},
                                    {"", d["editions"]},
                        };
                        #endregion
                    }
                    else if (d["distribPartielle"].Contains("P"))
                    {
                        #region Distrib (VNO) + (edit partielle porteur)
                        data = new string[4, 2]
                        {
                                    {"dans la vente au numéro des éditions : ", ""},
                                    {"", d["editions"]},
                                    {"et, suivant jeux séparés, dans les districts porteurs des éditions : ", ""},
                                    {"", d["editionsPartielle"]},
                        };
                        #endregion
                    }
                    else
                    {
                        #region Distrib (VNO)
                        data = new string[2, 2]
                        {
                                    {"dans la vente au numéro des éditions : ", ""},
                                    {"", d["editions"]},
                        };
                        #endregion
                    }
                }
                else if (d["distrib"].Contains("SB"))
                {
                    #region Distrib (SB)
                    data = new string[2, 2]
                    {
                                {"dans les journaux s/bandes des éditions : ", ""},
                                {"", d["editions"]},
                    };
                    #endregion
                }
            }
            else if (d["type"] == "P") //Si édition partielle
            {
                if (d["distrib"].Contains("P")) //Si Porteur
                {
                    #region Distrib porteur
                    data = new string[2, 2]
                    {
                                {"suivant jeux séparés, dans les districts porteurs des éditions : ", ""},
                                {"", d["editions"]},
                    };
                    #endregion
                }
            }
            return data;
        }
        
        /* @Method : Supprimer un encart de la bdd et sa note */
        public void supprimeEncart(List<Dictionary<string,string>> listeDico, Dictionary<string, string> d)
        {
            Excel ex = null;
            string directory = getBaseDirectory(d["dateFin"], d["titre"]);
            string notes = $@"{directory}\NOTES\";
            string note = $@"{directory}\NOTES\{d["nom"]}.xls";
            string bdd = $@"{directory}\BDD.xlsx";

            try
            {
                if(listeDico.Count == 0)
                {
                    Directory.Delete(directory, true);
                }
                else
                {
                    #region On le supprime de la base de données
                    ex = new Excel(bdd, 1);

                    int row = 0;
                    int column = 0;
                    while (ex.readCell(row, column) != d["numero"])
                    {
                        row++;
                    }
                    int[] tabDepart = new int[] { row, column };

                    int[] tabArrive = new int[] { row, listeKeyDico.Count + 1 };

                    ex.deleteRow(tabDepart, tabArrive);
                    ex.save();
                    ex.close();
                    ex = null;
                    #endregion

                    #region On supprime la note qui lui correspond
                    if (File.Exists(note))
                    {
                        File.Delete(note);
                    }
                    #endregion

                    if (listeDico.Count > 0)
                    {
                        Thread buildPlan = new Thread(() => buildPlanEncart(d["dateFin"], d["titre"], listeDico));
                        buildPlan.Start();

                        Thread buildBdd = new Thread(() => rebuildBdd(d["dateFin"], d["titre"], listeDico));
                        buildBdd.Start();

                        Thread buildList = new Thread(() => buildListeEncart(d["dateFin"], d["titre"], listeDico));
                        buildList.Start();
                    }
                }
            }
            catch (Exception e)
            {
                MsgBox.show(e.Message, "Erreur lors de la suppression de l'encart");
            }
            finally
            {
                if(ex != null)
                {
                    ex.close();
                }
            }
        }
        #endregion

        #region Manipulation des éditions
        /* @Method : Renvoie un string contenant toutes les éditions */
        public static string getAllEdit(string edit, string titre, bool special = false)
        {
            StringBuilder sb = new StringBuilder("");
            if (edit == "67, 68" && !special)
            {
                if (titre == "DNA")
                {
                    for (int i = 0; i < listeEditionsDna.Count; i++)
                    {
                        sb.Append($"{listeEditionsDna[i].Substring(0, 3)},");
                    }
                }
                else if (titre == "ALS")
                {
                    for(int i = 0; i < listeEditionsAls.Count; i++)
                    {
                        sb.Append($"{listeEditionsAls[i].Substring(0,3)},");
                    }
                }
                sb.Remove(sb.Length - 1, 1);
            }
            else if(edit == "67" && !special)
            {
                if (titre == "DNA")
                {
                    for (int i = 0; i < listeEditionsDna.Count; i++)
                    {
                        if (listeEditionsDna[i].Contains("67"))
                        {
                            sb.Append($"{listeEditionsDna[i].Substring(0, 3)},");
                        }
                    }
                }
                else if (titre == "ALS")
                {
                    for (int i = 0; i < listeEditionsAls.Count; i++)
                    {
                        if (listeEditionsAls[i].Contains("67"))
                        {
                            sb.Append($"{listeEditionsAls[i].Substring(0, 3)},");
                        }
                    }
                }
                sb.Remove(sb.Length - 1, 1);
            }
            else if(edit == "68" && !special)
            {
                if (titre == "DNA")
                {
                    for (int i = 0; i < listeEditionsDna.Count; i++)
                    {
                        if (listeEditionsDna[i].Contains("68"))
                        {
                            sb.Append($"{listeEditionsDna[i].Substring(0, 3)},");
                        }
                    }
                }
                else if (titre == "ALS")
                {
                    for (int i = 0; i < listeEditionsAls.Count; i++)
                    {
                        if (listeEditionsAls[i].Contains("68"))
                        {
                            sb.Append($"{listeEditionsAls[i].Substring(0, 3)},");
                        }
                    }
                    sb.Remove(sb.Length - 1, 1);
                }
            }
            else if (edit.StartsWith("67,6"))
            {
                if(titre == "DNA")
                {
                    for(int i = 0; i < listeEditionsDna.Count; i++)
                    {
                        if (listeEditionsDna[i].Contains("67"))
                        {
                            sb.Append($"{listeEditionsDna[i].Substring(0, 3)},");
                        }
                    }
                }
                else if(titre == "ALS")
                {
                    for (int i = 0; i < listeEditionsAls.Count; i++)
                    {
                        if (listeEditionsAls[i].Contains("67"))
                        {
                            sb.Append($"{listeEditionsAls[i].Substring(0, 3)},");
                        }
                    }
                }
                for(int j = 3; j < edit.Length; j++)
                {
                    sb.Append(edit[j]);
                }
            }
            else if (edit.StartsWith("68,6"))
            {
                if (titre == "DNA")
                {
                    for (int i = 0; i < listeEditionsDna.Count; i++)
                    {
                        if (listeEditionsDna[i].Contains("68"))
                        {
                            sb.Append($"{listeEditionsDna[i].Substring(0, 3)},");
                        }
                    }
                }
                else if (titre == "ALS")
                {
                    for (int i = 0; i < listeEditionsAls.Count; i++)
                    {
                        if (listeEditionsAls[i].Contains("68"))
                        {
                            sb.Append($"{listeEditionsAls[i].Substring(0, 3)},");
                        }
                    }
                }
                for (int j = 3; j < edit.Length; j++)
                {
                    sb.Append(edit[j]);
                }
            }
            else
            {
                sb = new StringBuilder(edit);
            }
            return sb.ToString();
        }

        /* @Method : Crée une liste des éditions en version simplifiées ("67A", "67B" ...) */
        private List<string> createListEdit(List<string> listeEdit)
        {
            List<string> l = new List<string>();
            for (int i = 0; i < listeEdit.Count; i++)
            {
                l.Add(listeEdit[i].Substring(0, 3));
            }
            return l;
        }
        #endregion

        /* @Method : Renvoie le repertoire de l'encart */
        public string getBaseDirectory(string date, string titre)
        {
            StringBuilder sb = new StringBuilder(basePath);
            string[] tab = date.Split('.');
            sb.Append($@"ENCARTS\{titre}\{tab[2]}\{listeMois[int.Parse(tab[1]) - 1]}\{date}");
            return sb.ToString();
        }

        #region Build les gestionnaires de menus
        /* @Method : Génére le gestionnaire de menu "Saisie encart" */
        private void buildSaisieEncart()
        {
            saisieEncart = new SaisieEncart()
            {
                Left = 30,
                Top = 30,
            };
            pnlContent.Controls.Add(saisieEncart);
        }

        /* @Method : Génére le gestionnaire de menu "Modification encart" */
        private void buildModificationEncart()
        {
            modificationEncart = new ModificationEncart()
            {
                Left = 30,
                Top = 30,
            };
            pnlContent.Controls.Add(modificationEncart);
        }

        /* @Method : Génére la fiche "Fiche Impression" */
        private void buildFicheImpression()
        {
            ficheImpression = new FicheImpression()
            {
                Left = 130,
                Top = 75,
            };
            pnlContent.Controls.Add(ficheImpression);
        }
        #endregion


        /* @Method : Set les booleens des gestionnaires de menus */
        public bool saisieEncartIsAct
        {
            set
            {
                this.saisieEncartIsActual = value;
            }
        }

    }
}
