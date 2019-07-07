using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothequeGestionPharmacie
{
    public class Produit
    {
        public string Nom { get; set; }
        public decimal Prix { get; set; }
        public DateTime Date_de_peremption { get; set; }
        public Classement_therapeutique Classe_Therapeutique { get; set; }
        public static int Stock { get; private set; }

        enum Classement_therapeutique
        {
            Allergologie,
            Anesthesie_reanimation,
            Antalgique,
            Anti_inflamatoires,
            Cancerologie_et_hematologie,
            Cardiologie_et_angéiologie,
            Contraception_et_interruption_de_grossesse,
            Dermatologie,
            Endocrinologie,
            Gastro_Entéro_Hépatologie,
            Gynécologie,
            Hémostase_et_sang,
            Infectiologie_Parasitologie,
            Métabolisme_et_nutrition,
            Neurologie_psychiatrie,
            Ophtalmologie,
            Oto_rhino_laryngologie,
            Pneumologie,
            Rhumatologie,
            Sang_et_dérivés,
            Souches_Homéopathiques,
            Stomatologie,
            Toxicologie,
            Urologie_néphrologie
        }

        public Produit(string nom, decimal prix, DateTime date_de_peremption, Classement_therapeutique classe_therapeutique)
        {
            this.Classe_Therapeutique = classe_therapeutique;
            this.Date_de_peremption = date_de_peremption;
            this.Nom = nom;
            this.Prix = prix;
        }

        public void Sortie(int quantite)
        {
            if(this.Stock>= quantite)
            {
                this.Stock = this.Stock - quantite;
            }
        }

        public void Entree(int quantite)
        {
            if (quantite > 0)
            {
                this.Stock = this.Stock + quantite;
            }
        }
    }
}
