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
    
    public partial class question__quizz
    {
        public question__quizz()
        {
            this.reponse__quizz = new HashSet<reponse__quizz>();
        }
    
        public int id { get; set; }
        public string Intitule { get; set; }
        public Nullable<int> quizz_id { get; set; }
    
        public virtual ICollection<reponse__quizz> reponse__quizz { get; set; }
        public virtual quizz quizz { get; set; }
    }
}