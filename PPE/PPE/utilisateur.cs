//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PPE
{
    using System;
    using System.Collections.Generic;
    
    public partial class utilisateur
    {
        public utilisateur()
        {
            this.commentaire__enquete = new HashSet<commentaire__enquete>();
            this.commentaire__quizz = new HashSet<commentaire__quizz>();
            this.commentaire__sondage = new HashSet<commentaire__sondage>();
            this.quizz__complet = new HashSet<quizz__complet>();
            this.sondage__complet = new HashSet<sondage__complet>();
            this.reponse__sequence = new HashSet<reponse__sequence>();
            this.reponse__sondage = new HashSet<reponse__sondage>();
            this.reponse__quizz = new HashSet<reponse__quizz>();
        }
    
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Mail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string IP { get; set; }
        public string Port { get; set; }
    
        public virtual ICollection<commentaire__enquete> commentaire__enquete { get; set; }
        public virtual ICollection<commentaire__quizz> commentaire__quizz { get; set; }
        public virtual ICollection<commentaire__sondage> commentaire__sondage { get; set; }
        public virtual ICollection<quizz__complet> quizz__complet { get; set; }
        public virtual ICollection<sondage__complet> sondage__complet { get; set; }
        public virtual ICollection<reponse__sequence> reponse__sequence { get; set; }
        public virtual ICollection<reponse__sondage> reponse__sondage { get; set; }
        public virtual ICollection<reponse__quizz> reponse__quizz { get; set; }
    }
}