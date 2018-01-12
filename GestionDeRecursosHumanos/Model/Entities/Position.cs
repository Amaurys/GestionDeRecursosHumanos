using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeRecursosHumanos.Entities
{
    class Position
    {
        private int id;
        private string positionp;
        private int idRiskLevel;
        private double minimunSalaryLevel;
        private double maximunSalaryLevel;
        private bool status;

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

        public string Positionp
        {
            get
            {
                return positionp;
            }

            set
            {
                positionp = value;
            }
        }

        public int IdRiskLevel
        {
            get
            {
                return idRiskLevel;
            }

            set
            {
                idRiskLevel = value;
            }
        }

        public double MinimunSalaryLevel
        {
            get
            {
                return minimunSalaryLevel;
            }

            set
            {
                minimunSalaryLevel = value;
            }
        }

        public double MaximunSalaryLevel
        {
            get
            {
                return maximunSalaryLevel;
            }

            set
            {
                maximunSalaryLevel = value;
            }
        }

        public bool Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }
    }
}
