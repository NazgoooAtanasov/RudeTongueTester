using RudeToungeTesterML.Model;

namespace RudeToungeTester.Solver
{
    public class Solver : ISolver
    {
        private ModelInput _modelInput;

        public Solver(ModelInput modelInput)
        {
            this._modelInput = modelInput;
        }

        public string Solve(string textToSolve)
        {
            this._modelInput.SentimentText = textToSolve;

            return ConsumeModel.Predict(this._modelInput).Prediction;
        }
    }
}
