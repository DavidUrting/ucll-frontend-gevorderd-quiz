using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontEndGevorderdQuiz.Web.Models
{
    /// <summary>
    /// Dit stelt één antwoord van de speler voor. 
    /// </summary>
    public class QuizAntwoord
    {
        /// <summary>
        /// ID van de vraag waarvoor dit een antwoord van de speler is.
        /// </summary>
        public int VraagId { get; set; }

        /// <summary>
        /// Index van het gekozen antwoord (dus 0, 1, 2 of 3).
        /// </summary>
        public int GekozenAntwoordIndex { get; set; }
    }
}
