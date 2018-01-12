using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRecursosHumanos.Entities
{
    class Applicant
    {
        private int id;
        private string cedula;
        private string name;
        private string aspirePosition;
        private int idDepartment;
        private double aspireSalary;
        private string mainCompetences;
        private string mainTrainings;
        private int idJobExperiences;
        private string recommendedBy;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string AspirePosition
        {
            get
            {
                return aspirePosition;
            }

            set
            {
                aspirePosition = value;
            }
        }

        public int IdDepartment
        {
            get
            {
                return idDepartment;
            }

            set
            {
                idDepartment = value;
            }
        }

        public double AspireSalary
        {
            get
            {
                return aspireSalary;
            }

            set
            {
                aspireSalary = value;
            }
        }

        public string MainCompetences
        {
            get
            {
                return mainCompetences;
            }

            set
            {
                mainCompetences = value;
            }
        }

        public string MainTrainings
        {
            get
            {
                return mainTrainings;
            }

            set
            {
                mainTrainings = value;
            }
        }

        public int IdJobExperiences
        {
            get
            {
                return idJobExperiences;
            }

            set
            {
                idJobExperiences = value;
            }
        }

        public string RecommendedBy
        {
            get
            {
                return recommendedBy;
            }

            set
            {
                recommendedBy = value;
            }
        }
    }
}
