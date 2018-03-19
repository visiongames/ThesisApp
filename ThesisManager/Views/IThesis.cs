using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisManager.Views
{
    public interface IThesis
    {
        
        
        string EmailAdres { get; set; }

        string ThesisDateCreation { get; set; }

        int StudentIndexNumber { get; set; }

        string StudentName { get; set; }

        string StudentLastName { get; set; }

        string StudentSpecialization { get; set; }

        string Degree { get; set; }

        string TypeOfLearning { get; set; }

        string TopicOfThesisPolish { get; set; }

        string TopicOfThesisEnglish { get; set; }

        string TeacherAdvisorName { get; set; }

        string FieldOfStudy { get; set; }


    }
}
