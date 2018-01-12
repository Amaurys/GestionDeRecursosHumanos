using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRecursosHumanos.Entities
{
    class JobExperiences
    {
        private int id;
        private string company;
        private string occuppiedPosition;
        private DateTime beginDate;
        private DateTime finishDate;
        private double salary;

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

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string OccuppiedPosition
        {
            get
            {
                return occuppiedPosition;
            }

            set
            {
                occuppiedPosition = value;
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

        public double Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }
}
