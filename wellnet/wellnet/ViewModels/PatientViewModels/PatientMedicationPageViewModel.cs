using GalaSoft.MvvmLight;
    
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wellnet.ViewModels.PatientViewModels
{
    public class PatientMedicationPageViewModel : ViewModelBase
    {

        private IEnumerable<PatientDetails> ptdetails;
        public PatientMedicationPageViewModel()
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
