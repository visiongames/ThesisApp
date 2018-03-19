using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThesisManager.Models
{
    public class ThesisModel
    {
        
        private string emailAdres;
        private string thesisDateCreation;
        private int studentIndexNumber;
        private string studentName;
        private string studentLastName;
        private string studentSpecialization;
        private string fieldOfStudy;
        private string degree;
        private string typeOfLearning;
        private string topicOfThesisPolish;
        private string topicOfThesisEnglish;
        private string teacherAdvisorName;

        public ThesisModel(string emailAdres, string thesisDateCreation, int studentIndexNumber, string studentName, string studentLastName, string studentSpecialization, string degree, string typeOfLearning, string topicOfThesisPolish, string topicOfThesisEnglish, string teacherAdvisorName, string fieldOfStudy)
        {
            
            EmailAdres = emailAdres;
            ThesisDateCreation = thesisDateCreation;
            StudentIndexNumber = studentIndexNumber;
            StudentName = studentName;
            StudentLastName = studentLastName;
            StudentSpecialization = studentSpecialization;
            Degree = degree;
            TypeOfLearning = typeOfLearning;
            TopicOfThesisPolish = topicOfThesisPolish;
            TopicOfThesisEnglish = topicOfThesisEnglish;
            TeacherAdvisorName = teacherAdvisorName;
            FieldOfStudy = fieldOfStudy;

        }

        public ThesisModel()
        {

        }

       

        public string EmailAdres
        {
            get => emailAdres;
            set => emailAdres = value;
        }

        public string ThesisDateCreation
        {
            get => thesisDateCreation;
            set => thesisDateCreation = value;
        }

        public int StudentIndexNumber
        {
            get => studentIndexNumber;
            set => studentIndexNumber = value;
        }

        public string StudentName
        {
            get => studentName;
            set => studentName = value;
        }

        public string StudentLastName
        {
            get => studentLastName;
            set => studentLastName = value;
        }

        public string StudentSpecialization
        {
            get => studentSpecialization;
            set => studentSpecialization = value;
        }

        public string Degree
        {
            get => degree;
            set => degree = value;
        }

        public string TypeOfLearning
        {
            get => typeOfLearning;
            set => typeOfLearning = value;
        }

        public string TopicOfThesisPolish
        {
            get => topicOfThesisPolish;
            set => topicOfThesisPolish = value;
        }

        public string TopicOfThesisEnglish
        {
            get => topicOfThesisEnglish;
            set => topicOfThesisEnglish = value;
        }

        public string TeacherAdvisorName
        {
            get => teacherAdvisorName;
            set => teacherAdvisorName = value;
        }

        public string FieldOfStudy
        {
            get => fieldOfStudy;
            set => fieldOfStudy = value;
        }
    }
}
