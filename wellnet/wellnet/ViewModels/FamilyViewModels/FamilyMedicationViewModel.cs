using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wellnet.ViewModels.FamilyViewModels
{
  public  class FamilyMedicationViewModel:ViewModelBase

    {

        private IEnumerable<PatientDetails> ptdetails;
        public FamilyMedicationViewModel()
        {
            var db = new DBInit();
            ptdetails = db.GetDetails();
        }


        public IEnumerable<PatientDetails> PtDetails
        {

            get
            {

                return this.ptdetails;
            }

            set
            {
                this.ptdetails = value;

            }

        }
    }
}
