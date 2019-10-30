using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CDavisAboutMe
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SkillsPage : ContentPage
    {
        public ObservableCollection<SkillItem> Skills { get; set; }
        public SkillsPage()
        {
            InitializeComponent();

            this.Skills = new ObservableCollection<SkillItem>();

            SkillItem microsoftSkill = new SkillItem();
            microsoftSkill.Name = "Microsoft Office";
            microsoftSkill.Icon = "microsoft.png";

            SkillItem sqlSkill = new SkillItem();
            sqlSkill.Name = "SQL and Database";
            sqlSkill.Icon = "db.png";

            SkillItem problemSkill = new SkillItem();
            problemSkill.Name = "Problem Solving";
            problemSkill.Icon = "mindmap.png";

            Skills.Add(microsoftSkill);
            Skills.Add(sqlSkill);
            Skills.Add(problemSkill);

            skillsList.ItemsSource = this.Skills;


        }
    }
}