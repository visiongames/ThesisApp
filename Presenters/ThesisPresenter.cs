using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThesisManager.Domain;
using ThesisManager.Views;
using ThesisManager.Models;

namespace ThesisManager.Presenters
{
    
    public class ThesisPresenter
    {
        IThesis thesisView;
        private ThesisModel currentThesisValues;

        public ThesisPresenter(IThesis view)
        {
            thesisView = view;
        }

        public void SetThesis()
        {
            //populate thesis model 
            currentThesisValues =  new ThesisModel(
                thesisView.EmailAdres, 
                thesisView.ThesisDateCreation, 
                thesisView.StudentIndexNumber, 
                thesisView.StudentName, 
                thesisView.StudentLastName, 
                thesisView.StudentSpecialization, 
                thesisView.Degree, 
                thesisView.TypeOfLearning, 
                thesisView.TopicOfThesisPolish, 
                thesisView.TopicOfThesisEnglish, 
                thesisView.TeacherAdvisorName, 
                thesisView.FieldOfStudy);
            
            InitThesisDatabase();
        }

        private void InitThesisDatabase()
        {
            DbHandler thesisDatabase = new DbHandler();
            thesisDatabase.AddThesis(currentThesisValues);
        }
        
        //to do imp new table with custom data fields
        public void PreloadFieldData()
        {

        }

    }
}
