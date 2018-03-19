using System;
using System.Windows.Forms;
using ThesisManager.Presenters;
using ThesisManager.Views;

namespace ThesisManager
{
    public partial class RegisterThesisForm : Form, IThesis
    {
        private ThesisPresenter currentPresenter;

        public RegisterThesisForm()
        {
            InitializeComponent();
            RegisterThesisForm_Load();
        }

        private void RegisterThesisForm_Load()
        {
            currentPresenter = new ThesisPresenter(this);
        }

        public string EmailAdres
        {
            get => txtFieldEmailAdres.Text;
            set => txtFieldEmailAdres.Text = value;
        }

        public string ThesisDateCreation
        {
            get
            {
                DateTime myDateTime = DateTime.Now;
                return myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set { }
        }

        public int StudentIndexNumber
        {
            get => int.Parse(txtFieldStudentIndexNumber.Text);
            set => txtFieldEmailAdres.Text = value.ToString();
        }

        public string StudentName
        {
            get => txtFieldStudentName.Text;
            set => txtFieldStudentName.Text = value;
        }

        public string StudentLastName
        {
            get => txtFieldStudentLastName.Text;
            set => txtFieldStudentLastName.Text = value;
        }
        public string StudentSpecialization
        {
            get => comboBoxSpecialization.Text;
            set => comboBoxSpecialization.Text = value;
        }
        public string Degree
        {
            get => checkedListBoxDegree.Text;
            set => checkedListBoxDegree.Text = value;
        }
        public string TypeOfLearning
        {
            get => checkedListBoxTypeOfLerning.Text;
            set => checkedListBoxTypeOfLerning.Text = value;
        }
        public string TopicOfThesisPolish
        {
            get => txtBoxTopicOfThesisPolish.Text;
            set => txtBoxTopicOfThesisPolish.Text = value;
        }
        public string TopicOfThesisEnglish
        {
            get => txtBoxTopicOfThesisEnglish.Text;
            set => txtBoxTopicOfThesisEnglish.Text = value;
        }
        public string TeacherAdvisorName
        {
            get => txtBoxTeacherAdvisorName.Text;
            set => txtBoxTeacherAdvisorName.Text = value;
        }
        public string FieldOfStudy
        {
            get => comboBoxFieldOfStudy.Text;
            set => comboBoxFieldOfStudy.Text = value;
        }

        private void buttonAddThesis_Click(object sender, EventArgs e)
        {
            AssemblyThesis();
        }

        private void AssemblyThesis()
        {
            currentPresenter.SetThesis();
        }
    }
}