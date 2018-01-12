using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRecursosHumanos.Entities
{
    class Trainings
    {
        private int id;
        private string description;
        private int idTrainingLevel;
        private DateTime beginDate;
        private DateTime finishDate;
        private string institution;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int IdTrainingLevel
        {
            get
            {
                return idTrainingLevel;
            }

            set
            {
                idTrainingLevel = value;
            }
        }

        public DateTime BeginDate
        {
            get
            {
                return beginDate;
            }

            set
            {
                beginDate = value;
            }
        }

        public DateTime FinishDate
        {
            get
            {
                return finishDate;
            }

            set
            {
                finishDate = value;
            }
        }

        public string Institution
        {
            get
            {
                return institution;
            }

            set
            {
                institution = value;
            }
        }
    }
}
