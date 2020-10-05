using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BreedingBeesProblem
{
    public class ViewModel : INotifyPropertyChanged
    {
        private readonly BeeCalculator beeCalculator;

        public BindingList<CellDistance> CellDistances { get; set; }
        public ViewModel()
        {
            beeCalculator = new BeeCalculator();
            CellDistances = new BindingList<CellDistance>();
        }

        private int? pathFrom { get; set; }
        public int? PathFrom
        {
            get { return pathFrom; }
            set { pathFrom = value; changed(); }
        }

        private int? pathTo { get; set; }
        public int? PathTo
        {
            get { return pathTo; }
            set { pathTo = value; changed(); }
        }

        private bool disableButton = true;
        public bool DisableButton
        {
            get { return disableButton; }
            set { disableButton = value; changed(); }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set { message = value; changed(); }
        }
        public void Calculate()
        {
            try
            {
                if (PathTo == 0 && PathFrom == 0)
                {
                    CellDistances.Clear();
                    DisableButton = false;
                    Message = "Program Terminated";
                }
                else if (PathTo > 10000 || PathFrom > 10000)
                {
                    Message = "Inputs must be less than 10000";
                }
                else
                {
                    int? _distance = beeCalculator.GetAnswer(pathFrom, pathTo);
                    CellDistance _CellDistance = new CellDistance() { Source = PathFrom, Destination = PathTo, Distance = _distance };
                    CellDistances.Add(_CellDistance);
                }
            }
            catch
            {
                Message = "Please Check Inputs";
            }
        }

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void changed([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        #endregion
    }
}

